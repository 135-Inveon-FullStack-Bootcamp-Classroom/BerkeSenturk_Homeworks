import React, { useState, useEffect } from 'react'

import { useDispatch } from "react-redux"


import memesSlice, { pickSelected } from "../redux/memes/memesSlice"

import { styled } from '@mui/material/styles';
import Box from '@mui/material/Box';
import ButtonBase from '@mui/material/ButtonBase';
import Typography from '@mui/material/Typography';
import ImageList from '@mui/material/ImageList';
import ImageListItem from '@mui/material/ImageListItem';

const images = [
  {
    url: 'https://images.unsplash.com/photo-1551963831-b3b1ca40c98e',
    title: 'Breakfast',
    width: '40%',
  },
  {
    url: 'https://images.unsplash.com/photo-1551782450-a2132b4ba21d',
    title: 'Burger',
    width: '40%',

  },
  {
    url: 'https://images.unsplash.com/photo-1522770179533-24471fcdba45',
    title: 'Camera',
    width: '40%',

  },
  {
    url: 'https://images.unsplash.com/photo-1444418776041-9c7e33cc5a9c',
    title: 'Coffee',
    width: '40%',

  },
  {
    url: 'https://images.unsplash.com/photo-1533827432537-70133748f5c8',
    title: 'Hats',
    width: '40%',

  },
  {
    url: 'https://images.unsplash.com/photo-1558642452-9d2a7deb7f62',
    title: 'Honey',
    width: '40%',

  },
  {
    url: 'https://images.unsplash.com/photo-1516802273409-68526ee1bdd6',
    title: 'Basketball',
    width: '40%',

  },
  {
    url: 'https://images.unsplash.com/photo-1518756131217-31eb79b20e8f',
    title: 'Fern',
    width: '40%',

  },

];

const ImageButton = styled(ButtonBase)(({ theme }) => ({
  position: 'relative',
  height: 200,
  [theme.breakpoints.down('sm')]: {
    width: '100% !important', // Overrides inline-style
    height: 100,
  },
  '&:hover, &.Mui-focusVisible': {
    zIndex: 1,
    '& .MuiImageBackdrop-root': {
      opacity: 0.15,
    },
    '& .MuiImageMarked-root': {
      opacity: 0,
    },
    '& .MuiTypography-root': {
      border: '4px solid currentColor',
    },
  },
}));

const ImageSrc = styled('span')({
  position: 'absolute',
  left: 0,
  right: 0,
  top: 0,
  bottom: 0,
  backgroundSize: 'cover',
  backgroundPosition: 'center 40%',
});

const Image = styled('span')(({ theme }) => ({
  position: 'absolute',
  left: 0,
  right: 0,
  top: 0,
  bottom: 0,
  display: 'flex',
  alignItems: 'center',
  justifyContent: 'center',
  color: theme.palette.common.white,
}));

const ImageBackdrop = styled('span')(({ theme }) => ({
  position: 'absolute',
  left: 0,
  right: 0,
  top: 0,
  bottom: 0,
  backgroundColor: theme.palette.common.black,
  opacity: 0.4,
  transition: theme.transitions.create('opacity'),
}));

const ImageMarked = styled('span')(({ theme }) => ({
  height: 3,
  width: 18,
  backgroundColor: theme.palette.common.white,
  position: 'absolute',
  bottom: -2,
  left: 'calc(50% - 9px)',
  transition: theme.transitions.create('opacity'),
}));


function MemeList() {
    const [allMemes, setAllMemes] = useState([])


    useEffect(() => {
        return fetch('https://api.imgflip.com/get_memes')
        .then((response) => response.json())
        .then(allData => setAllMemes(allData.data.memes))
    }, [])
    
    const dispatch = useDispatch()
    
    return (
        <>
          <Box sx={{ display: 'flex', flexWrap: 'wrap', minWidth: 500, maxWidth: 800, width: '80%' }}>
            <ImageList sx={{ width: 1000, height: 800 }} cols={3} rowHeight={200}>
                {allMemes.map((meme) => (
                  <ImageListItem key={meme.id}>
                    <ImageButton
                      
                      focusRipple
                      key={meme.id}
                      style={{
                        width: meme.width,
                      }}
                      // if no (e), it will loop whatever is written as a return inside onClick
                      onClick={(e) => { dispatch(pickSelected(meme)) }}
                    >
                      <ImageSrc style={{ backgroundImage: `url(${meme.url})` }} />
                      <ImageBackdrop className="MuiImageBackdrop-root" />
                      <Image>
                        <Typography
                          component="span"
                          variant="subtitle1"
                          color="inherit"
                          sx={{
                            position: 'relative',
                            p: 4,
                            pt: 2,
                            pb: (theme) => `calc(${theme.spacing(1)} + 6px)`,
                          }}
                        >
                          {meme.name}
                          <ImageMarked className="MuiImageMarked-root" />
                        </Typography>
                      </Image>
                    </ImageButton>
                  </ImageListItem>
  
                ))}
                </ImageList>
              </Box>
        </>
    )
}

export default MemeList
