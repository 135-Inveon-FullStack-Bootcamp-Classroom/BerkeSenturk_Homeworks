import './App.css';
import Meme from './components/Meme';
import TextForm from './components/TextForm';
import MemeList from './components/MemeList';


const stylesLeft = {
  display: "flex",
  flexDirection: "column",
  alignItems: "center",
  justifyContent: "center",
  marginLeft: "100px",
  marginTop: "10px"
}

const stylesRight = {
  
}

function App() {

  return (
    <div className="App">
      <div style={stylesLeft}>
        <Meme />
        <br />
        <TextForm />
      </div>
      
      <hr />

      <div style={stylesRight}>
        <MemeList />
      </div>
    </div>
  );
}

export default App;
