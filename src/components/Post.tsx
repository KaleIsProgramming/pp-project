import React, { FC } from "react";
import styled from "@emotion/styled";

export const Post:FC<any> = ({data}) => {

    return(
        <StyledPost>
            <></>
        </StyledPost>
    );
};

const StyledPost = styled.div`
    height: 300px;
    width: 95%;  
    margin-left: 2.5%;
    margin: 16px 0px;
    background: black;
`;