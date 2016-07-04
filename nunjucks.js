const path = require('path');
const fs = require('fs');
const nunjucks = require('nunjucks');
const StringHelper = require('./helpers/string');


const viewsPath = path.join(path.dirname(fs.realpathSync(__filename)), 'views');
const env = nunjucks.configure(viewsPath, {
  autoescape: false,
  trimBlocks: true,
  lstripBlocks: true,
});
env.addFilter('pascal', (str) => StringHelper.capitalizeHead(str));


module.exports = env;
