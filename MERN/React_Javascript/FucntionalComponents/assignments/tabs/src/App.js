import React,{useState} from 'react';
import logo from './logo.svg';
import './App.css';

import TabDisplay from './components/TabDisplay'

function App() {
  const[Tabs,setTabs]= useState([
    {name: "Tab1",content:"Tab1 content"},{name:"Tab2",content:"Tab2 content"},{name:"Tab3",content:"Tab3 content"}
  ]);


  return (
    <div className="App">
        <TabDisplay Tabs={Tabs} setTabs={setTabs}/>
    </div>
  );
}

export default App;
