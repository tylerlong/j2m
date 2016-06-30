const nunjucks = require('nunjucks');
const StringUtil = require('./string_util');


const env = nunjucks.configure('template', {
  autoescape: false,
  trimBlocks: true,
  lstripBlocks: true,
});
env.addFilter('pascal_case', (str) => {
    return StringUtil.capitalize_first_letter(str);
});
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
