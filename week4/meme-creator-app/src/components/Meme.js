import React from 'react'
import Card from '@mui/material/Card';
import CardContent from '@mui/material/CardContent';
import CardMedia from '@mui/material/CardMedia';
import Typography from '@mui/material/Typography';
import { CardActionArea } from '@mui/material';

import { useSelector } from "react-redux"



function Meme() {

    const memeProperties =  useSelector(state => state.memes.selectedMeme)
    
    return (
        <>
            <Card sx={{ maxWidth: "500px", width: "800px",  }}>
                <CardActionArea >
                    <CardMedia sx={{ maxHeight: 500, height:1000 }}
                        component="img"
                        image={ memeProperties.url }
                        alt="redux meme"
                    />
                    <CardContent>
                    <Typography gutterBottom variant="h6" component="div">
                        { memeProperties.name }
                    </Typography>

                    </CardContent>
                </CardActionArea>
            </Card>
        </>
    )
}

export default Meme