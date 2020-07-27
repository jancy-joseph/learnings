import React,{useState,useEffect} from 'react';
import axios from 'axios';
import './App.css';

import FetchPokemon from './components/FetchPokemon'
function App() {

  const [people, setPeople] = useState([]);
 
  useEffect(() => {
      axios.get('https://pokeapi.co/api/v2/pokemon?limit=807')
          .then(response => setPeople(response.data.results))
  }, []);

  return (
      <div>
            <FetchPokemon people ={people} />         
      </div>
  );
}

export default App;
