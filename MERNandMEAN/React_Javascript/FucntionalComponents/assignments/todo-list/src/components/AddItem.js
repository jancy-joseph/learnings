import React, { useState }from 'react';

const AddItem = (props) => {
    const [Item,setItem] = useState({"msg":"","isCompleted":false,"isDeleted": false});


    const createItem = (e) => {
        e.preventDefault();
        props.onNewItem(Item);   
        setItem("");
    }
    const ClickHandler = (e)=>{
        Item.msg=e.target.value;
    }
    return(        
    
    <form onSubmit = { createItem }>
            <div className="form-group row">
                <label>Add Task</label>
                <input type="text" name="msg" onChange = {ClickHandler}/>
            </div>
            <div className="form-group row">
                <input type="submit" value="Add Item"/>
            </div>
    </form>);
}
export default AddItem