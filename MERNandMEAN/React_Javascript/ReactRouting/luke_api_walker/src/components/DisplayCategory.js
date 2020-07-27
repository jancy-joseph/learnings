import React,{ useState } from "react";
import {Router,navigate} from '@reach/router';

const DisplayCategory =(props)=>{
    const [category, setCategory] = useState("");
    const [id, setId] = useState("");
    // const{categoryObj,setCategoryobj} = props;


    // const SelectHandler=(e)=>{
    //     console.log("Select:"+e.target.value)
    //   // categoryObj.category= e.target.value;
    //    setCategoryobj(...categoryObj,categoryObj.category=e.target.value);
    // }

    // const IdHandler=(e)=>{
    //     console.log("ID:"+e.target.value)
    //  //categoryObj.id =e.target.value;
    //  setCategoryobj(...categoryObj,categoryObj.id=e.target.value);

    //  navigate(`/${categoryObj.category}/${categoryObj.id}`)
    // }
    const SubmitHandler=(e)=>{
        // console.log(categoryObj.category);
        // console.log(categoryObj.id);
        navigate(`/${category}/${id}`);
       document.getElementById("ctype").value = "";
       document.getElementById("categoryid").value = "";
    }

    return(
    <div className="container"> 
        <div className="row">
        <label className="col-1">search For:</label>
        <select name="ctype" id="ctype" onChange={(e) => setCategory(e.target.value)} className="col-1">
            <option value="">-Select Category-</option>
            <option value="people">People</option>
            <option value="planets">Planets</option>
            <option value="starships">Starships</option>
            <option value="species">Species</option>
            <option value="vehicles">Vehicles</option>
        </select>
        <label className="col-2">ID:</label>
        <input className="col-2" name="catgoryid" id="categoryid" onChange={(e) => setId(e.target.value)}></input>
        <button onClick={SubmitHandler} className="col-3 ml-2 btn btn-outline-info">Search</button>
    </div>
    </div>
    
    );
}
export default DisplayCategory;