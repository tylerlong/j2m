const { getClass } = require('../helpers/schema');
const nunjucks = require('../views/nunjucks');
const { camelCase } = require('change-case');


nunjucks.addFilter('csharp_type', (type) => {
  if (type === 'integer') {
    return 'int?';
  }
  if (type === 'integer[]') {
    return 'int?[]';
  }
  if (type === 'number') {
    return 'double?';
  }
  if (type === 'number[]') {
    return 'double?[]';
  }
  if (type === 'boolean') {
    return 'bool';
  }
  return type;
});
nunjucks.addFilter('csharp_name', (name) => {
  if (['operator', 'default', 'in', 'enum'].indexOf(name) > -1) {
    return `@${name}`;
  }
  if (name.startsWith('$')) {
    return `@${name.slice(1)}`;
  }
  return camelCase(name);
});

const render = (name, json) => {
  const cls = getClass(name, json);
  let model = nunjucks.render('cs/index.cs', { cls });
  model = model.replace(/ +$/gm, ''); // trim blank lines
  model = model.trim();
  return model;
};


module.exports = { render };
