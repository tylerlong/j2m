const inspector = require('../inspector');
const nunjucks = require('../nunjucks');


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
  return type;
});
nunjucks.addFilter('csharp_name', (name) => {
  if (name === 'operator') {
    return `@${name}`;
  }
  return name;
});

const render = (name, json) => {
  const cls = inspector.getClass(name, json);
  let model = nunjucks.render('cs/index.cs', { cls });
  model = model.replace(/ +$/gm, ''); // trim blank lines
  model = model.trim();
  return model;
};


module.exports = { render };
