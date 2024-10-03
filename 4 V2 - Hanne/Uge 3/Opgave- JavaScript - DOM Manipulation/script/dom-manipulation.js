"use strict";

// Assignment 1 - Write #menu to console
let idMenu = document.querySelector(`#menu`);
console.dir(idMenu);

// Assignment 2 - Write .active to console
let classActive = document.querySelector(`.active`);
console.dir(classActive);

// Assignment 3 - Write all <h1> to console
let allH1 = document.querySelectorAll(`h1`);
console.dir(allH1);

// Assignment 4 - Write all <p> to console
let allP = document.querySelectorAll(`p`);
console.dir(allP);

// Assignment 5 - Write all <img> to console and set alt to "Billedet er underlagt copyright"
let allImg = document.querySelectorAll(`img`);
allImg.alt = `Billedet er underlagt copyright`;

// Assignment 6 - Change the innerText of the first <h1> to "Overskriften er udskiftet"
let mainHeader = document.querySelector(`h1`);
mainHeader.innerText = `Overskriften er udskiftet`;

// Assignment 7 - Add the class "title" to all <h1>
let newAllH1 = document.querySelectorAll(`h1`);

// Loop through all <h1> and add class "title"
for (let i = 0; i < newAllH1.length; i++) {
    newAllH1[i].classList.add(`title`);
}

// Assignment 8 - Write all <li> to console
let allLi = document.querySelectorAll(`li`);
console.dir(allLi);


// Assignment 9 - Create an unordered list with 3 items and append it to the element with the id "playground"
let idPlayground = document.querySelector(`#playground`);

// Create an unordered list element
var unorderedList = document.createElement("ul");

// Create three list item elements and add text content to each
var listItem1 = document.createElement("li");
listItem1.textContent = "Item 1";

var listItem2 = document.createElement("li");
listItem2.textContent = "Item 2";

var listItem3 = document.createElement("li");
listItem3.textContent = "Item 3";

// Append the list items to the unordered list
unorderedList.appendChild(listItem1);
unorderedList.appendChild(listItem2);
unorderedList.appendChild(listItem3);

idPlayground.appendChild(unorderedList);

// Assignment 10 - Find the 2 <img> elements and make them switch places
let newAllImg = document.querySelectorAll(`img`);

newAllImg[0].src  = `./img/bashar_al_assad.jpg`;
newAllImg[1].src  = `./img/flag-syria.png`;

// Assignment 11 - Find the two <p> elements and delete them
let pDelete1 = document.querySelector(`#deleteme`);
pDelete1.remove();
let pDelete2 = document.querySelector(`#deletemetoo`);
pDelete2.remove();