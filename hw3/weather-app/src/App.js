import { Container, Row, Col } from 'react-bootstrap';
import Estimations from './Components/Estimations';
import InputCity from './Components/Search/Input';
import FetchTry from './Components/Fetch';
// import SelectLocation from './Components/Search/Map';
import './App.css';

function App() {
  return (
  <Container >
    
    <Row >
      
      {/* <Col lg={8}>  
        <SelectLocation />
      </Col> */}

      <Col lg={4}>      
        <InputCity />      
      </Col>

    </Row>

    <Row>
      <Col>
        <Estimations />
      </Col>
    </Row>

    <Row>
      <FetchTry />
    </Row>

  </Container>
  );
}

export default App;
