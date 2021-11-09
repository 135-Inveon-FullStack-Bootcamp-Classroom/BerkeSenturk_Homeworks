import { GET_ALL_MEMES, POST_MEME } from "../actions/index"

function memeReducer(state = [], action) {
    if (action.type === GET_ALL_MEMES) {
        return action.memes
    } 
    else if (action.type === POST_MEME) {
        state = [action.meme]
        return state
    }
    else {
        return state
    }
}

export default memeReducer;