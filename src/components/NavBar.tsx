import React from "react";
import styled from "@emotion/styled";
// const icon = require('./images/icon.svg');

export const NavBar = () => {

    return(
        <StyledNavBar>
            <IconContainer>
                {/* <img src={icon} alt="Icon" /> */}
            </IconContainer>
            <GapFillerUno />
            <InputContainer>
                <input type="text" placeholder="Search..."/>
            </InputContainer>
            <GapFillerDos />
            <UserContainer>
                <UserIcon>
                    {/* img */}
                </UserIcon>
                <UserName>
                    <p></p>
                </UserName>
            </UserContainer>
        </StyledNavBar>
    );
};

const StyledNavBar = styled.div`
    height: 80px;
    width: 100%;
    background: #262656;
    display: flex;
`;

const IconContainer = styled.div`
    height: 100%;
    width: 15%;
    min-width: 160px;
    display: flex;
    align-items: center;
    justify-content: center;
    border-right: 1px solid black;

    img {
        height: 72px;
        width: 72px;
    }
`;

const InputContainer = styled.div`
    height: 100%;
    width: 50%;
    display: flex;
    align-items: center;
    justify-content: center;
    border-left: 1px solid black;
    border-right: 1px solid black;

    input[type="text"] {
        border: none;
        border-radius: 20px;
        height: 28px;
        width: 240px;
        padding: 8px;
    }
`;

const UserContainer = styled.div`
    height: 100%;
    width: 20%;
    border-left: 1px solid black;
`;

const UserIcon = styled.div`
    height: 100%;
    width: 30%;
    display: flex;
    align-items: center;
    justify-content: center;

    img {
        height: 72px;
        width: 72px;
    }
`;

const UserName = styled.div`
    height: 100%;
    width: 70%;
    display: flex;
    align-items: center;
    justify-content: center;
`;

const GapFillerUno = styled.div`
    width: 10%;
    height: 100%;
`;

const GapFillerDos = styled.div`
    width: 5%;
    height: 100%;
`;