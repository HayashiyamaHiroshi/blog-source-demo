import React, {FC, useContext} from 'react';
import './App.css';
import {CounterContext, CounterContextProvider} from "./Contexts/CounterProvider";
import {Decrement, Increment, IncrementAction} from "./Reducers/CounterReducer";

function App() {
  return (
      <CounterContextProvider>
          <Counter/>
      </CounterContextProvider>
  );
}

const Counter : FC = () => {
  const context = useContext(CounterContext)
  return(
      <div>
        <h2>this is counter app.</h2>
        <p>{context.count}</p>
        {console.log(context.count)}
        <button onClick={() => context.dispatch(Increment())}>increment</button>
        <button onClick={() => context.dispatch(Decrement())}>decrement</button>
      </div>
  )
};

export default App;
