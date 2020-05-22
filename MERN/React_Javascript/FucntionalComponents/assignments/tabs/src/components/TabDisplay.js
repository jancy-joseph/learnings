import React,{useState} from 'react';

const TabDisplay = (props) => {
    const{Tabs,setTabs} = props
    const[content,setContent] = useState("");

    const onClickHandler =(e)=>{
        setContent(e.target.value);

    }

    return(   
        <div class="container">
            <div class ="row">
            {
                props.Tabs.map( (Tab, i) =>                
                    <button className="tablinks" value={Tab.content} name="{Tab.name}" onClick={onClickHandler}>{Tab.name}</button>)
            }
            </div>
            <div class="row">
                <div className="col-sm-6 offset-sm-2" style={{background: "cyan", height: "100px"}}>
                    <p>{ content }</p>
                </div>
            </div>

        </div>
        );
}

export default TabDisplay;