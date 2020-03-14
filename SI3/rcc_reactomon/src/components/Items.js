import React, { Component } from "react";
import Item from "./Item";

export default class Items extends Component {
  render() {
    const { items, onClick } = this.props;
    return items.map(item => (
      <Item key={item.name} item={item} onClick={onClick} />
    ));
  }
}
