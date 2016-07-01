const assert = require('assert');
const fs = require('fs');
const path = require('path');
const JsonHelper = require('../helpers/json');


const listFolders = (folder) => fs.readdirSync(folder).map((file) => path.join(folder, file))
  .filter((file) => fs.lstatSync(file).isDirectory());
const listFiles = (folder) => fs.readdirSync(folder).map((file) => path.join(folder, file))
  .filter((file) => fs.lstatSync(file).isFile())
  .map((file) => path.basename(file));

describe('fixtures', () => {
  const languages = listFolders('test/fixtures')
    .filter((folder) => path.basename(folder) !== 'json');
  languages.forEach((language) => {
    // eslint-disable-next-line global-require
    const LanguageController = require(path.join('../controllers', path.basename(language)));
    describe(path.basename(language), () => {
      const models = listFolders(language);
      models.forEach((model) => {
        describe(path.basename(model), () => {
          const samples = listFiles(model);
          samples.forEach((sample) => {
            it(`should generate ${sample} correctly`, () => {
              const jsonFile = path.join('test/fixtures/json', path.basename(model),
                sample.replace(/\.[^/.]+$/, '.json'));
              const jsonData = JsonHelper.readFile(jsonFile);
              const languageData = LanguageController.render(path.basename(model), jsonData);
              assert.equal(fs.readFileSync(path.join(model, sample), 'utf8'), languageData);
            });
          });
        });
      });
    });
  });
});
