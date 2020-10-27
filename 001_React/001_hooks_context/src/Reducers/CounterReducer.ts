export const IncrementAction = 'inc' as const;
export const Increment = () => ({type : IncrementAction});

export const DecrementAction = 'dec' as const;
export const Decrement = () => ({type : DecrementAction});

export type CounterActions = ReturnType<typeof Increment> | ReturnType<typeof Decrement>

type CounterState = {
    count : number
}

export const CounterInitialState : CounterState = {
    count : 0
}

export const CounterReducer : React.Reducer<CounterState,CounterActions> = (state = CounterInitialState,actions) =>
{
    switch (actions.type) {
        case IncrementAction:
            return {count : state.count + 1}
        case DecrementAction:
            return {count : state.count - 1}
        default:
            return state
    }
};