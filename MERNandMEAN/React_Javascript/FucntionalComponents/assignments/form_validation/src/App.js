import React,{ useState } from 'react';
//import logo from './logo.svg';
import './App.css';
import UserForm from './components/UserForm'

function App() {
  const [ state, setState] = useState({
    firstName: "",
    lastName: "",
    email: "",
    password: "",
    confirmpw: "",
  })
  return (
    <div className="App">
      <UserForm inputs={state} setInputs = {setState}/>
    </div>
  );
}

export default App;
