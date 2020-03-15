import React from "react";
import headerLogo from "../../headerLogo.png";
import StyledLink from "../../elements/Link";
import StyledHeader from "../../elements/Header";
import StyledImg from "../../elements/Image";
import StyledImgContainer from "../../elements/NavImgContainer";

const Navbar = props => {
  return (
    <StyledHeader>
      <StyledImgContainer>
        <StyledImg src={headerLogo} alt="" />
      </StyledImgContainer>
      <div className="linkContainer">
        <StyledLink
          linkcolor="red"
          linksize="32px"
          to="/Pokemons"
          onClick={props.onClick}
        >
          Pokemons
        </StyledLink>{" "}
        <StyledLink linkcolor="red" linksize="32px" to="/Types">
          Types
        </StyledLink>
      </div>
    </StyledHeader>
  );
};

export default Navbar;
