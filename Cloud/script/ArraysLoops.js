"use strict";

// Assignment 1
console.log("Assignment 1");
let countries = [`Denmark`, `Sweden`, `Norway`, `Finland`];
console.log(countries);



// Assignment 2
console.log("Assignment 2");
let ranValues = ["Christian", 45, [1, 2, 3], "Dorte"];

console.log(ranValues[2][1]);



// Assignment 3
console.log("Assignment 3");
let fruits = [`apples`, `oranges`, `bananas`];

// a) Add a new fruit to the end of the array
fruits.push(`kiwi`);
console.log(fruits);

// b) Add a new fruit to the beginning of the array
fruits.unshift(`strawberry`);
console.log(fruits);

// c) Remove the last fruit from the array
let removed = fruits.pop();
console.log(fruits + " + removed: " + removed);

// d) Remove `apples` and `oranges` from the array
fruits.splice(1, 2);
console.log(fruits);



// Assignment 4
console.log("Assignment 4");
let user = {firstname: "John", lastname: "Doe", address: "Fosse Way 1", city: "London", phone: "4532 2341 7392"};

// a) Print the user object
console.log(user);

// b) Print the index of the user object
for (let index in user) {
  console.log(index);
}

// c) Print the values of the user object
for (let index in user) {
  console.log(user[index]);
}

// d) Print the index and values of the user object
for (let index in user) {
  console.log(index + ": " + user[index]);
}



// Assignment 5
let userInput = prompt("Indtast et tal mellem 1 og 10");
while (userInput < 0 || userInput > 10 || isNaN(userInput) || userInput === "")
{
  // If the user input is invalid, prompt the user to enter a valid number
  userInput = prompt("Ugyldig værdi: " + userInput);
}
alert(`Gyldig værdi: ${userInput}`);
