import React from 'react'
import Card from 'react-bootstrap/Card'
import styles  from "./styles.module.css"

function Estimations() {

    return (


        <>
            <div className={styles.cityInfo}>
                London, Uk
            </div>

            <div className={styles.wCards}>
                <Card className= {styles.card} style={{ width: '15rem' }}>
                    <Card.Header>Monday</Card.Header>
                    <Card.Body>
                        
                        <Card.Text>16°C</Card.Text>
                        {/* weather img */}
                        <Card.Img variant="top" src="http://openweathermap.org/img/wn/10d@2x.png" />

                        <Card.Text>Rain</Card.Text>
                    </Card.Body>
                </Card>
            </div>
        </>
    )
}

export default Estimations

