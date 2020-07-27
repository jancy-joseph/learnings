const pets = require('../controllers/pets');

module.exports = (app) => {
    app.get('/', pets.index)
        .get('/pets/:id', pets.findById)
        .post('/pets/new', pets.create)
        .delete('/pets/:id', pets.delete)
        .put('/pets/:id/edit', pets.edit);
}