// const assert = require('assert');
const fs = require('fs');
const path = require('path');


const listJsonFiles = (folder) => fs.readdirSync(folder)
  .filter((file) => path.extname(file) === '.json');
const jsonFolder = 'test/fixtures/json';
const modelFolders = fs.readdirSync(jsonFolder).map((file) => path.join(jsonFolder, file))
  .filter((file) => fs.lstatSync(file).isDirectory());
const models = new Map(modelFolders.map((folder) =>
  [path.basename(folder), listJsonFiles(folder)]));
console.log(models); // eslint-disable-line no-console


describe('fixtures', () => {
  fs.readdirSync(jsonFolder).map((file) => path.join(jsonFolder, file))
    .filter((file) => fs.lstatSync(file).isDirectory())
    .forEach((folder) => {
      describe(path.basename(folder), () => {
        it('should convert', () => {

        });
      });
    });
});
