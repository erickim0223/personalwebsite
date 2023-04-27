import React from 'react';
import Stock from './Stock';
import DIA from './DIA';
import Interest from './Interest';
import './App.css';

function App() {
  return (
    <div className="App">
      <h1>Stock Market/Economy</h1>
      <Interest></Interest>
      <DIA></DIA>
      <Stock></Stock>
      <Stock></Stock>
    </div>
  );
}

export default App;
