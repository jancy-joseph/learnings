// let person = {
//     id: 8,
//     name: "Brendan",
//     location: "California",
//     email: "bstanton@codingdojo.com",
//     dojo: "Silicon Valley"
// }

// // "location"

// // hashing algorithm(keyname)
// // => 1032

// // [...1031,    1032,       1033, 1034...]
// //     email    location    dojo

// // dict.hasOwnProperty()

// // for of looping over array of keys

// let keys = Object.keys(person);
// console.log(keys);


// // Challenge #1: Object Search
// // given a 'search for' object with primative values and a list of objects
// // return a new list of objects containing the same key value pairs as the search for

// // given searchFor and items
const searchFor = {
    firstName: "Bob",
    age: 31
};

let searchKeys = Object.keys(searchFor);
for(var i of searchKeys)
{
    console.log(i);
}

const items = [
    { firstName: "Bob", lastName: "Bobbert", age: 31 },
    { firstName: "John", lastName: "Smith", age: 25 },
    { firstName: "Bob", lastName: "Smith", age: 27 },
    { firstName: "Bob", lastName: "White", age: 31 }
];

// for(var item in items)
// {
//     let output = [];
//     let allKeysPresent = false;
//     for(var key of searchKeys)
//     {
//         if (item.hasOwnProperty(key))
//         {
//             allKeysPresent = true;
//         }
//     }
//     if(allKeysPresent)
//     {
//         output.push(item);
//     }

// }

// return a new list of objects containing the same key pair values
// const output = [
//     { firstName: "Bob", las


function dictionarytoSearch(searchfor, dictionarytoSearch){
    let output = [];
    let searchKeys = Object.keys(searchfor);
    for(var item of dictionarytoSearch)
    {
        
        let allKeysPresent = false;
        for(var key of searchKeys)
        {
            if (item.hasOwnProperty(key) && item[key] == searchfor[key] ) 
            {
                allKeysPresent = true;
            }
            else
            {
                allKeysPresent = false;
            }
        }
        if(allKeysPresent)
        {
            output.push(item);
        }

    }
    return output;
}

console.log(dictionarytoSearch(searchFor,items));

var sorteditemsByage = items.sort((a,b)=>a.age>b.age? -1:1)
console.log(sorteditemsByage);



