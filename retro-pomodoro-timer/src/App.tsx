import React from 'react';
import './App.css';


function App() {
  return (
    <div className="App">
      <video autoPlay loop muted>
        <source src="/videos/retro-background.mp4" type="video/mp4" />
        Your browser does not support the video tag.
      </video>
      <h1>Pomodoro Timer</h1>
    </div>
  );
}

export default App;
