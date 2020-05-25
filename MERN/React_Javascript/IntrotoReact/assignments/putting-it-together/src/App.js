import React from 'react';
import logo from './logo.svg';
import './App.css';
import PersonCard from './components/PersonCard'


function App() {
  return (
    <div className="App">
      <PersonCard firstName={"Jancy"} lastName={"Joseph"} age={25} hairColor={"Brown"}/>
      <PersonCard firstName={"John"} lastName={"Doe"} age={27} hairColor={"Blue"}/>
      <PersonCard firstName={"Jane"} lastName={"Doe"} age={28} hairColor={"Pink"}/>
    </div>
  );
}

export default App;
