const mongoose = require("mongoose");

const ProjectSchema = new mongoose.Schema({
    title: {
        type: String,
        required: [true, "Project is required"],
        unique: true,
        minlength: [3, "Project must contain at least 3 characters"]
    },
    dueDate: {
        type: Date,
        required: [true, "Due date is required"]
    },
    status: String,
    
}, {timestamps: true});

module.exports.Project = mongoose.model("Project", ProjectSchema)