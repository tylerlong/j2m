const fs = require('fs');
const jsonUtil = require('../helpers/json');
const inspector = require('../inspector');
const nunjucks = require('../nunjucks');


const process = (program) => {
  const folder = program.folder;
  console.log(folder);
  fs.access(folder, fs.F_OK, (err) => {
    if (err) {
      console.error(`Folder ${folder} doesn't exist!`);
    } else {
      const data = jsonUtil.read_folder(folder);
      const cls = inspector.get_class(program.model, data);
      let template = nunjucks.render('csharp/csharp.cs', { cls });
      template = template.replace(/ +$/gm, '');
      console.log(template);
    }
  });
};


module.exports = process;
