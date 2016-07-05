const assert = require('assert');
const SchemaHelper = require('../helpers/schema');


describe('inspector', () => {
  describe('getType()', () => {
    it('should recognize strings', () => {
      assert.equal('string', SchemaHelper.getType('name', 'tyler'));
      assert.equal('string', SchemaHelper.getType('name', ''));
    });
    it('should recognize integers', () => {
      assert.equal('integer', SchemaHelper.getType('age', 10));
      assert.equal('integer', SchemaHelper.getType('age', 0));
      assert.equal('integer', SchemaHelper.getType('age', -1));
    });
    it('should recognize floats', () => {
      assert.equal('number', SchemaHelper.getType('age', 10.5));
      assert.equal('number', SchemaHelper.getType('age', 0.5));
      assert.equal('number', SchemaHelper.getType('age', -1.5));
    });
    it('should recognize arrays', () => {
      assert.equal('integer[]', SchemaHelper.getType('integers', [1, 2, 3]));
      assert.equal('string[]', SchemaHelper.getType('names', ['a', 'b', 'c']));
      assert.equal('number[]', SchemaHelper.getType('floats', [1.5, 3.5, 5.6]));
    });
    it('should recognize objects', () => {
      assert.equal('Student', SchemaHelper.getType('student', { name: 'peter' }));
      assert.equal('Teacher', SchemaHelper.getType('teacher', {}));
      assert.equal('Teacher[]', SchemaHelper.getType('teachers', [{}, {}]));
    });
  });

  describe('getFields()', () => {
    it('should return all the fields objects', () => {
      assert.deepEqual([{ name: 'name', type: 'string', value: 'tyler' }],
        SchemaHelper.getFields({ name: 'tyler' }));
      assert.deepEqual([{ name: 'age', type: 'integer', value: 15 },
                        { name: 'name', type: 'string', value: 'tyler' }],
        SchemaHelper.getFields({ age: 15, name: 'tyler' }));
    });
  });
});
