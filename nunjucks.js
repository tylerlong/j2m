let nunjucks = require('nunjucks');
let string_util = require('./string_util');


env = nunjucks.configure('template', {
  autoescape: false,
  trimBlocks: true,
  lstripBlocks: true,
});
env.addFilter('pascal_case', (str) => {
    return string_util.capitalize_first_letter(str);
});


module.exports = env;
