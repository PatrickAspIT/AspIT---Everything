"use strict";

// OPGAVE 1
let greeting = "Hej verden";
console.log(greeting);

// OPGAVE 2
let firstname = "John";
let middlename = " F. ";
let lastname = "Kennedy";
let fullname = firstname + middlename + lastname;
console.log(fullname);

// OPGAVE 3
let salary = 5000;
console.log(salary);

// OPGAVE 4
let calculate = (5 + 5) * 3;
console.log(calculate);

// OPGAVE 5
let deci1 = 2.25;
let deci2 = 3.50;
let sum2 = Math.ceil(deci1 + deci2);
console.log(sum2);

// OPGAVE 6
let deci3 = 2.55;
let deci4 = 1.44;
let rounddown = Math.floor(deci3 + deci4);
console.log(rounddown);

// OPGAVE 7
console.log(Math.sqrt(65));

// OPGAVE 8
let stringname = "John Doe is 25 years old"
stringname = stringname.replace(" Doe ", " ");
console.log(stringname);

// OPGAVE 9
let compare = false;
console.log(compare);

// OPGAVE 10
console.log(typeof(fullname) + " " + typeof(salary) + " " + typeof(deci3) + " " + typeof(compare));

// OPGAVE 11
let type1 = "10";
let type2 = "2";
let type3 = 20;
let type4 = 10;

// To seperate it from the previous assignments
console.log("----------");

// A: The result is 102 which is because they are both strings, not numbers, so 10 and 2 is concatenated.
console.log(type1 + type2);
// B: The two values are again concatenated since one of them is a string and the other is a number. They are different.
console.log(type1 + type3);
// C: Same result as in B. Different data types.
console.log(type4 + type2);
// D: The two values are added together, since they are the save data type. The result is 30.
console.log(type3 + type4);
// E: The result is 2010, because type3 is added to the text string and is therefore no longer a number and can't be added with type4.
console.log("Resultatet af type3 + type4 er:" + type3 + type4);
// F: The result is 302 since type3 and type4 are added together to 30 and then type2 is concatenated to that.
console.log(type3 + type4 + type2);
// G: The result is 5. I think that the program sees that we are trying to do a calculation and is then parsing the type2 into a number.
console.log(type4 / type2);
// H: Like in G, type2 is transformed to a number and is calculated with type3. Then type1 is concatenated to that.
console.log(type2 * type3 + type1);
// I: I used parseInt to change them from string to int.
console.log(parseInt(type1) + parseInt(type2));
// J: I used toString to change them from int to string.
console.log(type3.toString() + type4.toString());
