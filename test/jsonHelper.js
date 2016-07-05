const assert = require('assert');
const jsonHelper = require('../helpers/json');


describe('jsonHelper', () => {
  describe('readFiles()', () => {
    it('should read files', () => {
      const json = jsonHelper.readFiles(['test/fixtures/json/test/1.json',
        'test/fixtures/json/test/2.json']);
      assert.equal(`{
    "name": "Tyler Long",
    "age": 30
}`, JSON.stringify(json, null, 4));
    });
  });
  describe('readFolder()', () => {
    it('should read folder', () => {
      const json = jsonHelper.readFolder('test/fixtures/json/test/');
      assert.equal(`{
    "name": "Tyler Long",
    "age": 30
}`, JSON.stringify(json, null, 4));
    });
  });
});
