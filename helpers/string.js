const plural = require('pluralize');


const isInteger = (n) => n % 1 === 0;
const isLong = (n) => isInteger(n) && n > 2147483647;

const singularize = (word) => plural(word, 1);

const pluralize = (word) => plural(word, 10);


module.exports = { isInteger, isLong, singularize, pluralize };
