import FetchTry from './Components/Product';
import ProductProvider from './Context/ProductContext';
import './App.css';

function App() {
  return (
    <div className="App">
      <ProductProvider>
        <FetchTry />
      </ProductProvider>
    </div>
  );
}

export default App;
