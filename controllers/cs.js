const { getClass } = require('../helpers/schema');
const nunjucks = require('../views/nunjucks');


const typeMap = new Map([
  ['integer', 'int?'],
  ['integer[]', 'int?[]'],
  ['number', 'double?'],
  ['number[]', 'double?[]'],
  ['boolean', 'bool?'],
  ['boolean[]', 'bool?[]'],
]);
nunjucks.addFilter('csharp_type', (type) => {
  if (typeMap.has(type)) {
    return typeMap.get(type);
  }
  return type;
});

const keywordSet = new Set(['operator', 'default', 'in', 'enum', 'ref']);
nunjucks.addFilter('csharp_name', function f(name) {
  if (name.startsWith('$')) {
    return f(name.slice(1));
  }
  if (keywordSet.has(name)) {
    return `@${name}`;
  }
  return name;
});

const render = (name, json) => {
  const cls = getClass(name, json);
  let model = nunjucks.render('cs/index.cs', { cls });
  model = model.replace(/ +$/gm, ''); // trim blank lines
  model = model.trim();
  return model;
};


module.exports = { render };
