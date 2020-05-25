import React, { useState }from 'react';

const FetchPokemon =(props) =>{
    const{people} = props;
    const[isclickedflag,setISClickedFlag] = useState(false);

    const onClickHandler =(e) =>{
        setISClickedFlag(true); 
    }
    return(
    
    <div>
        <div><button onClick={onClickHandler}>fetch pokemon</button></div>
        <div>{isclickedflag ? <div><ul>{ people.length > 0 && people.map((person, index)=>{return (<li><div key={index}>{person.name}</div></li>);})}</ul></div> : null};</div>
    </div>);
}

export default FetchPokemon;