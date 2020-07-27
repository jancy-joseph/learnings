import React , { useState, useEffect }from 'react';
import logo from './logo.svg';
import './App.css';
import {Router} from '@reach/router';
import axios from 'axios';
import Pets from './components/Pets';
import NewPet from './components/NewPet';
import EditPet from './components/EditPet';
import ShowPet from './components/ShowPet';

function App() {
  const [pets, setPets] = useState([]);
  
  useEffect(() => {
    console.log('Fetching pets at "/"')
    getPets();
  }, [])


const getPets = () => {
  axios.get('http://localhost:8002/')
  .then((res) => {
    console.log(res);
    setPets(res.data);
  })
  .catch((err) => {
    console.log(err);
  })
}


const removePets = (id) => {
  setPets(pets.filter(pet => pet._id !== id));
}

const toggleIsAdopted = (idx) => {
  const petsCopy = [...pets];

  const selectedPet = petsCopy[idx];
  selectedPet.isAdopted = !selectedPet.isAdopted;

  setPets(petsCopy);
}

const likePet = (idx) => {
  const petsCopy = [...pets];
  const selectedPet = petsCopy[idx];
  selectedPet.likes++;
  setPets(petsCopy);
}


  return (
    <div className="App">
      <h1>Pet Shelter</h1>
      <Router>
        <Pets path="/" pets={pets} removePets={removePets} toggleIsAdopted={toggleIsAdopted} likePet={likePet}></Pets>
        <NewPet path="/pets/new" setPets={setPets} pets={pets}></NewPet>
        <ShowPet path="/pets/:id" likePet={likePet} removePets={removePets} setPets={setPets} getPets={getPets}>></ShowPet>
        <EditPet path="/pets/:id/edit" getPets={getPets}></EditPet>
      </Router>
    </div>
  );
}

export default App;
