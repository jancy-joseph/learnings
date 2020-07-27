//GIVEN Problem 1

// const cars = ['Tesla', 'Mercedes', 'Honda']
// const [ randomCar ] = cars
// const [ ,otherRandomCar ] = cars
// //Predict the output
// console.log(randomCar)
// console.log(otherRandomCar)

// predicted o/p:
// Tesla
// Mercedes

// // Actual O/p:
// PS C:\Users\jancy\Desktop\Coding_Dojo\MERN\React_Javascript\Begining\Assigments_Javascript> node .\Predict_Destructuring.js
// Tesla                                                                                                  ting.js
// Mercedes   

//GIVEN  Problem 2

// const employee = {
//     name: 'Elon',
//     age: 47,
//     company: 'Tesla'
// }
// const { name: otherName } = employee;
// //Predict the output
// console.log(name);
// console.log(otherName);

// predicted o/p:
// undefined for name
// otherName has value Elon

// // Actual O/p:
// C:\Users\jancy\Desktop\Coding_Dojo\MERN\React_Javascript\Begining\Assigments_Javascript\Predict_Destructuring.js:28                                                                                                
// console.log(name);
//             ^

// ReferenceError: name is not defined
//     at Object.<anonymous>  

//Given Problem 3

// var person = {
//     name: 'Phil Smith',
//     age: 47,
//     height: '6 feet',
//   //  "12345":'12345'
// }
// const password = '12345';
// const {password:hashedPassword } = person;  
// //Predict the output
// console.log(password);
// console.log(hashedPassword);

// predicted o/p:
// 12345
// undefined 
//as there is no password in person object:
//I am not sure it will create a new entry in person.
//I could be wrong.Now wondering how it would react if we had a 12345 as key in person onject.
//lesson learnt: you cant have numbers as keys .I also tried ParseInt(password)
//threw some syntax error. I need to explore how to onvert double quotes to single quotes..
//....defintely going mad here

// // Actual O/p:
// 12345
// undefined 


// Given Problem 4

// const numbers = [8, 2, 3, 5, 6, 1, 67, 12, 2];
// const [,first] = numbers;
// const [,,,second] = numbers;
// const [,,,,,,,,third] = numbers;
// //Predict the output
// console.log(first == second);
// console.log(first == third);

// predicted o/p:
// first = 2
// second = 4
// third = 2
// so output will be
// false
// true



// // Actual O/p:
// PS C:\Users\jancy\Desktop\Coding_Dojo\MERN\React_Javascript\Begining\Assigments_Javascript> node .\Predict_Destructuring.js
// false
// true 

// Problem 5

const lastTest = {
    key: 'value',
    secondKey: [1, 5, 1, 8, 3, 3]
}
const { key } = lastTest;
const { secondKey } = lastTest;
const [ ,willThisWork] = secondKey;
//Predict the output
console.log(key);
console.log(secondKey);
console.log(secondKey[0]);
console.log(willThisWork);

// predicted o/p:
// key ='value'
// secondKey =[1,5,1,8,3,3]
// secondKey[0] = 1
// willThisWork = secondKey[1] = 5;
 
//Actual o/p: Yeah! I got it right
// PS C:\Users\jancy\Desktop\Coding_Dojo\MERN\React_Javascript\Begining\Assigments_Javascript> node .\Predict_Destructuring.js
// value
// [ 1, 5, 1, 8, 3, 3 ]
// 1
// 5

