"use strict";

// Assignment 1: Creates a form with a text input for firstname and lastname. Also a submit button.
console.log("Assignment 1");
console.log("Creates a form with a text input for firstname and lastname. Also a submit button.");

let form = document.createElement("form");
form.setAttribute("id", "assignment1Form");

let divAssign1First = document.createElement("div");
let labelAssign1First = document.createElement("label");
labelAssign1First.textContent = "Firstname: ";
let firstname = document.createElement("input");
firstname.setAttribute("type", "text");

let divAssign1Last = document.createElement("div");
let labelAssign1Last = document.createElement("label");
labelAssign1Last.textContent = "Lastname: ";
let lastname = document.createElement("input");
lastname.setAttribute("type", "text");

let submit = document.createElement("input");
submit.setAttribute("type", "submit");

divAssign1First.appendChild(labelAssign1First);
divAssign1First.appendChild(firstname);

divAssign1Last.appendChild(labelAssign1Last);
divAssign1Last.appendChild(lastname);

form.appendChild(divAssign1First);
form.appendChild(divAssign1Last);
form.appendChild(submit);

document.body.appendChild(form);

// Assignment 2: Creates a form with 2 number inputs and a submit button. When the form is submitted, the sum of the two numbers is displayed in an alert box.
console.log("Assignment 2");

let form2 = document.createElement("form");
form2.setAttribute("id", "assignment2Form");

let divAssign2First = document.createElement("div");
let labelAssign2First = document.createElement("label");
labelAssign2First.textContent = "First number: ";
let firstNumber = document.createElement("input");
firstNumber.setAttribute("type", "number");

let divAssign2Last = document.createElement("div");
let labelAssign2Last = document.createElement("label");
labelAssign2Last.textContent = "Second number: ";
let secondNumber = document.createElement("input");
secondNumber.setAttribute("type", "number");

let submit2 = document.createElement("input");
submit2.setAttribute("type", "submit");

divAssign2First.appendChild(labelAssign2First);
divAssign2First.appendChild(firstNumber);

divAssign2Last.appendChild(labelAssign2Last);
divAssign2Last.appendChild(secondNumber);

form2.appendChild(divAssign2First);
form2.appendChild(divAssign2Last);
form2.appendChild(submit2);

document.body.appendChild(form2);

form2.addEventListener("submit", function(event) {
  event.preventDefault();
  let sum = Number(firstNumber.value) + Number(secondNumber.value);
  alert("The sum of the two numbers is: " + sum);
  console.log("The sum of the two numbers is: " + sum);
});

// Assignment 3: Creates a form with a number input and a result field. Also a submit button. When the form is submitted, the result field should display the result of adding VAT (moms 25%) and subtracting discount (rabat 10%).

let form3 = document.createElement("form");
form3.setAttribute("id", "assignment3Form");

let divAssign3First = document.createElement("div");
let labelAssign3First = document.createElement("label");
labelAssign3First.textContent = "Price: ";
let price = document.createElement("input");
price.setAttribute("type", "number");

let divAssign3Last = document.createElement("div");
let labelAssign3Last = document.createElement("label");
labelAssign3Last.textContent = "Result: ";
let result = document.createElement("input");
result.setAttribute("type", "text");

let submit3 = document.createElement("input");
submit3.setAttribute("type", "submit");

divAssign3First.appendChild(labelAssign3First);
divAssign3First.appendChild(price);

divAssign3Last.appendChild(labelAssign3Last);
divAssign3Last.appendChild(result);

form3.appendChild(divAssign3First);
form3.appendChild(divAssign3Last);
form3.appendChild(submit3);

document.body.appendChild(form3);

form3.addEventListener("submit", function(event) {
  event.preventDefault();
  console.log("Assignment 3");
  let moms = Number(price.value) * 0.25;
  let rabat = Number(price.value) * 0.10;
  result.value = Number(price.value) + moms - rabat;
  console.log("The result of adding VAT (moms 25%) and subtracting discount (rabat 10%) is: " + result.value);
});

// Assignment 4: Creates a form with an email input where the user can enter an email address. Also a submit button. The input should be validated when the form is submitted. If the email address is invalid, a popup box should be displayed with an error message. If the email address is valid, a popup box should be displayed with a success message.

let form4 = document.createElement("form");
form4.setAttribute("id", "assignment4Form");

let divAssign4First = document.createElement("div");
let labelAssign4First = document.createElement("label");
labelAssign4First.textContent = "Email: ";
let email = document.createElement("input");
email.setAttribute("type", "email");

let submit4 = document.createElement("input");
submit4.setAttribute("type", "submit");

divAssign4First.appendChild(labelAssign4First);
divAssign4First.appendChild(email);

form4.appendChild(divAssign4First);
form4.appendChild(submit4);

document.body.appendChild(form4);

form4.addEventListener("submit", function(event) {
  event.preventDefault();
  console.log("Assignment 4");
  // The email address is invalid if it doesn't contain an "@" or a "."
  // It is also invalid if there is less than 2 characters before the "@".
  if (email.value.indexOf("@") == -1 || email.value.indexOf(".") == -1 || email.value.indexOf("@") < 2){
    alert("The email address is invalid!");
    console.log("The email address is invalid!");
  }
  else {
    alert("The email address is valid!");
    console.log("The email address is valid!");
  }
});