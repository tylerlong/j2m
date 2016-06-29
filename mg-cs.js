let program = require('commander');

program
  .version(require('./package.json').version)
  .option('-m, --model <model>', 'model to be generate')
  .parse(process.argv);

if(program.model === undefined) {
  console.error('options required: -m <model>');
  return;
}

console.log('generate model for: ' + program.model);


let fs = require('fs');
let json = require('./json');
let inspector = require('./inspector');
let nunjucks = require('./nunjucks');


let folder = './json/' + program.model;
fs.access(folder, fs.F_OK, (err) => {
  if(err) {
    console.error("Folder " + folder + " doesn't exist!");
  } else {
    let data = json.read_folder(folder);
    let fields = inspector.get_fields(data);
    let template = nunjucks.render('csharp.cs', { class: program.model, fields: fields });
    console.log(template);
  }
});
