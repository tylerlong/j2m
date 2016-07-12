const { pascalCase } = require('change-case');
const deepmerge = require('deepmerge');
const { isInteger, singularize } = require('./string');


const getType = (key, value) => {
  const type = ({}).toString.call(value).match(/\s([a-zA-Z]+)/)[1].toLowerCase();
  if (type === 'number' && isInteger(value)) {
    return 'integer';
  } else if (type === 'array') {
    return `${getType(singularize(key), value[0])}[]`;
  } else if (type === 'object') {
    return pascalCase(key);
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
  const fields = getFields(obj).map((field) => {
    let type = field.type;
    if (type === name) {
      type = `_${type}`;
    }
    return { name: field.name, type, value: field.value };
  });
  return {
    name,
    fields,
    classes: fields.filter((field) => /[A-Z_]/.test(field.type[0]))
      .map((field) => getClass(field.type, field.value)),
  };
};


module.exports = { getType, getFields, getClass };
