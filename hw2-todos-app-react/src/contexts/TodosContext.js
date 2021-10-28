import { createContext, useEffect, useReducer } from "react";
import { todoReducer } from "../reducers/TodoReducer";

export const TodosContext = createContext()

const TodosContextProvider = (props) => {
    //  const [state, dispatch] = useReducer(reducer, initialArg, init);

    const [todos, dispatch] = useReducer( todoReducer, [], () => {
        const localStorageData = localStorage.getItem('todos')
        return localStorageData ? JSON.parse(localStorageData) : []
    })

    // we do use useEffect to update the localstorage in mount and each update
    // earlier for this job componentDidMount and componentDidUpdate were used with the almost same callback
    // resource: https://en.reactjs.org/docs/hooks-effect.html#example-using-classes
    useEffect(() => {
        localStorage.setItem('todos', JSON.stringify(todos))
    }, [todos])

    return <TodosContext.Provider value={{todos, dispatch}}> {props.children} </TodosContext.Provider>
}

export default TodosContextProvider