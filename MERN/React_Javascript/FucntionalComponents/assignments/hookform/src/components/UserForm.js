import React, { useState } from  'react';
    
    
const UserForm = (props) => {
    const [firstName, setFirstName] = useState("");
    const [lastName, setLastName] = useState("");
    const [email, setEmail] = useState("");
    const [password, setPassword] = useState("");  
    const [confirmpw, setconfirmPassword] = useState("");
    const [NEWUSER,SETNEWUSER] =useState({})  

    
    const createUser = (e) => {
        e.preventDefault();
        const newUser = { firstName,lastName, email, password,confirmpw };
        console.log("Welcome", newUser);
        SETNEWUSER(newUser);
        setFirstName("");
        setLastName("");
        setEmail("");
        setPassword("");
        setconfirmPassword("");
    };
    
    return(
        <div>
        <form onSubmit={ createUser }>
            <div>
                <label>firstName: </label> 
                <input type="text" onChange={ (e) => setFirstName(e.target.value) } />
            </div>
            <div>
                <label>lastName: </label> 
                <input type="text" onChange={ (e) => setLastName(e.target.value) } />
            </div>
            <div>
                <label>Email Address: </label> 
                <input type="text" onChange={ (e) => setEmail(e.target.value) } />
            </div>
            <div>
                <label>Password: </label>
                <input type="password" onChange={ (e) => setPassword(e.target.value) } />
            </div>
            <div>
                <label>ConfirmPassword: </label>
                <input type="password" onChange={ (e) => setconfirmPassword(e.target.value) } />
            </div>
            <input type="submit" value="Create User" />
        </form>
        <div>
                <h3>Your form data</h3>
                <p>First Name : {NEWUSER.firstName}</p>
                <p>Last Name : {NEWUSER.lastName}</p>
                <p>Email : {NEWUSER.email}</p>
                <p>Password : {NEWUSER.password}</p>
                <p>ConfirmPassword : {NEWUSER.confirmpw}</p>
        </div>
        </div>
    );
};
    
export default UserForm;