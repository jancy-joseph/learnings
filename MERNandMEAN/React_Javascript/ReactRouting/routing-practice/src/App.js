import React from 'react';
import './App.css';
import { Router } from '@reach/router';

import PageOne from './components/PageOne';
import PageTwo from './components/PageTwo';
import PageThree from './components/PageThree';
import PageFour from './components/PageFour';

function App() {
  return (
    <div className="App">
      <Router>
        <PageOne path="/home"/> 
        {/* in browser http:localhost:3000/:4 */}
         <PageTwo path="/:id"/>
         {/* for all string we dont use : even though we said :here http:localhost:3000/hello */}
         <PageThree path="/:hello"/>
         {/* http:localhost:3000/hello/blue/red */}
        <PageFour path ="/:hello/:blue/:red"/>
      </Router>
    </div>
  );
}

export default App;
