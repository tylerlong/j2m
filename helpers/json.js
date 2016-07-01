const fs = require('fs');
const path = require('path');
const deepmerge = require('deepmerge');


const jsonHelper = {
  read_file: (file) => JSON.parse(fs.readFileSync(file, 'utf8')),
  read_folder: (folder) => fs.readdirSync(folder)
    .filter((file) => path.extname(file) === '.json')
    .map((file) => jsonHelper.read_file(path.join(folder, file)))
    .reduce((prev, data) => deepmerge(prev, data), {}),
};


module.exports = jsonHelper;
