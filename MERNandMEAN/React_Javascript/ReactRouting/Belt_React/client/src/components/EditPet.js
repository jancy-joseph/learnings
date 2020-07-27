import React, {useState, useEffect} from 'react'
import { Link, navigate } from '@reach/router';
import axios from 'axios';

const EditPet = (props) => {
    const {getPets} = props;
    const [pet, setPet] = useState({});
    const [name, setName] = useState("");
    const [type, setType] = useState("");
    const [description, setDescription] = useState("");
    const [skillOne, setSkillOne] = useState("");
    const [skillTwo, setSkillTwo] = useState("");
    const [skillThree, setSkillThree] = useState("");
    const [errs, setErrs] = useState([]);


    useEffect(() => {
        axios.get(`http://localhost:8002/pets/${props.id}`)
            .then(res => {
                setPet(res.data);
                setName(res.data.name);
                setType(res.data.type);
                setDescription(res.data.description);
                setSkillOne(res.data.setSkillOne);
                setSkillTwo(res.data.skillTwo);
                setSkillThree(res.data.skillThree);
            })
            .catch(err => {
                console.log(err);
            })
    }, [])

    const thisSubmit = (event) => {
        event.preventDefault();

        // put{}
        axios.put(`http://localhost:8002/pets/${pet._id}/edit`, {
            name: name,
            type: type,
            description: description,
            skillOne:skillOne,
            skillTwo:skillTwo,
            skillThree:skillThree
        })
        .then(res => {
            console.log(res);
            getPets();
            navigate('/');
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
            <Link to="/" className="offset-8">Back to Home!</Link>
            <h4>Edit {name}</h4>
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

export default EditPet;