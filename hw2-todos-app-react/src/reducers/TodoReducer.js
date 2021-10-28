/*
    --------------
    Reducer funcs
    --------------
    By defining reducer function, 
    we can define what action should algorithm do in determined condition for useReducer hook. 
*/

export const todoReducer = (state, action) => {

    switch (action.type) {

        case 'add':
            let data = action.todo.date
            let dateTodo = new Date(data)
              

            return  [...state, 
                                {
                                    id: Math.random().toString().slice(2, 15) + Math.random().toString().slice(2, 15),
                                    title: action.todo.title,
                                    category: action.todo.category,
                                    isCompleted: false,
                                    date: action.todo.date,
                                    isDued: Date.now() > dateTodo.getTime() ? true : false
                                }]

        case 'edit':
            // redefine the date
            let dataEdit = action.todo.date
            let dateTodoEdit = new Date(dataEdit)

            // update the task
            state.forEach( (todo) => {
                if (todo.id === action.todo.id) {

                    todo.title = action.todo.title 
                    todo.category = action.todo.category
                    todo.date =  action.todo.date
                    todo.isDued = Date.now() > dateTodoEdit.getTime() ? true : false
                }
            })
        
            return [...state]

        case 'remove':
            return state.filter(todo => todo.id !== action.id)
        
        case 'completed':
            state.forEach((todo) => {
                if (todo.id === action.id) {
                    todo.isCompleted = action.isCompleted
                }
            })
            // needs to be filtered for ensuring there is two seperate list items on frontend
            state.filter(todo => todo.isCompleted === false)
        
            return [...state]
        
        default:
            return state
    }
}