import React, { useState, createContext } from 'react'

export const CalcContext = createContext()

export const CalcProvider = ({ children }) => {
    // defining necessary initial states   
    const [mainText, setMainText] = useState("0")
    const [resetMainTextNextTime, setResetMainTextNextTime] = useState(false)

    const [lastResult, setLastResult] = useState()
    const [currentOperation, setCurrentOperation] = useState()
    const [lastOperation, setLastOperation] = useState()
    const [writeSteps, setWriteSteps] = useState()


    // three button status are applied for tracking calculation process
    const handleKeyClick = (isNumber, label, operator, editor) => {
        // if number is clicked
        if (isNumber) {
            // make main text the label if one operation is clicked
            // initial moment
            if (resetMainTextNextTime) {
                setMainText(label)
                setLastResult(Number(mainText))
                setResetMainTextNextTime(false)

            } else {
                // if number is clicked it immediately deletes the 0 initial state text from left of it. 
                setMainText((mainText) => {
                    return (mainText === 0 || "0" ? (mainText + label).replace(0 || "0", "") : mainText + label )
                })
            }
        }

        if (editor) {
            switch (label) {
                // clear entry
                case "CE":
                    setMainText(0)
                    break
                // clear all
                case "C":
                    setLastResult(0)
                    setMainText(0)
                    setLastOperation()
                    break
                // negative positive
                case "+/-":
                    // if value is below 0, delete minus. if value is above 0, add minus                
                    // if no last result manipulate the sign of main text
                    if (!lastResult) {
                
                        Number(mainText) < 0 ? setMainText(mainText.replace("-","")) : setMainText("-" + mainText)
                    }
                    else {
                        lastResult < 0 ? (setLastResult(lastResult.replace("-",""))) : setLastResult("-" + lastResult)
                        setMainText(lastResult)
                    }
                    break
                // delete the latest entry
                case "<-":
                    // checks any entry is applied and not equal to zero
                    if (mainText && mainText !== "0" ) {
                                                // if one item left assign 0 to main text
                        mainText.length === 1 ? setMainText("0") 
                                                // if not delete the last
                                              : setMainText(mainText.replace(mainText[mainText.length-1],""))                     
                    }
                    break          
                case ".":
                    if (lastResult) {
                        setMainText(mainText+".")
                        setLastResult(mainText+".")
                        setLastOperation(".")
                    }
                    break
                default:
                    break
                
            }
        }

        if (operator) {
            setCurrentOperation(label) // select the operation
            setResetMainTextNextTime(true)

            switch (label)  {
                case "+":
                    
                    if (!lastResult) {
                        setLastResult(Number(mainText))

                        setWriteSteps(mainText)
                        // holding the last operation
                        setLastOperation("+")                       
                    }
                    // if last operation is not + and not empty
                    else if (lastOperation !== "+") {
                        
                        setLastResult(eval(String(lastResult) + lastOperation + `${Number(mainText)}`))
                        setMainText(eval(String(lastResult) + lastOperation + `${Number(mainText)}`))
                        setWriteSteps(writeSteps + lastOperation + String(mainText))
                        setLastOperation("+")
                    }
                    // defining an extra condition for applying comma because of the algorithm str
                    else if (!lastResult && lastOperation === ".") {
                        setLastResult(eval(String(lastResult) + label + `${Number(mainText)}`))
                        setMainText(eval(String(lastResult) + label + `${Number(mainText)}`))
                        setWriteSteps(writeSteps + label + String(mainText))
                        setLastOperation("+")
                    }

                    else {
                        // make the calc
                        setLastResult(Number(mainText) + lastResult)
                        // write the clicking history
                        setWriteSteps(writeSteps + label + mainText)
                        // push result to main text
                        setMainText(Number(mainText) + lastResult)
                        // set last operation to +
                        setLastOperation("+")
                        }
                    break

                case "-":
                    if (!lastResult) {
                        setLastResult(Number(mainText))
                        setWriteSteps(mainText)
                        setLastOperation("-")
                    }

                    else if (lastOperation !== "-") {
                        
                        setLastResult(eval(String(lastResult) + lastOperation + mainText))
                        setMainText(eval(String(lastResult) + lastOperation + `${Number(mainText)}`))
                        setWriteSteps(writeSteps + lastOperation + String(mainText))
                        setLastOperation("-")
                    }

                    else if (!lastResult && lastOperation === ".") {
                        setLastResult(eval(String(lastResult) + label + `${Number(mainText)}`))
                        setMainText(eval(String(lastResult) + label + `${Number(mainText)}`))
                        setWriteSteps(writeSteps + label + String(mainText))
                        setLastOperation("-")
                    }
                    
                    else {
                        // make the calc
                        setLastResult(lastResult - Number(mainText))
                        // write the clicking history                       
                        setWriteSteps(writeSteps + label + mainText)
                        // push result to main text
                        setMainText(lastResult - Number(mainText))

                        setLastOperation("-")
                    }
                    
                    break
                
                case "x":
                    if (!lastResult) {
                        setLastResult(Number(mainText))
                        setWriteSteps(mainText)
                        setLastOperation("*")
                    }

                    else if (lastOperation && (lastOperation !== "*" && lastOperation !== ".")) {
                        setLastResult(eval(String(lastResult) + lastOperation + `${Number(mainText)}`))
                        setMainText(eval(String(lastResult) + lastOperation + `${Number(mainText)}`))
                        setWriteSteps(writeSteps + lastOperation + String(mainText))
                        setLastOperation("*")
                    }

                    else if (!lastResult && lastOperation === ".") {
                        setLastResult(eval(String(lastResult) + label + `${Number(mainText)}`))
                        setMainText(eval(String(lastResult) + label + `${Number(mainText)}`))
                        setWriteSteps(writeSteps + label + String(mainText))
                        setLastOperation("*")
                    }

                    else {
                        // make the calc
                        setLastResult(lastResult * Number(mainText))
                        // write the clicking history                       
                        setWriteSteps(writeSteps + label + mainText)
                        // push result to main text
                        setMainText(lastResult * Number(mainText))

                        setLastOperation("*")
                        }
                    break
                case "/":
                    if (!lastResult) {
                        setLastResult(Number(mainText))
                        setWriteSteps(mainText)
                        setLastOperation("/")
                    }

                    else if (lastOperation !== "/") {
                        setLastResult(eval(String(lastResult) + lastOperation + `${Number(mainText)}`))
                        setMainText(eval(String(lastResult) + lastOperation + `${Number(mainText)}`))
                        setWriteSteps(writeSteps + lastOperation + String(mainText))
                        setLastOperation("/")
                    }

                    else if (!lastResult && lastOperation === ".") {
                        setLastResult(eval(String(lastResult) + label + `${Number(mainText)}`))
                        setMainText(eval(String(lastResult) + label + `${Number(mainText)}`))
                        setWriteSteps(writeSteps + label + String(mainText))
                        setLastOperation("/")
                    }

                    else {
                        // make the calc
                        setLastResult(lastResult / Number(mainText))
                        // write the clicking history                       
                        setWriteSteps(writeSteps + label + mainText)
                        // push result to main text
                        setMainText(lastResult / Number(mainText))

                        setLastOperation("/")
                        }
                    break
                
                case "x^(1/2)":
                    if (!lastResult) {
                        setLastResult(Math.sqrt(Number(mainText)))
                        setWriteSteps()
                        setMainText(Math.sqrt(Number(mainText)))
                        
                    }

                    else {
                        setLastResult(Math.sqrt(lastResult))
                        setMainText(Math.sqrt(lastResult))
                    }
                    break
                
                case "x^2":
                    
                    if (!lastResult) {
                        setLastResult(Math.pow(Number(mainText), 2))
                        setWriteSteps(" ")
                        setMainText(Math.pow(Number(mainText), 2))
                        setLastOperation(" ")
                    }

                    else {

                        setLastResult(Math.pow(lastResult, 2))
                        setMainText(Math.pow(lastResult, 2))
                        setLastOperation()
                    }

                    break
                
                case "1/x":
                    if (!lastResult) {
                        setLastResult(1/Number(mainText))
                        setWriteSteps()
                        setMainText(1/Number(mainText))
                        
                    }

                    else {
                        setLastResult(1/lastResult)
                        setMainText(1/lastResult)
                    }

                    break

                case "%":
                    if (!lastResult) {
                        setLastResult(Number(mainText)/100)
                        setWriteSteps()
                        setMainText(Number(mainText)/100)
                    }

                    else {
                        setLastOperation(lastResult/100)
                        setMainText(lastResult/100)
                    }
                    break
                
                case "=":
                    // addition
                    if (currentOperation === "+") {
                        setMainText(Number(mainText) + lastResult);
                        setLastResult("");
                    }
                    // substraction
                    else if (currentOperation === "-") {
                        setMainText(lastResult - Number(mainText));
                        setLastResult("");
                    }
                    // multiplication
                    else if (currentOperation === "x") {
                        setMainText(lastResult * Number(mainText));
                        setLastResult("");
                    }
                    // division
                    else if (currentOperation === "/") {
                        setMainText(lastResult / Number(mainText));
                        setLastResult("");
                    }
                    // percentage
                    else if (currentOperation === "%") {
                        setMainText((lastResult * Number(mainText)) / 100);
                        setLastResult("");
                    }
                    break;

                    default:
                        break
                    
                }

            }
    }
    return (<CalcContext.Provider
                value = {{
                    mainText,
                    setMainText,
                    handleKeyClick,
                    resetMainTextNextTime,
                    setResetMainTextNextTime,
                    lastResult,
                    currentOperation,
                    writeSteps
                }}
            >
                {children}
            </CalcContext.Provider>
        
    )
}