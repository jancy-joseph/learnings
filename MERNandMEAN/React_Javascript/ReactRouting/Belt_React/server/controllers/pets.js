const mongoose = require('mongoose');
const Pet = mongoose.model("Pet");
//var ValidationError = mongoose.Error.ValidationError;



module.exports = {
    index: (req, res) => {
        Pet.find()
            .then(pets => res.json(pets))
            .catch(err => res.status(400).json(err))
    },
    findById: (req, res) => {
        Pet.findOne({_id: req.params.id})
            .then(pet => res.json(pet))
            .catch(err => res.status(400).json(err))
    },
    create: (req, res) => {
        const {name, type, description, likes,skillOne, skillTwo, skillThree} = req.body;
        Pet.exists({name: req.body.name})
            .then(petExists => {
                    if (petExists) {
                        // Promise.reject() will activate the .catch() below.
                        return Promise.reject('Pet with this name already exists');
                       //throw new Error('Pet with this name already exists');
                    }
                return Pet.create(req.body);
            })
            .then(saveResult => res.json(saveResult))
            .catch(err => {
                console.log(err);
                if(typeof err ==="string"){
                    var newerror = {
                        "errors": {
                            "name": {
                                "properties": {
                                    "message": "Pet with this name already exists",
                                    "type": "minlength",
                                    "minlength": 3,
                                    "path": "name",
                                    "value": "j"
                                },
                                "kind": "minlength",
                                "path": "name",
                                "value": "j"
                            }
                        },
                        "_message": "Pet validation failed",
                        "message": "Pet validation failed: name: Pet with this name already exists"
                    }
                    res.status(400).json(newerror);
                }
                else{
                    res.status(400).json(err);
                }
                });
        // Pet.create(req.body)
        //     .then(pet => res.json(pet))
        //     .catch(err => res.status(400).json(err))
    },
    delete: (req, res) => {
        Pet.deleteOne({_id: req.params.id})
            .then(pet => res.json(pet))
            .catch(err => res.status(400).json(err))
    },
    edit: (req, res) => {
        console.log(req.params.id);
        console.log(req.body);
        Pet.updateOne({_id: req.params.id}, req.body, {runValidators: true, new: true})
            .then(pet => {
                console.log(pet);
                res.json(pet);
            })
            .catch(err =>{
                console.log(err);
                res.status(400).json(err)
            })
    }
}