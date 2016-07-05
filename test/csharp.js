const assert = require('assert');
const JsonHelper = require('../helpers/json');
const CSharpController = require('../controllers/cs');


const csharpCode = `
public partial class User
{
    public string name;
    public int?[] scores;
    public double? height;
    public int? age;
    public double?[] performance;
}
`.trim();

describe('csharpController', () => {
  describe('render()', () => {
    it('should render correct C# code', () => {
      const json = JsonHelper.readFolder('test/fixtures/json/test/');
      assert.equal(csharpCode, CSharpController.render('user', json));
    });
  });
});
