const assert = require('assert');
const { readFolder } = require('../../helpers/json');
const { render } = require('../../controllers/cs');


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
      const json = readFolder('test/fixtures/json/test/');
      assert.equal(csharpCode, render('user', json));
    });
  });
});
