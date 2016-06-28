var pluralize = require('pluralize');


var is_integer = (n) => {
  return n === +n && n === (n|0);
}

var capitalize_first_letter = (string) => {
  return string.charAt(0).toUpperCase() + string.slice(1);
}

var singular = (word) => {
  return pluralize(word, 1);
}

var inspector = {
  get_type: (key, value) => {
    var type = ({}).toString.call(value).match(/\s([a-zA-Z]+)/)[1].toLowerCase();
    if(type === 'number' && is_integer(value)) {
      return 'integer';
    } else if(type === 'array') {
      return inspector.get_type(key, value[0]) + '[]';
    } else if(type === 'object') {
      return capitalize_first_letter(singular(key));
    } else {
      return type;
    }
  },
  get_fields: (obj) => {
    return Object.keys(obj)
      .map((key) => {
        return { key: key, type: inspector.get_type(key, obj[key]), value: obj[key]}
      });
  }
};


module.exports = inspector;
