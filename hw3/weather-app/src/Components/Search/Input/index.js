import React from 'react'
import { Form, Button} from "react-bootstrap"

function InputCity() {
    return (
        <>
        <Form>
              <Form.Control
                type="text" 
                placeholder="What is the next boss?"/>
                <Button>
                    Search
                </Button>
        </Form>
        </>
    )
}

export default InputCity
