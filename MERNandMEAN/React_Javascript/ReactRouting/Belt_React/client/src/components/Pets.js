import React from 'react';
import { Link } from '@reach/router';
import axios from 'axios';


const Pets = ({pets, removePets, toggleIsAdopted, likePet}) => {

    // const deleteHandler = (id) => {
    //     axios.delete(`http://localhost:8002/api/pets/${id}`)
    //         .then(res => {
    //             console.log(res);
    //             removePets(id);
    //         })
    //         .catch(err => {
    //             console.log(err);
    //         })
    // }

    // const adoptHandler = (status, id, idx) => {
    //     axios.put(`http://localhost:8002/api/pets/${id}`, {"isAdopted": !status})
    //         .then(res => {
    //             console.log(res);
    //             toggleIsAdopted(idx);
    //         })
    //         .catch(err => {
    //             console.log(err);
    //         })
    // }

    // const likeHandler = (likeCount, id, idx) => {
    //     axios.put(`http://localhost:8002/api/pets/${id}`, {"likes": likeCount+1})
    //         .then(res => {
    //             console.log(res);
    //             likePet(idx);
    //         })
    //         .catch(err => {
    //             console.log(err);
    //         })
    // }

// vue.js, angular

    return (
        <div className ="container">
            <Link to="/pets/new" className="offset-8">Add a pet to the shelter!</Link>
            <p>These Pets are looking for a new home!</p>
            <div className="row pt-3">
                <table className="table table-bordered table-dark">
                    <thead>
                        <tr>
                            <th scope="col">Name</th>
                            <th scope="col">Type</th>
                            <th scope="col">Actions</th>
                        </tr>
                    </thead>
                    <tbody>
                    {
                        pets.map((pet, i) => {
                        
                       return( 
                       
                       <tr key={i}>

                            <td>{pet.name}</td>
                            <td>{pet.type}</td>
                            <td><Link to ={`/pets/${pet._id}`}>details</Link> | <Link to ={"/pets/"+pet._id+"/edit"}>edit</Link></td>

                        </tr>)
                        
                        })
                    }
                    </tbody>
                </table>
            </div>

        </div>

    )
}

export default Pets;