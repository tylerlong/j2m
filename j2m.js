#! /usr/bin/env node

const program = require('commander');

program
  .version(require('./package.json').version)
  .option('-l, --lang <lang>', 'programming language file extension')
  .option('-j, --json <json>', 'path to json file')
  .option('-f, --folder <folder>', 'directory which contains json files')
  .option('-m, --model <model>', 'the generated model name')
  .parse(process.argv);


const fs = require('fs');
const jsonUtil = require('./jsonUtil');
const inspector = require('./inspector');
const nunjucks = require('./nunjucks');


const folder = program.folder;
console.log(folder);
fs.access(folder, fs.F_OK, (err) => {
  if (err) {
    console.error(`Folder ${folder} doesn't exist!`);
  } else {
    const data = jsonUtil.read_folder(folder);
    const cls = inspector.get_class(program.model, data);
    let template = nunjucks.render('csharp/csharp.cs', { cls });
    template = template.replace(/ +$/gm, '');
    console.log(template);
  }
});
