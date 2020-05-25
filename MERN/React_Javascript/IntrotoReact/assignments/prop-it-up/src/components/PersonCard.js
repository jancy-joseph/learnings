import React, { Component } from 'react';

class PersonCard extends Component{
    findNewAge = () =>{
        this.props.age += 1;
    }
    render() {
        return(
            <div>
                <h1> {this.props.firstName},{this.props.lastName}</h1>
                <p>age : {this.props.age}</p>
                <p>hairColor : {this.props.hairColor}</p>
                <button onClick ={findNewAge()}>Button for {this.props.firstName} {this.props.LastName}</button>
            </div>
        );
    }
}

export default PersonCard;