import React, { Component } from "react";
import { Link } from "react-router-dom";

export default class Item extends Component {
  render() {
    this.props.item.name =
      this.props.item.name.charAt(0).toUpperCase() +
      this.props.item.name.slice(1);
    const { name } = this.props.item;
    return (
      <div className="itemContainer" style={itemContainerStyle}>
        <div className="itemName" style={boxStyle}>
          {name}
        </div>
        <div className="itemLink" style={boxStyle}>
          <Link to={name} onClick={this.props.onClick.bind(this, name)}>
            Info
          </Link>
        </div>
      </div>
    );
  }
}

const itemContainerStyle = {
  margin: "0 auto",
  lineHeight: "40px",
  width: "600px"
};

const boxStyle = {
  fontFamily: "Pokemon",
  fontSize: "25px",
  display: "inline-block",
  color: "#000",
  margin: "5px 25px 5px 25px",
  width: "100px",
  height: "40px",
  cursor: "pointer"
};
