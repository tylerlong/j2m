const ChangeCase = require('change-case');
const deepmerge = require('deepmerge');
const StringHelper = require('./helpers/string');


const inspector = {
  get_type: (key, value) => {
    const type = ({}).toString.call(value).match(/\s([a-zA-Z]+)/)[1].toLowerCase();
    if (type === 'number' && StringHelper.isInteger(value)) {
      return 'integer';
    } else if (type === 'array') {
      return `${inspector.get_type(key, value[0])}[]`;
    } else if (type === 'object') {
      return ChangeCase.pascalCase(StringHelper.singularize(key));
    }
    return type;
  },
  get_fields: (obj) => Object.keys(obj).map((key) => ({
    name: key,
    type: inspector.get_type(key, obj[key]),
    value: obj[key],
  })),
  get_class: (_name, _obj) => {
    let [name, obj] = [_name, _obj];
    if (name.endsWith('[]')) {
      name = name.slice(0, -2);
      obj = obj.reduce((prev, data) => deepmerge(prev, data), {});
    }
    return {
      name: ChangeCase.pascalCase(StringHelper.singularize(name)),
      fields: inspector.get_fields(obj),
      classes: inspector.get_fields(obj).filter((field) => /[A-Z]/.test(field.type[0]))
        .map((field) => inspector.get_class(field.type, field.value)),
    };
  },
};


module.exports = inspector;
