const pluralize = require('pluralize');

const string_util = {
  is_integer: (n) => {
    return n === +n && n === (n|0);
  },
  capitalize_first_letter: (string) => {
    return string.charAt(0).toUpperCase() + string.slice(1);
  },
  singular: (word) => {
    return pluralize(word, 1);
  },
};

module.exports = string_util;
