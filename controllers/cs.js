const fs = require('fs');
const JsonHelper = require('../helpers/json');
const inspector = require('../inspector');
const nunjucks = require('../nunjucks');


const process = (program) => {
  const folder = program.folder;
  fs.access(folder, fs.F_OK, (err) => {
    if (err) {
      console.error(`Folder ${folder} doesn't exist!`);
    } else {
      const data = JsonHelper.readFolder(folder);
      const cls = inspector.get_class(program.model, data);
      let template = nunjucks.render('csharp/csharp.cs', { cls });
      template = template.replace(/ +$/gm, ''); // trim blank lines
      console.log(template);
    }
  });
};


module.exports = process;
