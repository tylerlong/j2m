const pluralize = require('pluralize');


const isInteger = (n) => n === +n && n === (n | 0);

const singularize = (word) => pluralize(word, 1);


module.exports = { isInteger, singularize };
