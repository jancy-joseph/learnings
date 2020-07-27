const mongoose = require('mongoose');

const PetSchema = new mongoose.Schema({
    name: {
        type: String,
        required: true,
        minlength: [3, "Your pet's name must be 3 characters or more!"]
        // unique:[true,"your pet name must be unique"]
    },
    type: {
        type: String,
        required: true,
        minlength: [3, "Your pet's type  must be 3 characters or more!"]
    },
    description: {
        type: String,
        required: true,
        minlength: [3, "Your pet's description must be 3 characters or more!"]
    },
    likes: {
        type: Number,
        default: 0
    },
    skillOne: {
        type: String,
        default:""
    },
    skillTwo: {
        type: String,
        default:""
    },
    skillThree: {
        type: String,
        default:""
    }

}, {timestamps: true});

mongoose.model("Pet", PetSchema);