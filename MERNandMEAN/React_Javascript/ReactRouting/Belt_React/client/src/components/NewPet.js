import React, {useState} from 'react'
import { Link, navigate } from '@reach/router';
import axios from 'axios';

const NewPet = (props) => {

    const {pets, setPets} = props;
    const [name, setName] = useState("");
    const [type, setType] = useState("");
    const [description, setDescription] = useState("");
    const [skillOne, setSkillOne] = useState("");
    const [skillTwo, setSkillTwo] = useState("");
    const [skillThree, setSkillThree] = useState("");

    const [errs, setErrs] = useState([]);

    const thisSubmit = (event) => {
        event.preventDefault();
    //     let valid = true;

    //     if(name.length < 2){
    //         valid = false;
    //         setErrs([...errs, "Name must be longer than one character!"])
    //     }

    //     if(valid){
    //         axiosCall();
    //     }
    // }

    // const axiosCall = () => {
        axios.post('http://localhost:8002/pets/new', {
            name: name,
            type: type,
            description: description,
            skillOne: skillOne,
            skillTwo: skillTwo,
            skillThree: skillThree
        })
        .then(res => {
            console.log(res.data);
            setPets([...pets, res.data]);
            navigate('/');
        })
        .catch(err => {
            console.log("here");
            console.log(err.response)
            // console.log(err.response.data.errors);
            const errorArray = [];
            for(const key of Object.keys(err.response.data.errors)){
                     console.log(err.response.data.errors[key].properties.message);
                    // console.log(err.response.data.errors[key].message);
                     errorArray.push(err.response.data.errors[key].properties.message);
            }

            setErrs(errorArray);
            // console.log(errorArray);
            // setErrors(err.response.data.errors);
            // // console.log(err.response.data.errors);
        })
    }

    return (
        <div className ="container">
        <Link to="/" className="offset-8">back to home!</Link>
        <p>These Pets are looking for a new home!</p>
        {errs.map((err, i) => <p key={i}>{err}</p>)}
            <form onSubmit={thisSubmit}>
                <div>
                    <p>Name:</p>
                    <input
                        type="text"
                        name="name"
                        value={name}
                        onChange={e => setName(e.target.value)}>
                    </input>
                </div>
                <div>
                    <p>type:</p>
                    <input
                        type="text"
                        name="type"
                        value={type}
                        onChange={e => setType(e.target.value)}>
                    </input>
                </div>
                <div>
                    <p>description:</p>
                    <input
                        type="text"
                        name="description"
                        value={description}
                        onChange={e => setDescription(e.target.value)}>
                    </input>
                </div>
                <div>
                <p>Skill1:</p>
                    <input
                        type="text"
                        name="skillOne"
                        value={skillOne}
                        onChange={e => setSkillOne(e.target.value)}>
                    </input>
                </div>
                <div>
                    <p>Skill2:</p>
                    <input
                        type="text"
                        name="skillTwo"
                        value={skillTwo}
                        onChange={e => setSkillTwo(e.target.value)}>
                    </input>
                </div>
                <div>
                    <p>Skill3:</p>
                    <input
                        type="text"
                        name="skillThree"
                        value={skillThree}
                        onChange={e => setSkillThree(e.target.value)}>
                    </input>
                </div>
                <button>Add a Pet</button>
            </form>
        </div>

    )
}

export default NewPet;