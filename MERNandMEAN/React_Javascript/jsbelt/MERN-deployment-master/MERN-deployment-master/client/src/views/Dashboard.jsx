import React, { useState, useEffect } from "react"
import { navigate } from "@reach/router"
import axios from "axios"

const Dashboard = props => {


    const [allProjects, setAllProjects] = useState([])

    const [backLogged, setBackLogged] = useState([])
    const [inProgress, setInProgress] = useState([])
    const [completed, setCompleted] = useState([])

    const [flag, setFlag] = useState(false)


    useEffect( ()=> {
        axios.get("http://localhost:8000/api/projects")
            .then(response => {
                console.log("Successfully got all projects from database")
                let p = response.data.Projects
                setAllProjects(p)
                let notStarted = []
                let working = []
                let finished = []
                for (var project of p){
                    if (project.status === "inProgress"){
                        working.push(project)
                    }
                    else if (project.status === "completed"){
                        finished.push(project)
                    }
                    else {notStarted.push(project)}
                }
                setBackLogged(notStarted)
                setInProgress(working)
                setCompleted(finished)

            })
            .catch(error => console.log("There was an error: ", error))
    }, [flag])


    const clickHandler = e => navigate("/projects/new")

    const updateStatus = e => {
        if (e.target.name === "notStarted"){
            axios.put(`http://localhost:8000/api/project/${e.target.value}`, {
                status: "inProgress"
            })
                .then(response => {
                    console.log("Successfully updated project status!")
                    if (flag){setFlag(false)}
                    else{setFlag(true)}
                })
                .catch(error => console.log("There was a problem: ", error))
        }
        else if (e.target.name === "inProgress"){
            axios.put(`http://localhost:8000/api/project/${e.target.value}`, {
                status: "completed"
            })
            .then(response => {
                console.log("Successfully updated project status!")
                if (flag){setFlag(false)}
                else{setFlag(true)}
            })
            .catch(error => console.log("There was a problem: ", error))
        }
    }

    const deleteProject = e => {
        axios.delete(`http://localhost:8000/api/projects/${e.target.value}`)
            .then(response => {
                console.log("Project deleted.")
                if (flag){setFlag(false)}
                else{setFlag(true)}
            })
            .catch(error => console.log("There was an error: ", error))
    }

    const formatDate = datetimeString => {
        let date = datetimeString.slice(0,10)
        let output = date.split("-")
        return `${output[1]}/${output[2]}/${output[0]}`
    }

    // Handle Dates
    const compareDates = date => {
        let today = new Date()
        var dd = String(today.getDate()).padStart(2, '0');
        var mm = String(today.getMonth() + 1).padStart(2, '0'); //January is 0!
        var yyyy = today.getFullYear();
        let d = mm + '/' + dd + '/' + yyyy;
        return date >= d
    }

    const generateDateString = date => {
        let dDate = formatDate(date)
        if (compareDates(dDate)){
            return(
                <p>Due: {dDate}</p>
            )
        }
        else {
            return(
                <p style={{color: "red"}}>Due: {dDate}</p>

            )
        }
    }


    return(
        <div className="container">
            <div className="row">
                <div className="col-4 text-center" style={{borderTop: "2px solid black", borderLeft: "2px solid black", backgroundColor: "#9fc5f8"}}>
                    <h3>Backlog</h3>
                </div>
                <div className="col-4 text-center" style={{borderTop: "2px solid black", borderLeft: "2px solid black", backgroundColor: "#fee599"}}>
                    <h3>In Progress</h3>
                </div>
                <div className="col-4 text-center" style={{borderTop: "2px solid black", borderLeft: "2px solid black", borderRight: "2px solid black", backgroundColor: "#b6d8a8"}}>
                    <h3>Compeleted</h3>
                </div>
            </div>
            <div className="row">
                <div className="col-4" style={{height: "600px", overflow: "auto", borderTop: "2px solid black", borderLeft: "2px solid black"}}>
                    {
                        backLogged.map( (project, i) => 
                            <div key={ i } style={{border: "1px solid grey", padding: "10px", margin: "10px auto"}}>
                                <h4>{project.title}</h4>
                                {generateDateString(project.dueDate)}
                                <button onClick={updateStatus} className="btn btn-block btn-warning" value={project._id} name="notStarted">Start Project</button>
                            </div>
                        )
                    }
                </div>
                <div className="col-4" style={{height: "600px", overflow: "auto", borderTop: "2px solid black", borderLeft: "2px solid black"}}>
                    {
                        inProgress.map( (project, i) => 
                            <div key={ i } style={{border: "1px solid grey", padding: "10px", margin: "10px auto"}}>
                                <h4>{project.title}</h4>
                                {generateDateString(project.dueDate)}
                                <button onClick={updateStatus} className="btn btn-block btn-success" value={project._id} name="inProgress">Move to Completed</button>
                            </div>
                        )
                    }
                </div>
                <div className="col-4" style={{height: "600px", overflow: "auto", borderTop: "2px solid black", borderLeft: "2px solid black", borderRight: "2px solid black"}}>
                    {
                        completed.map( (project, i) => 
                            <div key={ i } style={{border: "1px solid grey", padding: "10px", margin: "10px auto"}}>
                                <h4>{project.title}</h4>
                                {generateDateString(project.dueDate)}
                                <button onClick={deleteProject} className="btn btn-block btn-danger" value={project._id} name="completed">Remove Project</button>
                            </div>
                        )
                    }
                </div>
            </div>

            <div className="row">
                <div className="col-12" style={{border: "2px solid black", height: "70px",}}>
                    <button onClick={ clickHandler } className="btn btn-primary btn-md" style={{marginTop: "12px"}}>Add New Project</button>
                </div>
            </div>
        </div>
    )
}

export default Dashboard