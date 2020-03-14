import React from "react";
import headerLogo from "../../headerLogo.png";
import { Link } from "react-router-dom";

const Navbar = props => {
  return (
    <header style={headerStyle}>
      <div className="imgContainer" style={imageContainerStyle}>
        <img src={headerLogo} alt="" style={imageStyle} />
      </div>
      <div className="linkContainer">
        <Link style={linkStyle} to="/Pokemons">
          Pokemons
        </Link>{" "}
        <Link style={linkStyle} to="/Types">
          Types
        </Link>
      </div>
    </header>
  );
};

const linkStyle = {
  fontSize: "32px",
  color: "red",
  textDecoration: "none",
  fontFamily: "Pokemon",
  WebkitTextStroke: "1px black",
  textShadow:
    "3px 3px 0 #000, -1px -1px 0 #000, 1px -1px 0 #000, -1px 1px 0 #000, 1px 1px 0 #000"
};

const headerStyle = {
  textAlign: "center",
  padding: "10px",
  marginBottom: "20px",
  wordSpacing: "35px",
  width: "60%",
  display: "inline-block"
};

const imageStyle = {
  height: "300px"
};

const imageContainerStyle = {
  marginTop: "-50px",
  height: "200px"
};

export default Navbar;
