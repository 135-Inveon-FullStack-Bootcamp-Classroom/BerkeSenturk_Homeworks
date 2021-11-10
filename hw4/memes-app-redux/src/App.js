import Header from "./components/Header";
import { createRedux } from "react-redux";
import {
  applyMiddleware,
  createAsyncThunk,
  createStore
} from "@reduxjs/toolkit";
function App() {
  return (
    <>
      <Header />
    </>
  );
}

export default App;
