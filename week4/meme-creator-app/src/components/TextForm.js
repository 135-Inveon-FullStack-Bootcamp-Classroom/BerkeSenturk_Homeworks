import React, { useState } from 'react'

import Box from '@mui/material/Box';
import TextField from '@mui/material/TextField';
import Button from '@mui/material/Button';
import { useSelector, useDispatch } from "react-redux"


import memesSlice, { pickSelected } from "../redux/memes/memesSlice"


const styleInputField = {
    display: "flex",
    flexDirection: "column"
}

const styleButtons ={
    display: "flex",
    flexDirection: "column",
    marginLeft: "80px"
}

function TextForm() {
    const [text1, setText1] = useState('')
    const [text2, setText2] = useState('')

    const memeProperties =  useSelector(state => state.memes.selectedMeme)
    
    const url = `https://api.imgflip.com/caption_image?template_id=${memeProperties.id}&username=Berkeentrk&password=memecreator&text0=${text1}&text1=${text2}`;
        
    const dispatch = useDispatch()


    
    return(
        <>
            <Box sx={{
                        display: 'flex',
                        alignItems: "center",
                        flexDirection: "row",
                        '& > :not(style)': { m: 1 }}}
                >

                <div style={styleInputField}>
                    <TextField
                        style={{marginBottom:"20px"}}
                        onChange={(e) => {setText1(e.target.value)}}
                        id="demo-helper-text-misaligned"
                        label="Text-1"
                    />
                    <TextField
                        onChange={(e) => {setText2(e.target.value)}}
                        
                        id="demo-helper-text-misaligned"
                        label="Text-2"
                    />
                </div>
                <div style = {styleButtons}>

                    <Button 
                        variant="contained" 
                        color="success"
                        onClick={ () => {
                            fetch(url)
                            .then((response) => response.json())
                            .then((result) => {
                                dispatch(pickSelected({
                                                        id: memeProperties.id,
                                                        name: memeProperties.name,
                                                        url:result.data.url
                                                    }))
                                }
                            )
                        } }
                    >   
                    Show
                        
                    </Button>

                    <Button
                            style={{marginTop: "30px"}}
                            color="secondary"
                            variant="contained"
                        >
                           <a href={memeProperties.url} style={{color:"white", textDecoration:"none"}} download>Full Size</a>
                    </Button>
                </div>
                
            </Box>
           
        </>
    )
}

export default TextForm
