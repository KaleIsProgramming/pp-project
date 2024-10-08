import React from "react"
import styled from "@emotion/styled";
import { PostsList } from "../components";

export const MainPage = () => {

    return(
        <StyledMainPage>
            <PostsList />
        </StyledMainPage>
    );
};

const StyledMainPage = styled.div`
    height: calc(95% - 80px);
    margin-top: 1.5%;
    display: flex;
    justify-content: center;
    align-items: center;
`;