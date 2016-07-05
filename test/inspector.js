const assert = require('assert');
const inspector = require('../inspector');


describe('inspector', () => {
  describe('getType()', () => {
    it('should recognize strings', () => {
      assert.equal('string', inspector.getType('name', 'tyler'));
      assert.equal('string', inspector.getType('name', ''));
    });
    it('should recognize integers', () => {
      assert.equal('integer', inspector.getType('age', 10));
      assert.equal('integer', inspector.getType('age', 0));
      assert.equal('integer', inspector.getType('age', -1));
    });
    it('should recognize floats', () => {
      assert.equal('number', inspector.getType('age', 10.5));
      assert.equal('number', inspector.getType('age', 0.5));
      assert.equal('number', inspector.getType('age', -1.5));
    });
    it('should recognize arrays', () => {
      assert.equal('integer[]', inspector.getType('integers', [1, 2, 3]));
      assert.equal('string[]', inspector.getType('names', ['a', 'b', 'c']));
      assert.equal('number[]', inspector.getType('floats', [1.5, 3.5, 5.6]));
    });
    it('should recognize objects', () => {
      assert.equal('Student', inspector.getType('student', { name: 'peter' }));
      assert.equal('Teacher', inspector.getType('teacher', {}));
      assert.equal('Teacher[]', inspector.getType('teachers', [{}, {}]));
    });
  });

  describe('getFields()', () => {
    it('should return all the fields objects', () => {
      assert.deepEqual([{ name: 'name', type: 'string', value: 'tyler' }],
        inspector.getFields({ name: 'tyler' }));
      assert.deepEqual([{ name: 'age', type: 'integer', value: 15 },
                        { name: 'name', type: 'string', value: 'tyler' }],
        inspector.getFields({ age: 15, name: 'tyler' }));
    });
  });
});
