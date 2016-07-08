const nunjucks = require('nunjucks');
const { pascalCase } = require('change-case');


const env = nunjucks.configure(__dirname, {
  autoescape: false,
  trimBlocks: true,
  lstripBlocks: true,
});
env.addFilter('pascal', (str) => pascalCase(str));


module.exports = env;
