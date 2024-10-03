"use strict";

// Assignment 1: When the button is clicked, log "Hello World!" to the console.
let assignment1Button = document.getElementById("assignment1");
assignment1Button.addEventListener("click", function() {
  console.log("Assignment 1: ");
  console.log("Hello World!");
});

// Assignment 2: When a list item is clicked, log the text of the list item to the console.
let listItems = document.querySelectorAll('#assignment2 li');

  listItems.forEach(item => {
      item.addEventListener('click', function() {
          alert('You clicked on: ' + item.textContent);
      });
  });

// Assignment 3: When the button is clicked, change the color of the div to yellow.
let assignment2Button = document.getElementById("assignment3");
let assignment3Div = document.getElementById("assignment3Div");

assignment2Button.addEventListener("click", function() {
  console.log("Assignment 3: ");
  console.log("Changed color of the div to yellow");
  assignment3Div.style.backgroundColor = "yellow";
});

// Assignment 4: When the button is clicked, change the color of the body to the color of the button.
let listButtons = document.querySelectorAll('#assignment4 button');

listButtons.forEach(button => {
  button.addEventListener('click', function() {
      console.log("Assignment 4: ");
      console.log("Changed color of the body to " + button.textContent);
      document.body.style.backgroundColor = button.textContent;
  });
});


// Assignment 5: When the button is clicked, depending if the div is visible or not, make it visible or hidden.
let assignment5Button = document.getElementById("assignment5");

// Problem: Seems to be working fine, but you have to click on the button once when you load the page, and then it works fine.
assignment5Button.addEventListener("click", function() {
  console.log("Assignment 5: ");
  console.log("Toggled visibility of the div");
  let assignment5Div = document.getElementById("assignment5Div");

  if (assignment5Div.style.display === "none") {
    assignment5Div.style.display = "block";
  } else {
    assignment5Div.style.display = "none";
  }
});