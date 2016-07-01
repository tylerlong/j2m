const fs = require('fs');
const path = require('path');


// todo: use currying to refactor, check the idea of Ramda
const FolderHelper = {
  folderFilter: (folder, filter) => fs.readdirSync(folder)
    .filter((file) => filter(path.join(folder, file)))
    .map((file) => [file, path.join(folder, file)]),
  listFolders: (folder) => FolderHelper.folderFilter(folder,
    (file) => fs.lstatSync(file).isDirectory()),
  listFiles: (folder) => FolderHelper.folderFilter(folder,
    (file) => fs.lstatSync(file).isFile()),
};


module.exports = FolderHelper;
