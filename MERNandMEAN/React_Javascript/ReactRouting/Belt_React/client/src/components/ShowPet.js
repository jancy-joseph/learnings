import React, { useEffect, useState } from 'react';
import {Link,navigate} from '@reach/router';
import axios from 'axios';

const ShowPet = (props) => {
    const {getPets} = props;
    const [errs, setErrs] = useState([]);

    const [thisOnePet, setThisOnePet] = useState({
        type:"",
        description: "",
        name: "",
    })

    useEffect(() => {
        axios.get(`http://localhost:8002/pets/${props.id}`)
            .then(res => {
                console.log(res);
                setThisOnePet(res.data);
            })
            .catch(err => {
                console.log(err);
            })
    }, [])

    const deleteHandler = (id) => {
            axios.delete("http://localhost:8002/pets/"+id)
                .then(res => {
                    console.log(res);
                    props.removePets(id);
                    navigate('/');
                })
                .catch(err => {
                    console.log(err);
                })
        }
    const likeHandler =(e,id) =>{

        e.preventDefault();
        // put{}
        axios.put(`http://localhost:8002/pets/${id}/edit`, {
        likes:(thisOnePet.likes+1),
        })
        .then(res => {
            console.log(res);
            //props.likePet(id);
            getPets();
            // navigate('/');
        })
        .catch(err => {
            console.log(err);
            const errorArray = [];
            for(const key of Object.keys(err.response.data.errors)){
                errorArray.push(err.response.data.errors[key].properties.message)
            }
            setErrs(errorArray);
        })
        
    }

    return (
        <div className="container">
            <Link to="/" className="offset-8">backhome!</Link>
            <div className="row">
                <div className="col">
                    Details about: {thisOnePet.name}
                </div>
                <div className="col">
                    <button
                     onClick={(event) => {
                        deleteHandler(thisOnePet._id);
                     }}>Adopt {thisOnePet.name} </button>
                </div>
            </div>
            <p>pet Type: {thisOnePet.type}</p>
            <p>description: {thisOnePet.description}</p>
            <p>skills: {thisOnePet.skillOne} {thisOnePet.skillTwo} {thisOnePet.skillThree}</p>
            <button
                     onClick={(e) => {
                        likeHandler(e,thisOnePet._id);
                     }}>Like {thisOnePet.name} </button>
            <p>likes: {thisOnePet.likes}</p>
            {/* <p><Link to={"/dog/edit/"+thisOneDog._id}>Edit</Link></p> */}
        </div>
    )
}

export default ShowPet;