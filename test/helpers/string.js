const assert = require('assert');
const { pluralize, singularize } = require('../../helpers/string');


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
});
