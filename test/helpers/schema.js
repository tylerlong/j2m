const assert = require('assert');
const { getType, getFields } = require('../../helpers/schema');


describe('inspector', () => {
  describe('getType()', () => {
    it('should recognize strings', () => {
      assert.equal('string', getType('name', 'tyler'));
      assert.equal('string', getType('name', ''));
    });
    it('should recognize integers', () => {
      assert.equal('integer', getType('age', 10));
      assert.equal('integer', getType('age', 0));
      assert.equal('integer', getType('age', -1));
    });
    it('should recognize floats', () => {
      assert.equal('number', getType('age', 10.5));
      assert.equal('number', getType('age', 0.5));
      assert.equal('number', getType('age', -1.5));
    });
    it('should recognize arrays', () => {
      assert.equal('integer[]', getType('integers', [1, 2, 3]));
      assert.equal('string[]', getType('names', ['a', 'b', 'c']));
      assert.equal('number[]', getType('floats', [1.5, 3.5, 5.6]));
    });
    it('should recognize objects', () => {
      assert.equal('Student', getType('student', { name: 'peter' }));
      assert.equal('Teacher', getType('teacher', {}));
      assert.equal('Teacher[]', getType('teachers', [{}, {}]));
    });
  });

  describe('getFields()', () => {
    it('should return all the fields objects', () => {
      assert.deepEqual([{ name: 'name', type: 'string', value: 'tyler' }],
        getFields({ name: 'tyler' }));
      assert.deepEqual([{ name: 'age', type: 'integer', value: 15 },
                        { name: 'name', type: 'string', value: 'tyler' }],
        getFields({ age: 15, name: 'tyler' }));
    });
  });
});
