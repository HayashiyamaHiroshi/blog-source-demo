import React,{createContext, FC, useReducer} from "react";
import {CounterActions, CounterInitialState, CounterReducer} from "../Reducers/CounterReducer";

type CounterContextState = {
    count : number,
    dispatch : React.Dispatch<CounterActions>
}

export const CounterContext = createContext<CounterContextState>({} as CounterContextState);

export const CounterContextProvider : FC = ({children}) => {
    const [state,dispatch] = useReducer<typeof CounterReducer>(CounterReducer,CounterInitialState);
    return(
        <CounterContext.Provider value={{
            count : state.count,
            dispatch : dispatch
        }
        }>
            {children}
        </CounterContext.Provider>
    )
};