import "./App.css";
import { BrowserRouter as Router, Route } from "react-router-dom";
import Navbar from "./components/layout/Navbar";
import React, { Component } from "react";
import Axios from "axios";
import Items from "./components/Items";
import Info from "./components/Info";

export default class App extends Component {
  state = {
    pokemons: [],
    types: [],
    actualInfo: {},
    actualUrl: ""
  };

  componentDidMount() {
    Axios.get("https://pokeapi.co/api/v2/pokemon").then(res =>
      this.setState({ pokemons: res.data.results })
    );

    Axios.get("https://pokeapi.co/api/v2/type").then(res =>
      this.setState({ types: res.data.results })
    );
  }

  pokemonInfoClick = name => {
    this.setState({ actualUrl: `/${name}` });
    this.state.pokemons.map(pokemon => {
      if (pokemon.name.toUpperCase() === name.toUpperCase()) {
        Axios.get(pokemon.url).then(res =>
          this.setState({ actualInfo: res.data })
        );
      }
      return true;
    });
  };

  render() {
    console.log(this.state.actualUrl);
    console.log(this.state.actualInfo);
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
                  <Items
                    items={this.state.pokemons}
                    onClick={this.pokemonInfoClick}
                  />
                </React.Fragment>
              )}
            />
            <Route
              exact
              path="/Types"
              render={props => (
                <React.Fragment>
                  <Items
                    items={this.state.types}
                    onClick={this.pokemonInfoClick}
                  />
                </React.Fragment>
              )}
            />
            <Route
              exact
              path={this.actualUrl}
              render={props => (
                <React.Fragment>
                  <Info />
                </React.Fragment>
              )}
            />
          </div>
        </div>
      </Router>
    );
  }
}
