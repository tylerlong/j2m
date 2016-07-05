const fs = require('fs');
const path = require('path');
const curry = require('curry');


const filterFolder = curry((filter, folder) => fs.readdirSync(folder)
  .filter((file) => filter(path.join(folder, file)))
  .map((file) => [file, path.join(folder, file)]));

const listFolders = filterFolder((file) => fs.lstatSync(file).isDirectory());

const listFiles = filterFolder((file) => fs.lstatSync(file).isFile());


module.exports = { listFolders, listFiles };
