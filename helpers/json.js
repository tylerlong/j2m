const fs = require('fs');
const path = require('path');
const deepmerge = require('deepmerge');


const JsonHelper = {
  readFile: (file) => JSON.parse(fs.readFileSync(file, 'utf8')),
  readFolder: (folder) => fs.readdirSync(folder)
    .filter((file) => path.extname(file) === '.json')
    .map((file) => JsonHelper.readFile(path.join(folder, file)))
    .reduce((prev, data) => deepmerge(prev, data), {}),
};


module.exports = JsonHelper;
