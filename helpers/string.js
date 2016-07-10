const plural = require('pluralize');


const isInteger = (n) => n === +n && n === (n | 0);

const singularize = (word) => plural(word, 1);

const pluralize = (word) => plural(word, 10);


module.exports = { isInteger, singularize, pluralize };
