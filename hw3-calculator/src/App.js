import './App.css';
import TopHeader from './components/Header';
import AppContainer from './components/AppContainer';
import ScreenSection from './components/ScreenSection';
import KeysSection from "./components/KeysSection"


function App() {
  return (
    <div className="App">
      <AppContainer>
        <TopHeader />
        <ScreenSection />
        <KeysSection />
      </AppContainer>
    </div>
  );
}

export default App;
