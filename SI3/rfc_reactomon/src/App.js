import "./App.css";
import { BrowserRouter as Router, Route } from "react-router-dom";
import Navbar from "./components/layout/Navbar";
import React, { useState, useEffect } from "react";
import Axios from "axios";
import Items from "./components/Items";
import Info from "./components/Info";
import Sound from "./clickInfoSound.mp3";

const App = props => {
  const [pokemons, setPokemons] = useState([]);
  const [types, setTypes] = useState([]);
  const [actualInfo, setActualInfo] = useState({});
  const [actualUrl, setActualUrl] = useState("impossibleRoute");
  const [actualName, setActualName] = useState("notAPokemonName");
  const [sound] = useState(new Audio(Sound));

  useEffect(() => {
    Axios.get("https://pokeapi.co/api/v2/pokemon").then(({ data }) => {
      setPokemons(data.results);
    });

    Axios.get("https://pokeapi.co/api/v2/type").then(({ data }) => {
      setTypes(data.results);
    });
  }, []);

  useEffect(() => {
    if (actualUrl !== "impossibleRoute") {
      Axios.get(actualUrl).then(({ data }) => setActualInfo(data));
    }
  }, [actualUrl]);

  const pokemonInfoClick = name => {
    setActualName(name);
    pokemons.map(pokemon => {
      if (pokemon.name.toUpperCase() === name.toUpperCase()) {
        setActualUrl(pokemon.url);
      }
      return "pokemon";
    });
  };

  const typeInfoClick = name => {
    setActualName(name);
    types.map(type => {
      if (type.name.toUpperCase() === name.toUpperCase()) {
        setActualUrl(type.url);
      }
      return "type";
    });
  };

  const playSound = () => {
    sound.play();
  };

  return (
    <Router>
      <div className="App">
        <div className="container">
          <Navbar onClick={playSound} />
          <Route
            exact
            path="/Pokemons"
            render={props => (
              <React.Fragment>
                <Items
                  items={pokemons}
                  onClick={pokemonInfoClick}
                  mark="pokemon"
                />
              </React.Fragment>
            )}
          />
          <Route
            exact
            path="/Types"
            render={props => (
              <React.Fragment>
                <Items items={types} onClick={typeInfoClick} mark="type" />
              </React.Fragment>
            )}
          />
          <Route
            exact
            path={`/${actualName}`}
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
