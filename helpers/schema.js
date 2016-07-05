const ChangeCase = require('change-case');
const deepmerge = require('deepmerge');
const StringHelper = require('./string');


const getType = (key, value) => {
  const type = ({}).toString.call(value).match(/\s([a-zA-Z]+)/)[1].toLowerCase();
  if (type === 'number' && StringHelper.isInteger(value)) {
    return 'integer';
  } else if (type === 'array') {
    return `${getType(key, value[0])}[]`;
  } else if (type === 'object') {
    return ChangeCase.pascalCase(StringHelper.singularize(key));
  }
  return type;
};

const getFields = (obj) => Object.keys(obj).map((key) => ({
  name: key,
  type: getType(key, obj[key]),
  value: obj[key],
}));

const getClass = (_name, _obj) => {
  let [name, obj] = [_name, _obj];
  if (name.endsWith('[]')) {
    name = name.slice(0, -2);
    obj = obj.reduce((prev, data) => deepmerge(prev, data), {});
  }
  return {
    name: ChangeCase.pascalCase(StringHelper.singularize(name)),
    fields: getFields(obj),
    classes: getFields(obj).filter((field) => /[A-Z]/.test(field.type[0]))
      .map((field) => getClass(field.type, field.value)),
  };
};


module.exports = { getType, getFields, getClass };
