import React from "react";
import ItemBox from "../elements/ItemBox";
import ItemContainer from "../elements/ItemContainer";
import StyledLink from "../elements/Link";

const Item = props => {
  props.item.name =
    props.item.name.charAt(0).toUpperCase() + props.item.name.slice(1);
  const { name } = props.item;
  const mark = props.mark;

  return (
    <ItemContainer>
      <ItemBox>{name}</ItemBox>
      <ItemBox>
        <StyledLink
          linkcolor="white"
          linksize="25px"
          to={name}
          onClick={props.onClick.bind(this, name)}
        >
          Info
        </StyledLink>
      </ItemBox>
    </ItemContainer>
  );
};

export default Item;
