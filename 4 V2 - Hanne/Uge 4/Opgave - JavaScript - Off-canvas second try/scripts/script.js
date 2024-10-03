"use strict";

// Changes between the two images for the menu icon when clicked

// Get the menu icons
let menuIcons = document.querySelectorAll("#menu-icon img");
// Get the navigation menu
let navigation = document.querySelector("#navigation");
// Get the arrow icon
let arrow = document.querySelector(".arrow");
// Get the submenu ul
let submenu = document.querySelector("#showsubmenu ul");

// Add click event listener to each icon
menuIcons.forEach((icon) => {
    icon.addEventListener("click", () => {
    navigation.classList.toggle("slideNav");
    navigation.classList.toggle("hidden");
    // Toggle the visibility of each icon
    menuIcons.forEach((icon) => {
        icon.classList.toggle("hidden");
    });
    arrow.style.clipPath = "polygon(100% 50%, 0 0, 0 100%)";
    submenu.style.display = "none";
    });
});

let counter = 0;

// Add click event listener to the arrow icon
arrow.addEventListener("click", () => {
    // Change the arrow icon when clicked and display the submenu
    if (counter === 0) {
        arrow.style.clipPath = "polygon(50% 100%, 100% 0, 0 0)";
        counter++;
        submenu.style.display = "block";
    }
    // Change the arrow icon when clicked and hide the submenu
    else if (counter === 1){
        arrow.style.clipPath = "polygon(100% 50%, 0 0, 0 100%)";
        counter = 0;
        submenu.style.display = "none";
    }
});2
