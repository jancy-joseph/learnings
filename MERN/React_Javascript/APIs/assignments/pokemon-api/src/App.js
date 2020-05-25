import React,{useState,useEffect} from 'react';
import logo from './logo.svg';
import './App.css';

import FetchPokemon from './components/FetchPokemon'
function App() {

  const [people, setPeople] = useState([]);
 
  useEffect(() => {
      fetch('https://pokeapi.co/api/v2/pokemon/')
          .then(response => response.json())
          .then(response => setPeople(response.results))
  }, []);

  return (
      <div>
            <FetchPokemon people ={people} />         
      </div>
  );
}

export default App;
