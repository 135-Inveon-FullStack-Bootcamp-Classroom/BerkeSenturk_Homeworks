import { useContext } from "react";
import { CalcContext } from "../../contexts/CalcContext";

const styles = {
    screenSection: {
      width: "100%",
      height: "30%",
      display: "flex",
      justifyContent: "center",
      flexDirection: "column",
      alignItems: "flex-end",
      fontFamily: "arial",
    },
    mainText: {
      color: "#fff",
      fontSize: 40,
      padding: 10,
    },
    caption: {
      color: "#999",
      fontSize: 13,
      paddingRight: 10,
    },
  };
  

const ScreenSection = () => {
    const { mainText, lastResult, currentOperation, writeSteps } = useContext(CalcContext);

    const renderCaption = () => {
        if (lastResult && currentOperation)
            return(
                <span style={styles.caption}>
                    {writeSteps}{currentOperation}
                </span>
            )
    }

    return (
        <div style={styles.screenSection}>
            {renderCaption()}
            <span style={styles.mainText}> {mainText} </span>
        </div>
    )
}

export default ScreenSection