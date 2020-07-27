import React,{useState} from 'react';

const UserForm = (props) => {
    //one box
 //   const{inputs, setInputs} = props;
    //Multiple box
    const[Box,setBox] = useState("");

    const createBox = (e) => {
        e.preventDefault();

    //One box code
     //   props.onNewBox(inputs.color,inputs.height,inputs.width);
        //setInputs("");
        //Multiple box code
        props.onNewBox(Box);
        setBox("");
    }

    const fromValidation = (e) => {
        setBox({
            ...Box,
            [e.target.name]: e.target.value
        });
        //console.log(e.target.name,e.target.value);
    }
    
    return(
        <form onSubmit = { createBox }>
            <div>
                <label>Color: </label>
                <input type="text" name="color" onChange = {fromValidation}/>
            </div>
            <div>
                <label>Height: </label>
                <input type="text" name="height" onChange = {fromValidation}/>
            </div>
            <div>
                <label>Width: </label>
                <input type="text" name="width" onChange = {fromValidation}/>
            </div>
            <div>
                <input type="submit" value="CreateBox"/>
            </div>
        </form>
    );
};

export default UserForm;