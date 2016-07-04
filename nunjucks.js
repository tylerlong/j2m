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
env.addFilter('pascal_case', (str) => StringHelper.capitalizeHead(str));
env.addFilter('csharp_type', (type) => {
  if (type === 'integer') {
    return 'int?';
  }
  if (type === 'integer[]') {
    return 'int?[]';
  }
  if (type === 'number') {
    return 'double?';
  }
  if (type === 'number[]') {
    return 'double?[]';
  }
  return type;
});
env.addFilter('csharp_name', (name) => {
  if (name === 'operator') {
    return `@${name}`;
  }
  return name;
});


module.exports = env;
