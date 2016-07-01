const pluralize = require('pluralize');


const StringHelper = {
  isInteger: (n) => n === +n && n === (n | 0),
  capitalizeHead: (string) => string.charAt(0).toUpperCase() + string.slice(1),
  singularize: (word) => pluralize(word, 1),
};


module.exports = StringHelper;
