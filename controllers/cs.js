const inspector = require('../inspector');
const nunjucks = require('../nunjucks');


const CSharpController = {
  render: (name, json) => {
    const cls = inspector.get_class(name, json);
    let model = nunjucks.render('cs/index.cs', { cls });
    model = model.replace(/ +$/gm, ''); // trim blank lines
    return model;
  },
};


module.exports = CSharpController;
