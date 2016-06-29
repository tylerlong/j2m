let string_util = require('./string_util');


let inspector = {
  get_type: (key, value) => {
    let type = ({}).toString.call(value).match(/\s([a-zA-Z]+)/)[1].toLowerCase();
    if(type === 'number' && string_util.is_integer(value)) {
      return 'integer';
    } else if(type === 'array') {
      // todo: deepmerge all elements in array
      return inspector.get_type(key, value[0]) + '[]';
    } else if(type === 'object') {
      return string_util.capitalize_first_letter(string_util.singular(key));
    } else {
      return type;
    }
  },
  get_fields: (obj) => {
    return Object.keys(obj)
      .map((key) => {
        return { name: key, type: inspector.get_type(key, obj[key]), value: obj[key]}
      });
  }
};


module.exports = inspector;
