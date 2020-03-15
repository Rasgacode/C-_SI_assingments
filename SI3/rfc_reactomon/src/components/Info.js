import React from "react";
import InfoContainer from "../elements/ItemContainer";
import InfoBox from "../elements/InfoBox";

const Info = props => {
  const { name, order, weight, height, base_experience } = props.actual;
  return (
    <InfoContainer>
      <InfoBox>{`Name: ${name}`}</InfoBox>
      <InfoBox>{`Order: ${order}`}</InfoBox>
      <InfoBox>{`Weight: ${weight}`}</InfoBox>
      <InfoBox>{`Height: ${height}`}</InfoBox>
      <InfoBox>{`Base xp: ${base_experience}`}</InfoBox>
    </InfoContainer>
  );
};

export default Info;
