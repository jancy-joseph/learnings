import React,{useState} from 'react';

const BoxDisplay = (props) => {
    //One box
   // const{color,height,width} = props.boxdetails;


    return(
        //One box

        // <div style={{
        //     backgroundColor: color,
        //     width: width+"px",
        //     height: height+"px",
        //     display: "inline-block",
        //     border: "1px solid lightgrey",
        //     borderRadius: "5px",
        //     marginLeft: "5px",
        //     marginRight: "5px",
        // }}><p>c:{color}h:{height}w:{width}</p></div>    
        //Mulitple box
        <div>
            {props.Boxes.map( (Box, i) =>                 
                <div key={i} style={{
                    display: 'inline-block',
                    height:`${Box.height}px`,
                    width:`${Box.width}px`, 
                    margin: '1em',
                    background:`${Box.color}`
                }}></div>
                )
            }
        </div>


    );
};

export default BoxDisplay;