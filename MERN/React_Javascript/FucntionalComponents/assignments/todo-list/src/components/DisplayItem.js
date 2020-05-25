import React,{useState} from 'react';

const DisplayItem = (props) => {

    const[Item, setItem] = useState({
        theItem: props.Item,
        isCompleted: props.Item.isCompleted,
        msg:props.Item.msg,
        isDeleted:props.Item.isDeleted  
    })

    const checkBoxClickHandler =(e)=>{
        setItem({...Item,isCompleted:!Item.isCompleted})
    }
    const DeleteHandler =(e)=>{
        // Get the checkbox
        if(Item.isCompleted == true){
            setItem({...Item,isDeleted:!Item.isDeleted})
        }
    }
    return(

        <div>
        {Item.isDeleted?
                "" : 
            <div className="row p-2">
                <input type="checkbox" name={Item.msg} onClick={ checkBoxClickHandler } />
                <div style={Item.isCompleted?{textDecoration: "line-through"}:{}} className="col-8 text-left">{Item.msg}</div>
                <button onClick={ DeleteHandler } className="btn btn-outline-secondary btn-sm">Delete</button>
           </div>
        }
        </div>
        );
};

export default DisplayItem;