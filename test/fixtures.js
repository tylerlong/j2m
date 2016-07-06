const assert = require('assert');
const fs = require('fs');
const path = require('path');
const { readFile } = require('../helpers/json');
const { listFolders, listFiles } = require('../helpers/folder');


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
              const jsonData = readFile(jsonFile);
              const languageData = LanguageController.render(modelName, jsonData);
              assert.equal(fs.readFileSync(samplePath, 'utf8'), languageData);
            });
          });
        });
      });
    });
  });
});
