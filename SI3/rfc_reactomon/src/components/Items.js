import React from "react";
import Item from "./Item";

const Items = props => {
  const { items, onClick } = props;
  return items.map(item => (
    <Item key={item.name} item={item} onClick={onClick} />
  ));
};

export default Items;
