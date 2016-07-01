// const assert = require('assert');
const fs = require('fs');
const path = require('path');


const listFolders = (folder) => fs.readdirSync(folder).map((file) => path.join(folder, file))
  .filter((file) => fs.lstatSync(file).isDirectory());
const listFiles = (folder) => fs.readdirSync(folder).map((file) => path.join(folder, file))
  .filter((file) => fs.lstatSync(file).isFile()).map((file) => path.basename(file));

const jsonFolder = 'test/fixtures/json';
const models = new Map(listFolders(jsonFolder).map((folder) => [path.basename(folder), listFiles(folder)]));

console.log(models); // eslint-disable-line no-console
// console.log(listFolders(jsonFolder)); // eslint-disable-line no-console
// const listJsonFiles = (folder) => fs.readdirSync(folder)
//   .filter((file) => path.extname(file) === '.json');

// const modelFolders = fs.readdirSync(jsonFolder).map((file) => path.join(jsonFolder, file))
//   .filter((file) => fs.lstatSync(file).isDirectory());
// const models = new Map(modelFolders.map((folder) =>
//   [path.basename(folder), listJsonFiles(folder)]));
// console.log(models); // eslint-disable-line no-console
//
//
// describe('fixtures', () => {
//   fs.readdirSync(jsonFolder).map((file) => path.join(jsonFolder, file))
//     .filter((file) => fs.lstatSync(file).isDirectory())
//     .forEach((folder) => {
//       describe(path.basename(folder), () => {
//         it('should convert', () => {
//
//         });
//       });
//     });
// });
