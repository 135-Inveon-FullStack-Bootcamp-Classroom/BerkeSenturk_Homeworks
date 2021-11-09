import React, { useState } from 'react'

function MemeItem() {
    const [isHovered, setIsHovered] = useState(false)
    return (
        <div
            onMouseEnter={() => setIsHovered(true)}
            onMouseLeave={() => setIsHovered(false)}
            onClick={() => console.log("Clicked")}>
            
            {/* Displaying selected img */}
            <img src={this.props.meme.url}
                 alt={this.props.meme.name} 
                 className= {
                     this.state.isHovered ? console.log("hovered make it darker")
                                          :  console.log("not hovered ")/>
            
            <p className={this.state.isHovered ? console.log("hovered make cool stuff")
                                               : console.log("not hovered")}>

                    {this.props.meme.name}
            </p>
        
        </div>
    )
}

export default MemeItem
