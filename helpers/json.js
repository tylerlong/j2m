const fs = require('fs');
const path = require('path');
const deepmerge = require('deepmerge');


const readFile = (file) => JSON.parse(fs.readFileSync(file, 'utf8'));

const readFiles = (files) => files.map((file) => readFile(file))
  .reduce((prev, data) => deepmerge(prev, data), {});

const readFolder = (folder) => readFiles(fs.readdirSync(folder)
  .filter((file) => path.extname(file) === '.json')
  .map((file) => path.join(folder, file)));


module.exports = { readFile, readFiles, readFolder };
