import React from 'react';
import logo from './logo.svg';
import './App.css';
import Student from "./Components/Student";
import Teacher from "./Components/Teacher";

function App() {
  return (
    <div className="App">
      <Student Data={{Name : "鈴木",Gakunen : 3}}/>
      <Teacher Data={{Name : "田中",Kyouka : "数学"}}/>
    </div>
  );
}

export default App;
