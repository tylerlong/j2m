#! /usr/bin/env node

const program = require('commander');

program
  .version(require('./package.json').version)
  .option('-l, --lang <lang>', 'programming language file extension')
  .option('-j, --json <json>', 'path to json file')
  .option('-f, --folder <folder>', 'directory which contains json files')
  .option('-m, --model <model>', 'the generated model name')
  .parse(process.argv);


require(`./controllers/${program.lang}.js`)(program);
