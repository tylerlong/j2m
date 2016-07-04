const path = require('path');
const fs = require('fs');
const nunjucks = require('nunjucks');
const ChangeCase = require('change-case');


const viewsPath = path.join(path.dirname(fs.realpathSync(__filename)), 'views');
const env = nunjucks.configure(viewsPath, {
  autoescape: false,
  trimBlocks: true,
  lstripBlocks: true,
});
env.addFilter('pascal', (str) => ChangeCase.pascalCase(str));


module.exports = env;
