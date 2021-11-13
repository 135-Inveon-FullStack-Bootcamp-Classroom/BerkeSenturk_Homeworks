import { configureStore } from "@reduxjs/toolkit"
import memeReducer from "./memes/memesSlice"


export const store = configureStore({
    reducer: {
        memes: memeReducer,
    },
})