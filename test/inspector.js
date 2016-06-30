const assert = require('assert');
const inspector = require('../inspector');


describe('inspector', () => {
  describe('get_type()', () => {
    it('should recognize strings', () => {
      assert.equal('string', inspector.get_type('name', 'tyler'));
      assert.equal('string', inspector.get_type('name', ''));
    });
    it('should recognize integers', () => {
      assert.equal('integer', inspector.get_type('age', 10));
      assert.equal('integer', inspector.get_type('age', 0));
      assert.equal('integer', inspector.get_type('age', -1));
    });
    it('should recognize floats', () => {
      assert.equal('number', inspector.get_type('age', 10.5));
      assert.equal('number', inspector.get_type('age', 0.5));
      assert.equal('number', inspector.get_type('age', -1.5));
    });
    it('should recognize arrays', () => {
      assert.equal('integer[]', inspector.get_type('integers', [1, 2, 3]));
      assert.equal('string[]', inspector.get_type('names', ['a', 'b', 'c']));
      assert.equal('number[]', inspector.get_type('floats', [1.5, 3.5, 5.6]));
    });
    it('should recognize objects', () => {
      assert.equal('Student', inspector.get_type('student', { name: 'peter' }));
      assert.equal('Teacher', inspector.get_type('teacher', {}));
      assert.equal('Teacher[]', inspector.get_type('teachers', [{}, {}]));
    });
  });

  describe('get_fields()', () => {
    it('should return all the fields objects', () => {
      assert.deepEqual([{ name: 'name', type: 'string', value: 'tyler' }],
        inspector.get_fields({ name: 'tyler' }));
      assert.deepEqual([{ name: 'age', type: 'integer', value: 15 },
                        { name: 'name', type: 'string', value: 'tyler' }],
        inspector.get_fields({ age: 15, name: 'tyler' }));
    });
  });
});
