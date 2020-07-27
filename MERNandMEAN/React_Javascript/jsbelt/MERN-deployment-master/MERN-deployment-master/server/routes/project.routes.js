const ProjectController = require("../controllers/project.controller");

module.exports = function(app){
    app.get("/api/projects", ProjectController.findAllProjects);
    app.post("/api/project", ProjectController.createProject);
    app.get("/api/project/:id", ProjectController.findOneSingleProject);
    app.put("/api/project/:id", ProjectController.updateProject);
    app.delete("/api/projects/:id", ProjectController.deleteProject);
}