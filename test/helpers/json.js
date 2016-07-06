const assert = require('assert');
const { readFiles, readFolder } = require('../../helpers/json');


const mergedJson = `
{
  "name": "Tyler Long",
  "scores": [
    99,
    98,
    99
  ],
  "height": 170.55,
  "age": 30,
  "performance": [
    12.34,
    56.78
  ]
}
`.trim();

describe('jsonHelper', () => {
  describe('readFiles()', () => {
    it('should read files', () => {
      const json = readFiles(['test/fixtures/json/test/1.json',
        'test/fixtures/json/test/2.json']);
      assert.equal(mergedJson, JSON.stringify(json, null, 2));
    });
  });

  describe('readFolder()', () => {
    it('should read folder', () => {
      const json = readFolder('test/fixtures/json/test/');
      assert.equal(mergedJson, JSON.stringify(json, null, 2));
    });
  });
});
