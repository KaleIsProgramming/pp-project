import React from "react";
import { NavBar } from "./components";
import { MainPage, MessagePage, ProfilePage } from "./pages";
import styled from '@emotion/styled';

const App = () => {
  return (
    <StyledApp>
      <NavBar />
      <MainPage />
    </StyledApp>
  );
}

export default App;

const StyledApp = styled.div`
  height: 100vh;
  width: 100vw;
`;