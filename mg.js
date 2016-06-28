#! /usr/bin/env node

var program = require('commander');

program
  .version(require('./package.json').version)
  .command('cs', 'generate C# model')
  .parse(process.argv);
