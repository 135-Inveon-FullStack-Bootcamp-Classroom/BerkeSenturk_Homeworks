import { createSlice } from "@reduxjs/toolkit"

export const memesSlice = createSlice({
    name: "memes",
    initialState:{
        selectedMeme: {
                            id:"181913649", 
                            name:"Drake Hotline Bling", 
                            url:"https://i.imgflip.com/30b1gx.jpg"
                    },
        generatedMeme: {}
    },
    reducers: {
        pickSelected: (state, action) => {
            state.selectedMeme = action.payload
        },
        generatedMeme: (state, action) => {
            state.generatedMeme = action.payload
        }

    }
})

export const { pickSelected, generatedMeme } = memesSlice.actions

export default memesSlice.reducer