import "./App.css";
import { BrowserRouter as Router, Route } from "react-router-dom";
import Navbar from "./components/layout/Navbar";
import React, { useState, useEffect } from "react";
import Axios from "axios";
import Items from "./components/Items";
import Info from "./components/Info";

const App = props => {
  const [pokemons, setPokemons] = useState([]);
  const [types, setTypes] = useState([]);
  const [actualInfo, setActualInfo] = useState({});
  const [actualUrl, setActualUrl] = useState("impossibleRoute");

  useEffect(() => {
    console.log("All fetch");
    Axios.get("https://pokeapi.co/api/v2/pokemon").then(({ data }) => {
      setPokemons(data.results);
    });

    Axios.get("https://pokeapi.co/api/v2/type").then(({ data }) => {
      setTypes(data.results);
    });
  }, []);

  useEffect(() => {
    console.log("oneFetch");
    pokemons.map(pokemon => {
      if (pokemon.name.toUpperCase() === actualUrl.toUpperCase()) {
        Axios.get(pokemon.url).then(({ data }) => setActualInfo(data));
      }
      return true;
    });
  }, [actualUrl, pokemons]);

  const pokemonInfoClick = name => {
    setActualUrl(name);
  };

  return (
    <Router>
      <div className="App">
        <div className="container">
          <Navbar />
          <Route
            exact
            path="/Pokemons"
            render={props => (
              <React.Fragment>
                <Items items={pokemons} onClick={pokemonInfoClick} />
              </React.Fragment>
            )}
          />
          <Route
            exact
            path="/Types"
            render={props => (
              <React.Fragment>
                <Items items={types} onClick={pokemonInfoClick} />
              </React.Fragment>
            )}
          />
          <Route
            exact
            path={`/${actualUrl}`}
            render={props => (
              <React.Fragment>
                <Info actual={actualInfo} />
              </React.Fragment>
            )}
          />
        </div>
      </div>
    </Router>
  );
};

export default App;
