import { useState } from 'react'
import { Modal, Button } from "react-bootstrap";
import TodoEdit from "../Edit"
import styles from "./styles.module.css"

import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faEdit } from '@fortawesome/free-solid-svg-icons';

const TodoModal = ({ todo }) => {
    const [show, setShow] = useState(false);

    const handleClose = () => setShow(false);
    const handleShow = () => setShow(true);

    const isLate = todo.isDued
    
    return (
        <>
                <Button variant={isLate===true && todo.isCompleted === false ? "outline-dark" : "outline-success"} size="sm" className={styles.editbtn} onClick={handleShow}>
                    <FontAwesomeIcon icon={faEdit} />
                </Button>

                <Modal
                    size="lg"
                    show={show}
                    onHide={handleClose}
                    backdrop="static"
                    keyboard={false}
                >
                    <Modal.Header closeButton>
                        <Modal.Title>Edit Todo</Modal.Title>
                    </Modal.Header>
                    <Modal.Body>

                        <TodoEdit todo={todo} />
                    </Modal.Body>

                </Modal>
        </>
    )
}

export default TodoModal
