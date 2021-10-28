import './App.css';

import TodoForm from './components/Form';
import TodoList from './components/List';
import TodosContextProvider from './contexts/TodosContext';

function App() {
  return (
    <div id="container" className="App">

      <TodosContextProvider>
        <div className="todoAll">
          <h2 style={{marginTop:"50px", fontSize:"60px"}}>todos</h2>

          <TodoForm className="todoForm"/>
          
          <TodoList />
        
        </div>
      </TodosContextProvider>
    </div>
  );
}


export default App;
