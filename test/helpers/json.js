const assert = require('assert');
const { readFiles, readFolder, merge } = require('../../helpers/json');


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
  ],
  "conversationId": 2147483648
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

  describe('merge()', () => {
    it('should merge two json', () => {
      const json1 = { a: '111' };
      const json2 = { b: '222' };
      const merged = { a: '111', b: '222' };
      assert.deepEqual(merged, merge(json1, json2));
    });
  });
});
