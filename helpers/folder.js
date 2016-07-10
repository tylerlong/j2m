const fs = require('fs');
const path = require('path');
const curry = require('curry');


const filterFolder = curry((filter, folder) => fs.readdirSync(folder)
  .filter((file) => filter(path.join(folder, file)))
  .map((file) => [file, path.join(folder, file)]));

const listFolders = filterFolder((file) => fs.lstatSync(file).isDirectory());

const listFiles = filterFolder((file) => fs.lstatSync(file).isFile());

const exists = (uri) => {
  try {
    fs.accessSync(uri, fs.F_OK);
    return true;
  } catch (e) {
    return false;
  }
};


module.exports = { listFolders, listFiles, exists };
