var program = require('commander');

program
  .version(require('./package.json').version)
  .option('-m, --model <model>', 'model to be generate')
  .parse(process.argv);

if(program.model === undefined) {
  console.error('options required: -m <model>');
  return;
}

console.log('generate model for: ' + program.model);


var fs = require('fs');
var path = require('path');
var deepmerge = require('deepmerge');


var folder = './json/' + program.model + '/get/';
fs.access(folder, fs.F_OK, function(err) {
  if(err) {
    console.error("Folder " + folder + " doesn't exist!");
  } else {
    var json = read_json_folder(folder);
    console.log(json);
  }
});

var read_json_folder = (folder) => {
  return fs.readdirSync(folder)
    .filter((file) =>  path.extname(file) === '.json')
    .map((file) => read_json_file(path.join(folder, file)))
    .reduce((prev, data) => deepmerge(prev, data), {});
}

var read_json_file = (file) => {
  return JSON.parse(fs.readFileSync(file, 'utf8'));
}
