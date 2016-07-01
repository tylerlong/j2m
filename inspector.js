const stringHelper = require('./helpers/string');


const inspector = {
  get_type: (key, value) => {
    const type = ({}).toString.call(value).match(/\s([a-zA-Z]+)/)[1].toLowerCase();
    if (type === 'number' && stringHelper.is_integer(value)) {
      return 'integer';
    } else if (type === 'array') {
      return `${inspector.get_type(key, value[0])}[]`;
    } else if (type === 'object') {
      return stringHelper.capitalize_first_letter(stringHelper.singularize(key));
    }
    return type;
  },
  // todo: what if obj is array?
  get_fields: (obj) => Object.keys(obj).map((key) => ({
    name: key,
    type: inspector.get_type(key, obj[key]),
    value: obj[key],
  })),
  get_class: (name, obj) => ({
    name: stringHelper.capitalize_first_letter(stringHelper.singularize(name)),
    fields: inspector.get_fields(obj),
    classes: inspector.get_fields(obj).filter((field) => /[A-Z]/.test(field.type[0]))
      .map((field) => inspector.get_class(field.type, field.value)),
  }),
};


module.exports = inspector;
