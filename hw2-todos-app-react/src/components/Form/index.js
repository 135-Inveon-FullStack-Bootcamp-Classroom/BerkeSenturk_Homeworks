import { useContext, useState } from "react";
import { TodosContext } from "../../contexts/TodosContext";
import styles from "./styles.module.css"
import { Button, Form } from 'react-bootstrap';

const TodoForm = () => {
    const { dispatch } = useContext(TodosContext)

    const [task, setTask] = useState('')
    const [category, setCategory] = useState('')
    const [date, setDate] = useState('')

    const handleSubmit = (e) => {
        e.preventDefault()
        console.log();
        dispatch({type:'add', todo: {title : task, category: category, date: date}})
        
        // cleaning after addition 
        setTask('')

    }

    return (
    <>
        <Form className={ styles.todoForm } onSubmit= { handleSubmit }>
   
            <Form.Control  className={ styles.todoInput }
                    type="text" 
                    placeholder="What is the next boss?"
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

            <Button variant="primary" className={ styles.taskAddButton } onClick= { handleSubmit } >Add</Button>            
        </Form>


    </>
    )
}

export default TodoForm