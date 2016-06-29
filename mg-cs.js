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
var json = require('./json');
var inspector = require('./inspector');
var nunjucks = require('./nunjucks');


var folder = './json/' + program.model;
fs.access(folder, fs.F_OK, function(err) {
  if(err) {
    console.error("Folder " + folder + " doesn't exist!");
  } else {
    var data = json.read_folder(folder);
    console.log(data);
    var fields = inspector.get_fields(data);
    console.log(fields);
    var template = nunjucks.render('csharp.cs', { class: program.model, fields: fields });
    console.log(template);
  }
});
