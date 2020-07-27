//Rest/Spread
const animals = ['horse', 'dog', 'fish', 'cat', 'bird'];
//const [firstAnimal, secondAnimal] = animals;
//console.log(firstAnimal,secondAnimal);
// //O/P:
// PS C:\Users\jancy\Desktop\Coding_Dojo\MERN\React_Javascript\Begining> node .\Rest_spread.js
// horse dog

 const [firstAnimal, secondAnimal, ...otherAnimals] = animals;
// otherAnimals
// => ['fish', 'cat', 'bird']
//console.log(otherAnimals);

// o/p:
// PS C:\Users\jancy\Desktop\Coding_Dojo\MERN\React_Javascript\Begining> node .\Rest_spread.js
// [ 'fish', 'cat', 'bird' ]

const person = {
    firstName: 'Bob',
    lastName: 'Marley',
    email: 'bob@marley.com',
    password: 'sekureP@ssw0rd9',
    username: 'barley',
    addresses: [
      {
        address: '1600 Pennsylvania Avenue',
        city: 'Washington, D.C.',
        zipcode: '20500',
      },
      {
        address: '221B Baker St.',
        city: 'London',
        zipcode: 'WC2N 5DU',
      }
    ],
    createdAt: 1543945177623
};

 const { firstName, lastName, ...attributes } = person;
//  console.log(firstName,lastName);
//  console.log(attributes);

 //const personCopy = { ...person };

 //console.log(personCopy);
 const personCopy = { ...person };

 //the below was my last attempt: to check if it was deep copy or shallow copy and it seems it is shallow copy only.
//  //console.log(personCopy);
// // delete person.addresses;

// // console.log(personCopy);
// // console.log(person);
// PS C:\Users\jancy\Desktop\Coding_Dojo\MERN\React_Javascript\Begining> node .\Rest_spread.js
// {
//   firstName: 'Bob',
//   lastName: 'Marley',
//   email: 'bob@marley.com',
//   password: 'sekureP@ssw0rd9',
//   username: 'barley',
//   addresses: [
//     {
//       address: '1600 Pennsylvania Avenue',
//       city: 'Washington, D.C.',
//       zipcode: '20500'
//     },
//     { address: '221B Baker St.', city: 'London', zipcode: 'WC2N 5DU' }
//   ],
//   createdAt: 1543945177623
// }
// {
//   firstName: 'Bob',
//   lastName: 'Marley',
//   email: 'bob@marley.com',
//   password: 'sekureP@ssw0rd9',
//   username: 'barley',
//   createdAt: 1543945177623
// }
// PS C:\Users\jancy\Desktop\Coding_Dojo\MERN\React_Javascript\Begining>

 
//console.log(personCopy === person);
// => false
//console.log(personCopy.addresses === person.addresses);
// => true
//Because curriculum said it is shallow copy and nested structures in person will have the original value..
//I want to know what happens if I delete person properties.in the original object .Will it refeclect in PersonCopy using spread.
//result it is shallow copy so no effect.

//console.log(personCopy);
// delete person.addresses;

// console.log(personCopy);
// console.log(person);


// O/p:
// PS C:\Users\jancy\Desktop\Coding_Dojo\MERN\React_Javascript\Begining> node .\Rest_spread.js
// {
//   firstName: 'Bob',
//   lastName: 'Marley',
//   email: 'bob@marley.com',
//   password: 'sekureP@ssw0rd9',
//   username: 'barley',
//   addresses: [
//     {
//       address: '1600 Pennsylvania Avenue',
//       city: 'Washington, D.C.',
//       zipcode: '20500'
//     },
//     { address: '221B Baker St.', city: 'London', zipcode: 'WC2N 5DU' }
//   ],
//   createdAt: 1543945177623
// }
// {
//   firstName: 'Bob',
//   lastName: 'Marley',
//   email: 'bob@marley.com',
//   password: 'sekureP@ssw0rd9',
//   username: 'barley',
//   createdAt: 1543945177623
// }
// PS C:\Users\jancy\Desktop\Coding_Dojo\MERN\React_Javascript\Begining> 

