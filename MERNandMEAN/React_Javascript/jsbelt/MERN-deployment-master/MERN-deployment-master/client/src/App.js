import React, { useState } from 'react';
import "./bootstrap.css"
import { Router } from "@reach/router"

import Header from "./components/Header"
import Dashboard from "./views/Dashboard"
import Form from "./views/Form"

function App() {
  return (
    <div className="App container">
        <Header />
        <Router>
          <Dashboard path="/"/>
          <Form path="/projects/new" />
        </Router>

    </div>
  );
}

export default App;
