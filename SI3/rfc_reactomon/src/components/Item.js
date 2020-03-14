import React from "react";
import { Link } from "react-router-dom";

const Item = props => {
  props.item.name =
    props.item.name.charAt(0).toUpperCase() + props.item.name.slice(1);
  const { name } = props.item;
  return (
    <div className="itemContainer" style={itemContainerStyle}>
      <div className="itemName" style={boxStyle}>
        {name}
      </div>
      <div className="itemLink" style={boxStyle}>
        <Link to={name} onClick={props.onClick.bind(this, name)}>
          Info
        </Link>
      </div>
    </div>
  );
};

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

export default Item;
