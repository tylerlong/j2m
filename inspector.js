let string_util = require('./string_util');


let inspector = {
  get_type: (key, value) => {
    let type = ({}).toString.call(value).match(/\s([a-zA-Z]+)/)[1].toLowerCase();
    if(type === 'number' && string_util.is_integer(value)) {
      return 'integer';
    } else if(type === 'array') {
      return inspector.get_type(key, value[0]) + '[]';
    } else if(type === 'object') {
      return string_util.capitalize_first_letter(string_util.singular(key));
    } else {
      return type;
    }
  },
  get_fields: (obj) => { // todo: what if obj is array?
    return Object.keys(obj)
      .map((key) => {
        return { name: key, type: inspector.get_type(key, obj[key]), value: obj[key]}
      });
  },
  get_class: (name, obj) => {
    return {
      name: string_util.capitalize_first_letter(string_util.singular(name)),
      fields: inspector.get_fields(obj),
      classes: inspector.get_fields(obj).filter((field) => /[A-Z]/.test(field.type[0])).map((field) => inspector.get_class(field.type, field.value))
    }
  },
};


module.exports = inspector;
