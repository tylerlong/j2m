const assert = require('assert');
const { readFolder } = require('../../helpers/json');
const { render } = require('../../controllers/cs');


const csharpCode = `
public partial class User
{
    public string name { get; set; }
    public int?[] scores { get; set; }
    public double? height { get; set; }
    public int? age { get; set; }
    public double?[] performance { get; set; }
    public long? conversationId { get; set; }
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
