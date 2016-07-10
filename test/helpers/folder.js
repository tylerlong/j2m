const assert = require('assert');
const path = require('path');
const { exists } = require('../../helpers/folder');


describe('folderHelper', () => {
  describe('exists()', () => {
    it('should exist', () => {
      assert.equal(true, exists(path.join(__dirname, 'folder.js')));
    });
    it('should not exist', () => {
      assert.equal(false, exists(path.join(__dirname, 'sth.js')));
    });
  });
});
