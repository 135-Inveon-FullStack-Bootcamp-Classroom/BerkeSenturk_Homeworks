import React, { useState } from 'react'
import { useSelector, useDispatch } from "react-redux"

import {increment, decrement, incrementByAmount } from "../redux/counter/counterSlice"

function Counter() {
    const countValue =  useSelector(state => state.counter.value)
    const [inputVal, setInputVal] = useState(3)
    console.log(countValue);

    const dispatch = useDispatch()

    return (
        <div>
            <h1>{countValue}</h1>
            <button onClick={() => { dispatch(increment())} }>Increment</button>
            <button onClick={() => { dispatch(decrement())} }>Decrement</button>

            <br />
            <br />

            <input type="number" value={inputVal} onChange={(e) => setInputVal(e.target.value)} />
            <button onClick={() => { dispatch(incrementByAmount(inputVal))} }>Increment by Amount</button>

            
        </div>
    )
}

export default Counter
