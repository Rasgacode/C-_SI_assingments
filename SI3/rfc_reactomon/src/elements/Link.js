import { Link } from "react-router-dom";
import styled from "styled-components";

export default styled(Link)`
  font-size: ${props => props.linksize};
  color: ${props => props.linkcolor};
  text-decoration: none;
  font-family: Pokemon;
  -webkit-text-stroke: 1px black;
  text-shadow: 3px 3px 0 #000, -1px -1px 0 #000, 1px -1px 0 #000,
    -1px 1px 0 #000, 1px 1px 0 #000;
  &:hover {
    opacity: 0.5;
  }
`;
