const assert = require('assert');
const fs = require('fs');
const path = require('path');
const JsonHelper = require('../helpers/json');


const listFolders = (folder) => fs.readdirSync(folder)
  .map((file) => path.join(folder, file))
  .filter((file) => fs.lstatSync(file).isDirectory())
  .map((file) => [path.basename(file), file]);
const listFiles = (folder) => fs.readdirSync(folder)
  .map((file) => path.join(folder, file))
  .filter((file) => fs.lstatSync(file).isFile())
  .map((file) => [path.basename(file), file]);

describe('fixtures', () => {
  const languages = listFolders('test/fixtures')
    .filter(([folderName]) => folderName !== 'json');
  languages.forEach(([languageName, languagePath]) => {
    // eslint-disable-next-line global-require
    const LanguageController = require(path.join('../controllers', languageName));
    describe(languageName, () => {
      const models = listFolders(languagePath);
      models.forEach(([modelName, modelPath]) => {
        describe(modelName, () => {
          const samples = listFiles(modelPath);
          samples.forEach(([sampleName, samplePath]) => {
            it(`should generate ${sampleName} correctly`, () => {
              const jsonFile = path.join('test/fixtures/json', modelName,
                sampleName.replace(/\.[^/.]+$/, '.json'));
              const jsonData = JsonHelper.readFile(jsonFile);
              const languageData = LanguageController.render(modelName, jsonData);
              assert.equal(fs.readFileSync(samplePath, 'utf8'), languageData);
            });
          });
        });
      });
    });
  });
});
