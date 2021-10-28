import { useState, useContext } from 'react'
import { Form, Button } from 'react-bootstrap'
import { TodosContext } from "../../contexts/TodosContext";
import styles from "./styles.module.css"

const TodoEdit = ({ todo })  => {
    const [task, setTask] = useState('')
    const [category, setCategory] = useState('')
    const [date, setDate] = useState('')

    const { dispatch } = useContext(TodosContext)

    const handleEditSubmit = (e) => {
        e.preventDefault()
        
        dispatch({type:'edit', todo: {id: todo.id, title : task, category: category, date: date}})
        
        // cleaning after addition 
        setTask('')

    }
    return (
        <>
            <Form className={ styles.todoForm } onSubmit= { handleEditSubmit }>
   
                <Form.Control  className={ styles.todoInput }
                        type="text" 
                        placeholder="New task name will be..."
                        onChange={(e) => { setTask(e.target.value) }}
                        value = { task.title }
                        required   
                />

                <Form.Select onChange={(e) => { setCategory(e.target.value) }} >
                    <option>Select a category</option>
                    <option value="Sport">Sport</option>
                    <option value="Business">Business</option>
                    <option value="Hobbies">Hobbies</option>
                </Form.Select>

                <Form.Control type="date" className={ styles.todoDate } onChange= {(e) => { setDate(e.target.value) }} />

                <Button variant="primary" className={ styles.taskAddButton } onClick= { handleEditSubmit } >Add</Button>            
            </Form>
        </>
    )
}

export default TodoEdit
