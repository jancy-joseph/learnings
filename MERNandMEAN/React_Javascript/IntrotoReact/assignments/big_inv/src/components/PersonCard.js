//import React, { Component, useState } from './node_modules/react';

// class PersonCard extends Component{
//     constructor(props){
//         super(props);
//         this.state={
//             ageCount : props.age
//         }
//     }

//     handleClick= () =>{
//         this.setState({
//             ageCount : this.state.ageCount +=1
//         })
//     }

//     render() {
//         const {firstName, lastName, age, hairColor} = this.props;
        
//         return(  
//             <div>
//                 <h1> {firstName},{lastName}</h1>
//                 <p>age : {this.state.ageCount}</p>
//                 <p>hairColor : {hairColor}</p>
//                 <button onClick={this.handleClick}> Button for {firstName} {lastName}</button>
//             </div>
//         );
//     }
// }

// export default PersonCard;

import React, { useState } from 'react';

const PersonCard = props => {
    const [state, setState] = useState({
        age: props.age
    });
    const handleClick = () => {
        setState({
            age: state.age + 1
        });
    }
    return(
        <div>
            <h1>{props.lastName}, {props.firstName}</h1>
            <p>Age: {state.age}</p> 
            <p>hair Color: {props.hairColor}</p>
            <button onClick={ handleClick }>Birthday button for {props.firstName} {props.lastName}</button>
        </div>
    );
} 
export default PersonCard;
