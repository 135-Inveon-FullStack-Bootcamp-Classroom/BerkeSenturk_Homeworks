import { username, password } from "./secrets"


// types of actions
export const GET_ALL_MEMES = "GET_ALL_MEMES"
export const POST_MEME = "POST_MEME"

function getAllMemes(json) {
    const { memes } = json.data

    return {
        type: GET_ALL_MEMES,
        payload: memes
    }
}

function fetchMemeJson() {
    return fetch('https://api.imgflip.com/get_memes')
                .then((response) => response.json())
}