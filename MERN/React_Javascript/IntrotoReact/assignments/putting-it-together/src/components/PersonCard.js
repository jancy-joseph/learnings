import React, { Component } from 'react';

class PersonCard extends Component{
    constructor(props){
        super(props);
        this.state={
            ageCount : props.age
        }
    }

    handleClick= () =>{
        this.setState({
            ageCount : this.state.ageCount +=1
        })
    }

    render() {
        const {firstName, lastName, age, hairColor} = this.props;
        
        return(  
            <div>
                <h1> {firstName},{lastName}</h1>
                <p>age : {this.state.ageCount}</p>
                <p>hairColor : {hairColor}</p>
                <button onClick={this.handleClick}> Button for {firstName} {lastName}</button>
            </div>
        );
    }
}

export default PersonCard;
