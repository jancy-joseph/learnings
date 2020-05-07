//Arrow Functions vs Anonymous functions

//Regular function
var sayHello = function(name) {
    console.log('Hello ' + name);
  };
// console.log(sayHello());
// PS C:\Users\jancy\Desktop\Coding_Dojo\MERN\React_Javascript\Begining> node arrowFunctions.js
// Hello undefined
// undefined --becuase we didnt return anythins
//console.log(sayHello(aaron));
// console.log(sayHello(aaron));
//                      ^

// ReferenceError: aaron is not defined


console.log(sayHello("aaron"));
// PS C:\Users\jancy\Desktop\Coding_Dojo\MERN\React_Javascript\Begining> node arrowFunctions.js
// Hello aaron
// undefined ---> fucntion doesnot return anything

// var sayHello = function(name) {
//   return ('Hello ' + name);
//      };
// PS C:\Users\jancy\Desktop\Coding_Dojo\MERN\React_Javascript\Begining> node arrowFunctions.js
// Hello aaron
// PS C:\Users\jancy\Desktop\Coding_Dojo\MERN\React_Javascript\Begining> 


//anonymous functions
// const sayHello = (name) => {
//     console.log(`Hello ${name}`);
//   };


// var square = function(n) {
//   return n * n;
// };

//will become

//const square = n => n * n;



// longhand notation to return an object
// NOTE: first set of brackets are defining the function body
// and the second set of brackets are to create the object literal
// const returnObjLonghand = () => {
//   return { 
//       firstName: 'John',
//       lastName: 'Wick'
//   }
// }
/**
* The example below wouldn't work because the 
* brackets are interpreted as opening the body of the 
* function rather than brackets to create an object literal 
*/
//const returnObj = () => { firstName: 'John', lastName: 'Wick' }
// surrounding the implicit return with parenthesis solves the problem
//const returnObjFixed = () => ({ firstName: 'John', lastName: 'Wick' });
