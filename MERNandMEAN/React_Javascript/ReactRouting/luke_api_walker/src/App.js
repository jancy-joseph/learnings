import React ,{useState}from 'react';
import logo from './logo.svg';
import './App.css';
import DisplayCategory from './components/DisplayCategory';
import ShowDisplay from './components/ShowDisplay';

import { Router } from '@reach/router';

function App() {
 // const[categoryObj,setCategoryobj] = useState({"category":"","id":undefined})
  return (
    <div className="App">
     {/* </div> <DisplayCategory categoryObj={categoryObj} setCategoryobj={setCategoryobj}/> */}
     <DisplayCategory/>
      <Router>
        {/* let mypath ="/:"+{categoryObj.category}+"/:"+{categoryObj.id} */}
        <ShowDisplay path="/:category/:id"/>
      </Router>
    </div>
  );
}

export default App;
