const assert = require('assert');
const { isInteger, isLong, pluralize, singularize } = require('../../helpers/string');


describe('stringHelper', () => {
  describe('pluralize()', () => {
    it('should pluralize', () => {
      assert.equal('tokens', pluralize('token'));
    });
  });
  describe('singularize()', () => {
    it('should singularize', () => {
      assert.equal('token', singularize('tokens'));
    });
  });
  describe('number types', () => {
    it('should identify double', () => {
      assert.equal(false, isInteger(2.5));
    });
    it('should identify integer', () => {
      assert.equal(true, isInteger(25));
    });
    it('should identify long', () => {
      assert.equal(false, isLong(25));
      assert.equal(true, isLong(2147483648));
    });
  });
});
