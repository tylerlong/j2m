const fs = require('fs');
const path = require('path');


// todo: use currying to refactor, check the idea of Ramda

const folderFilter = (folder, filter) => fs.readdirSync(folder)
  .filter((file) => filter(path.join(folder, file)))
  .map((file) => [file, path.join(folder, file)]);

const listFolders = (folder) => folderFilter(folder,
  (file) => fs.lstatSync(file).isDirectory());

const listFiles = (folder) => folderFilter(folder,
  (file) => fs.lstatSync(file).isFile());


module.exports = { listFolders, listFiles };
