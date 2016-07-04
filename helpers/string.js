const pluralize = require('pluralize');


const StringHelper = {
  isInteger: (n) => n === +n && n === (n | 0),
  singularize: (word) => pluralize(word, 1),
};


module.exports = StringHelper;
