const pluralize = require('pluralize');


const StringUtil = {
  is_integer: (n) => n === +n && n === (n | 0),
  capitalize_first_letter: (string) => string.charAt(0).toUpperCase() + string.slice(1),
  singular: (word) => pluralize(word, 1),
};


module.exports = StringUtil;
