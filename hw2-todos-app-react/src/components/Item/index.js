import { useContext } from "react";

import { TodosContext } from "../../contexts/TodosContext";
import TodoModal from "../Modal";

import styles from "./styles.module.css"

import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";
import { faTrash } from "@fortawesome/free-solid-svg-icons";

import { Button } from "react-bootstrap";



const TodoItem = ({ todo }) => {
    const { dispatch } = useContext(TodosContext)
    const isLate = todo.isDued


  
    if (todo.isCompleted === true) {

    return (
        <>
            <li  key={todo.id} className={styles.checkedCheckbox} >

                <input type="checkbox" checked onClick={() => dispatch({type:'completed', id: todo.id, isCompleted: !todo.isCompleted})}/>
                
                <span className= {styles.titleText}> {todo.title} </span>
                {todo.date}   
                
                <div>
                    <TodoModal todo={todo}/>
                    <Button variant="outline-success" size="sm" onClick={() => dispatch({type: 'remove', id: todo.id})}>
                        <FontAwesomeIcon icon={faTrash} />
                    </Button>
                </div>
                


            </li>
        </>
    )}
    else {
        return (
            <>
                
                <li key={todo.id} className={isLate === true ? styles.backgroundLate : styles.backgroundEarly} >
                    
                    <input type="checkbox" onClick={() => dispatch({type:'completed', id: todo.id, isCompleted: !todo.isCompleted})}/>
                    
                    {todo.title}

                    <div>{todo.date}</div>

                    <div>
                        <TodoModal todo={todo}/>

                        <Button variant={isLate===true ? "outline-dark" : "outline-success"} size="sm" onClick={() => dispatch({type: 'remove', id: todo.id})}>
                            <FontAwesomeIcon icon={faTrash} />
                        </Button>
                    </div> 
                </li>
            </>
        )
    }
}

export default TodoItem