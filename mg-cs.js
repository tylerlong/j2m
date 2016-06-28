var program = require('commander');

program
  .version(require('./package.json').version)
  .option('-m, --model <model>', 'model to be generate')
  .parse(process.argv);

if(program.model === undefined) {
  console.log('options required: -m <model>');
  return;
}

console.log('generate model for: ' + program.model);
