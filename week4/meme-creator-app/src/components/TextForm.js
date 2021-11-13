import React from 'react'
import Box from '@mui/material/Box';
import TextField from '@mui/material/TextField';
import Button from '@mui/material/Button';

function TextForm() {
    return (
        <>
            <Box sx={{
                        display: 'flex',
                        alignItems: "center",
                        flexDirection: "column",
                        '& > :not(style)': { m: 1 }}}
                >
                <TextField
                    helperText="Text-1"
                    id="demo-helper-text-misaligned"
                    label="Text-1"
                />
                <TextField
                    helperText="Text-2"
                    id="demo-helper-text-misaligned"
                    label="Text-2"
                />

                <Button variant="contained" color="success">
                        Get my meme!
                    </Button>
            </Box>
           
        </>
    )
}

export default TextForm
