const { Project } = require("../models/project.model")

// CRUD Operations for Author Documnet

// Get All Projects: READ
module.exports.findAllProjects = (request, response) => {
    Project.find()
        .then(allProjects => response.json({Projects: allProjects}))
        .catch(err => response.json({ message: "Something went wrong", error: err}))
};

// Get a Single Project: READ
module.exports.findOneSingleProject = (request, response) => {
    Project.find({_id: request.params.id})
        .then(oneSingleProject => response.json({ Project: oneSingleProject}))
        .catch(err => response.json({ message: "Something went wrong", error: err}));
};

// Create a Project: CREATE
module.exports.createProject = (request, response) => {
    const { title, dueDate, status } = request.body;
    Project.create({
        title,
        dueDate,
        status,
    })
        .then(Project => response.json(Project))
        .catch(err => response.status(400).json(err))
};

// Update a Project: UPDATE
module.exports.updateProject = (request, response) => {
    Project.findOneAndUpdate({_id: request.params.id}, request.body, {new:true})
        .then(updatedProject => response.json(updatedProject))
        .catch(error => response.status(400).json(error))
}

// Delete a Project: DELETE
module.exports.deleteProject= (request, response) => {
    Project.deleteOne({_id: request.params.id})
        .then(deleteConfirmation => response.json(deleteConfirmation))
        .catch(error => response.json(error))
}