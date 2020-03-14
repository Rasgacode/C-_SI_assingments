import React from "react";

const Info = props => {
  const { name, order, weight, height, base_experience } = props.actual;
  return (
    <div className="infoContainer" style={infoContainerStyle}>
      <div className="nameBox" style={infoStyle}>
        {`Name: ${name}`}
      </div>
      <div className="orderBox" style={infoStyle}>
        {`Order: ${order}`}
      </div>
      <div className="weightnameBox" style={infoStyle}>
        {`Weight: ${weight}`}
      </div>
      <div className="heightnameBox" style={infoStyle}>
        {`Height: ${height}`}
      </div>
      <div className="experienceBox" style={infoStyle}>
        {`Base xp: ${base_experience}`}
      </div>
    </div>
  );
};

const infoContainerStyle = {
  margin: "0 auto",
  width: "600px"
};

const infoStyle = {
  fontFamily: "Pokemon",
  fontSize: "25px",
  color: "#000",
  margin: "0 auto",
  width: "300px",
  height: "40px",
  cursor: "pointer"
};

export default Info;
