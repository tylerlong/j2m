var assert = require('assert');
var inspector = require('../inspector');


describe('inspector', function() {
  describe('#get_type()', function() {
    it('should recognize strings', function() {
      assert.equal('string', inspector.get_type('name', 'tyler'));
      assert.equal('string', inspector.get_type('name', ''));
    });
    it('should recognize integers', function() {
      assert.equal('integer', inspector.get_type('age', 10));
      assert.equal('integer', inspector.get_type('age', 0));
      assert.equal('integer', inspector.get_type('age', -1));
    });
    it('should recognize floats', function() {
      assert.equal('number', inspector.get_type('age', 10.5));
      assert.equal('number', inspector.get_type('age', 0.5));
      assert.equal('number', inspector.get_type('age', -1.5));
    });
    it('should recognize arrays', function() {
      assert.equal('integer[]', inspector.get_type('integers', [1, 2, 3]));
      assert.equal('string[]', inspector.get_type('names', ['a', 'b', 'c'] ));
      assert.equal('number[]', inspector.get_type('floats', [1.5, 3.5, 5.6]));
    });
    it('should recognize objects', function() {
      assert.equal('Student', inspector.get_type('student', { 'name': 'peter' }));
      assert.equal('Teacher', inspector.get_type('teacher', {} ));
      assert.equal('Teacher[]', inspector.get_type('teachers', [{}, {}]));
    });
  });
});
