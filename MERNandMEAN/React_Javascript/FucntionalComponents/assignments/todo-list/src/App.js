import React, { useState } from 'react';
import logo from './logo.svg';
import './App.css';

import AddItem from './components/AddItem'
import DisplayItem from './components/DisplayItem'

function App() {
  const[Items,setItems] = useState([
    {"msg":"Get Mern back belt","isCompleted":false,"isDeleted": false},
    {"msg":"Get C# Black belt","isCompleted":false,"isDeleted": false}]);

  const youveGotItem = ( newItem ) => {
    setItems([...Items,newItem]);
  }
  
  return (
    <div className="App">
      <AddItem onNewItem={ youveGotItem }/>
      {
      Items.map((Item,i)=>
      <DisplayItem Item = {Item}/>
      )
      
      }
    </div>
  );
}

export default App;
