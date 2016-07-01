const assert = require('assert');
const fs = require('fs');
const path = require('path');
const JsonHelper = require('../helpers/json');
const FolderHelper = require('../helpers/folder');


describe('fixtures', () => {
  const languages = FolderHelper.listFolders('test/fixtures')
    .filter(([folderName]) => folderName !== 'json');
  languages.forEach(([languageName, languagePath]) => {
    // eslint-disable-next-line global-require
    const LanguageController = require(path.join('../controllers', languageName));
    describe(languageName, () => {
      const models = FolderHelper.listFolders(languagePath);
      models.forEach(([modelName, modelPath]) => {
        describe(modelName, () => {
          const samples = FolderHelper.listFiles(modelPath);
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
