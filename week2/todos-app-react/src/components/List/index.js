import { useContext } from "react";
import { TodosContext } from "../../contexts/TodosContext";
import TodoItem from "../Item";
import styles from "./styles.module.css"

const TodoList = () => {

    const { todos } = useContext(TodosContext)

    return todos.length ? (
        <>

            
            <div className={styles.todoList}>
                
                <div className={styles.listTitle}>  
                    <h3>Ongoing Tasks</h3>
                    <hr />
                    
                    <ul className= {styles.todoListOngoing}>
                        {todos.map(todo => {if (todo.isCompleted === false) { return <TodoItem todo={todo}/>}})}
                    </ul>
                </div>

                <div className={styles.listTitle}>
                    <h3>Completed Tasks</h3>
                    <hr />  
                    <ul className= {styles.todoListCompleted}>
                        {todos.map(todo => {if (todo.isCompleted === true) { return <TodoItem todo={todo}/>}})} 
                    </ul>
                </div>
            </div>
        </>
    ) : (
        <p style={{textAlign:"center"}}> No tasks left!</p>
    )
}

export default TodoList