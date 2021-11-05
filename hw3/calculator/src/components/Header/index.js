// Top Header
import React from 'react'

const styles = {
    topHeader: {
      width: "100%",
      height: "5%",
    },
    text: {
      color: "#fff",
      fontSize: 10,
      margin: 5,
    },
  };

function TopHeader() {
    return (
        <div style={styles.topHeader}>
            <span style={styles.text}>Calculator</span>
        </div>
    )
}

export default TopHeader