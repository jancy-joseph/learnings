import React ,{useState}from 'react';
import './App.css';

import UserForm from './components/UserForm'
import BoxDisplay from './components/BoxDisplay'

function App() {
  //One Box
  // const [boxdetails, setBoxDetails] = useState({
  //   color: "",
  //   height:0,
  //   width: 0,
  // })
  //   const youveGotBox = (color,height,width ) => {
  //   setBoxDetails({color:color,height:height,width:width});
  //   console.log(boxdetails);
  // }

  //Multiple boxes
  const [Boxes, setBox] = useState([]);

  const youveGotBox = ( newBox ) => {
    setBox([...Boxes,newBox]);
  }
  return (
    <div className="App">
      {/* one  */}
      {/* <UserForm inputs ={boxdetails} setInputs={setBoxDetails} onNewBox={ youveGotBox } /> */}
      <UserForm onNewBox={ youveGotBox } />
{/* one box */}
      {/* <BoxDisplay boxdetails={ boxdetails } /> */}
      <BoxDisplay Boxes={ Boxes } />

    </div>
  );
}

export default App;
