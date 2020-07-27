// GIVEN 1

// console.log(hello);                                   
// var hello = 'world';

//AFTER HOISTING BY THE INTERPRETER
// var hello;
// console.log(hello);
// hello = 'world';

//predicted o/p: should be undefined
//ran as predicted
//Learnings let and const returned referenceerror.so checks syntax
// console.log(hello);
//             ^

// ReferenceError: Cannot access 'hello' before initialization



// GIVEN 2
// var needle = 'haystack';
// test();
// function test(){
//     var needle = 'magnet';
//     console.log(needle);
// }

//AFTER HOISTING BY THE INTERPRETER
// var needle = 'haystack';
// test();
// function test(){
//     var needle = 'magnet';
//     console.log(needle);
// }

//predicted o/p: print magnet only
//Works as predicted. Since second var is boxed in function it wont go to top.


// GIVEN 3
// var brendan = 'super cool';
// function print(){
//     brendan = 'only okay';
//     console.log(brendan);
// }
//  console.log(brendan);

//AFTER HOISTING BY THE INTERPRETER
//Hosting is same. Should print 'super cool'
//works as predicted



// GIVEN 4
// var food = 'chicken';
// console.log(food);
// eat();
// function eat(){
//     food = 'half-chicken';
//     console.log(food);
//     var food = 'gone';
// }

//AFTER HOISTING BY THE INTERPRETER
// var food = 'chicken';
// console.log(food);
// eat();
// function eat(){
//     var food;
//     food = 'half-chicken';
//     console.log(food);
//     food = 'gone';
// }

// predicted o/p: chicken
//             half-chicken
//got that right!

// GIVEN 5
// mean();
// console.log(food);
// var mean = function() {
//     food = "chicken";
//     console.log(food);
//     var food = "fish";
//     console.log(food);
// }
// console.log(food);

//AFTER HOISTING BY THE INTERPRETER
// var mean;
// mean();
// mean = fucntion(){
// var food = "fish";
// food ="chicken";
// console.log(food);
// }

// Predicted o/p: chicken
//After executing the prgoram:
//mean();
// GOt this error instead:
// mean();
// ^

// TypeError: mean is not a function
//     at Object.<anonymous>

// GIVEN 6
// console.log(genre);
// var genre = "disco";
// rewind();
// function rewind() {
//     genre = "rock";
//     console.log(genre);
//     var genre = "r&b";
//     console.log(genre);
// }
// console.log(genre);

//AFTER HOISTING BY THE INTERPRETER

// var genre = "disco";
// console.log(genre);
// rewind();
// function rewind() {
//     var genre = "r&b";
//     genre = "rock";
//     console.log(genre);
//     console.log(genre);
// }
// console.log(genre);

// Predicted o/p:
// disco 
// rock
// rock
// disco

//Myprediction ws wrong . We got 
// undefined
// rock
// r&b
// disco

// so it seems like for string datatype the value doesnt get hoisted..so propably looks like
// var genre;
// console.log(genre);
// genre="disco";
// rewind();
// function rewind() {
//     var genre;
//     genre = "rock";
//     console.log(genre);
//      genre= "r&b";
//      console.log(genre);
// }
// console.log(genre);

// GIVen 7
// dojo = "san jose";
// console.log(dojo);
// learn();
// function learn() {
//     dojo = "seattle";
//     console.log(dojo);
//     var dojo = "burbank";
//     console.log(dojo);
// }
// console.log(dojo);

//AFTER HOISTING BY THE INTERPRETER
// dojo="san jose";
// console.log(dojo);
// learn();
// function learn() {
//     var dojo ;
//     dojo = "seattle";
//     console.log(dojo);
//      dojo = "burbank";
//     console.log(dojo);
// }
// console.log(dojo);

// Predicted o/p: Suntax error for first two lines as dojo doesnot have a datatype defined.

//got  this instead:
// san jose
// seattle
// burbank
// san jose
//so it seems like as long as value is assigned it should be ok.it doesnot need a var attached to it.


//GIVEN 8 - Bonus ES6: const 
// console.log(makeDojo("Chicago", 65));
// console.log(makeDojo("Berkeley", 0));
// function makeDojo(name, students){
//     const dojo = {};
//     dojo.name = name;
//     dojo.students = students;
//     if(dojo.students > 50){
//         dojo.hiring = true;
//     }
//     else if(dojo.students <= 0){
//         dojo.hiring = "closed for now";
//     }
//     return dojo;
// }

//AFTER HOISTING BY THE INTERPRETER
//It should look the the same.
//Predicted o/p
//Even though it is const.I think I heard you say that const sometimes allows 
//objects to change its value in javascipt unlike other languages
//so should print
//{name:"Chicago",students:65,hiring:true}
//{name:"Berkley",students:0,hiring:"closed for now"}
//Other languages would have errored now
//keeping fingers crossed

//        dojo = "closed for now";
 //            ^

//TypeError: Assignment to constant variable.

//hmmm..I didnt see the that it was not hiring getting updated there.
//so it seems within the scope const cant be changed just like other languagues
//I tried 
// console.log(makeDojo("Chicago", 65));
// console.log(makeDojo("Berkeley", 0));
// function makeDojo(name, students){
//     const dojo = {};
//     dojo.name = name;
//     dojo.students = students;
//     if(dojo.students > 50){
//         dojo.hiring = true;
//     }
//     else if(dojo.students <= 0){
//         dojo.hiring = "closed for now";
//     }
//     return dojo;
// }

// and got this as o/p:
// { name: 'Chicago', students: 65, hiring: true }
// { name: 'Berkeley', students: 0, hiring: 'closed for now' }
