import FetchTry from './Components/Product';
import AlbumProvider from './Context/AlbumContext';
import './App.css';

function App() {
  return (
    <div className="App">
      <AlbumProvider>
        <FetchTry />
      </AlbumProvider>
    </div>
  );
}

export default App;
