const express= require('express');

// const {functionA,functionB} = require('./config/config')
const mongoose = require('mongoose');
const cors= require('cors');

const app=express();
//setting up that middle ware /express will only accept json
//and not a html get/post
app.use(express.json());
app.use(cors());

mongoose.connect('mongodb://localhost/myfirtmongoose',{
    useNewUrlParser:true,
    useUnifiedTopology:true,
    useFindAndModify:false
})

const DogSchema = new mongoose.Schema({
    name:{
        type:String,
        required:true,
        minlength:[2,"Your dog name must be>2 "]},
    color:String,
},{timestamps:true})
//written like this
const dog= mongoose.model("Dog",DogSchema);
//or two seperate files
// mongoose.model("Dog",DogSchema);
// const Dog = mongoose.model("Dog");



//localhost:8001/about only - remmeber to have :id sort in the bottom or this route wont get caught
// app.get('/about',(req,res)=>{
//     res.send("<h1>Welcome to about</h1>");
// });

// //localhost:8001/jojo or localhost:8001/4
// app.get('/:id',(req,res)=>{
//     console.log(req.params);
//    // res.end();
//    res.send({message:`Hello World ${req.params.id}`});

// })

// app.get('/api/names/:id',(req,res)=>{
//     res.json({
//         "name":"jancy",
//         "id": 10,
//         "address":"3850s,Klahanie Dr.SE,apt25-101,Issaquah,WA-98029"
//     })
// })



app.listen(8001,()=>{
    console.log(`Listening on port 8001`);
});