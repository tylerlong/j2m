const program = require('commander');

program
  .version(require('./package.json').version)
  .option('-m, --model <model>', 'model to be generate')
  .parse(process.argv);


const fs = require('fs');
const json = require('./json');
const inspector = require('./inspector');
const nunjucks = require('./nunjucks');


const folder = `./json/${program.model}`;
fs.access(folder, fs.F_OK, (err) => {
  if (err) {
    console.error(`Folder ${folder} doesn't exist!`);
  } else {
    const data = json.read_folder(folder);
    const cls = inspector.get_class(program.model, data);
    let template = nunjucks.render('csharp/csharp.cs', { cls });
    template = template.replace(/ +$/gm, '');
    console.log(template);
    fs.writeFileSync('output/Account.cs', template);
  }
});
