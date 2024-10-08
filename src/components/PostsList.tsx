import React from "react";
import styled from "@emotion/styled";
import { Post } from "./";

export const PostsList = () => {
    const tempData = [
        {
            id: 'fn232423',
            user_icon: '',
            user_name: 'Andrew Kopek',
            content_text: 'Uwielbiam Koty',
            content_image: ''
        },
        {
            id: '23rc432',
            user_icon: '',
            user_name: 'Mathew XD',
            content_text: 'lorel fmwqefm ewlkfklerm wermwleqkmrflkwerkl  mrwlkemrlkw mqee klwerlkrkl;we ;kfgnrpjbgo qwe rkj ngpokerpgp wkqefkwer wer',
            content_image: ''
        },
        {
            id: 'b45h324tf',
            user_icon: '',
            user_name: 'Tomek J',
            content_text: 'Me encanta Portuguese. Yo trabajo aqui.',
            content_image: ''
        },
        {
            id: '65h5c2345gt5',
            user_icon: '',
            user_name: 'Garbus_2223',
            content_text: 'Necesito abrir mi tienda hoy',
            content_image: ''
        }
    ]
    return(
        <StyledPostsList>
            {tempData[0] && tempData.map((data) => {
                return <Post data={data}/>
            })}
            <></>
        </StyledPostsList>
    );
};

const StyledPostsList = styled.div`
    height: 100%;
    width: 50%;
    overflow-y: auto;
    overflow-x: none;
`;