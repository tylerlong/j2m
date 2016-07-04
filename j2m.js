#! /usr/bin/env node
/* eslint no-console: "off" */
const program = require('commander');
const JsonHelper = require('./helpers/json');


const options = new Map([
  ['lang', ['-l, --lang <lang>',
    'destination language file extension, such as: cs, js, java, php...etc.']],
  ['json', ['-j, --json <json>', 'path to json file']],
  ['folder', ['-f, --folder <folder>', 'folder which contains json files']],
  ['name', ['-n, --name <name>',
    'the generated model name, such as: user, account, film, course...etc.']],
]);
program
  .version(require('./package.json').version)
  .option.apply(program, options.get('lang'))
  .option.apply(program, options.get('json'))
  .option.apply(program, options.get('folder'))
  .option.apply(program, options.get('name'))
  .parse(process.argv);

if (program.lang === undefined) {
  console.error(`Please specify "${options.get('lang')[0]}" : ${options.get('lang')[1]}`);
  process.exit(1);
}
if (typeof program.name !== 'string') {
  console.error(`Please specify "${options.get('name')[0]}" : ${options.get('name')[1]}`);
  process.exit(1);
}
if ((program.json === undefined && program.folder === undefined)
  || (program.json !== undefined && program.folder !== undefined)) {
  console.error(`Please specify either "${options.get('json')[0]}" \
or "${options.get('folder')[0]}" but not both.`);
  process.exit(1);
}

let json = null;
try {
  json = program.json !== undefined ?
    JsonHelper.readFile(program.json) : JsonHelper.readFolder(program.folder);
} catch (e) {
  console.error(e.message);
  process.exit(1);
}

const LanguageController = require(`./controllers/${program.lang}`);
const model = LanguageController.render(program.name, json);
console.log(model);
