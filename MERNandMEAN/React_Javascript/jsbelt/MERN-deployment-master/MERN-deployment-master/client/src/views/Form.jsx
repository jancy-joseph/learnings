import React, { useState } from "react"
import { Link, navigate } from "@reach/router"
import axios from "axios"

const Form = props => {

    const [title, setTitle] = useState("")
    const [dueDate, setDueDate] = useState("")
    const [errors, setErrors] = useState([])

    const submitHandler = e => {
        e.preventDefault()
        axios.post("http://localhost:8000/api/project", {
            title: title,
            dueDate: dueDate,
            status: "notStarted",
        })
            .then(response => {
                console.log("Successfully created a new project.")
                navigate("/")
            })
            .catch(err =>{
                const errorResponse = err.response.data.errors; // Get the errors from err.response.data
                const errorArr = []; // Define a temp error array to push the messages in
                for (const key of Object.keys(errorResponse)) { // Loop through all errors and get the messages
                    errorArr.push(errorResponse[key].message)
                }
                // Set Errors
                setErrors(errorArr);
            })
    }


    // FRONT END VALIDATIONS:
    // const submitHandler = e => {
    //     e.preventDefault()
    //     console.log(frontEndValidations())
    //     if (frontEndValidations()){
    //         console.log("Running create...")
    //         axios.post("http://localhost:8000/api/project", {
    //             title: title,
    //             dueDate: dueDate,
    //             status: "notStarted",
    //         })
    //             .then(response => {
    //                 console.log("Successfully created a new project.")
    //                 navigate("/")
    //             })
    //             .catch(err =>{
    //                 const errorResponse = err.response.data.errors; // Get the errors from err.response.data
    //                 const errorArr = []; // Define a temp error array to push the messages in
    //                 for (const key of Object.keys(errorResponse)) { // Loop through all errors and get the messages
    //                     errorArr.push(errorResponse[key].message)
    //                 }
    //                 // Set Errors
    //                 setErrors(errorArr);
    //             })
    //     }
    //     else {
    //         setErrors(frontEndValidations())
    //     }

    // }

    // const frontEndValidations = () => {
    //     let titleError = ""
    //     if (title === ""){titleError = "Project1 is required"}
    //     else if (title.length < 3){titleError = "Project1 must be 3 characters or longer"}
    //     let dueDateError = ""
    //     if (dueDate === ""){dueDateError = "Due date1 is required"}
    //     let output = []
    //     if (titleError){output.push(titleError)}
    //     if (dueDateError){output.push(dueDateError)}
    //     if (output.length === 0){
    //         return true
    //     }
    //     return output
    // }



    return(
        <div className="container">
            <div className="row">
                <div className="col-8 offset-2 text-right">
                    <Link to="/">Back to Dashboard</Link>
                </div>
            </div>
            <div className="row" style={{marginTop: "15px", marginBottom: "20px"}}>
                <div className="col-8 offset-2">
                    <h3>Plan a new project 
                        {
                            errors.map((err, index) => <small key={index} style={{color:"red", fontSize:"16px"}}>&nbsp;&nbsp;{err}.</small>)
                        }
                    </h3>
                </div>
            </div>

                <form onSubmit={ submitHandler}>
                    <div className="form-group row">
                        <label className="col-form-label col-2 offset-2">Project</label>
                        <div className="form-group col-6">
                            <input onChange={e=>setTitle(e.target.value)} className="form-control" type="text"/>
                        </div>
                    </div>
                    <div className="form-group row">
                        <label className="col-form-label col-2 offset-2">Due Date</label>
                        <div className="form-group col-6">
                            <input onChange={e=>setDueDate(e.target.value)} className="form-control" type="date"/>
                        </div>
                    </div>
                        <div className="col-6 offset-3 row" style={{marginTop: "50px"}}>
                            <button className="btn btn-primary btn-block">Plan Project</button>
                        </div>
                </form>

        </div>
    )
}

export default Form