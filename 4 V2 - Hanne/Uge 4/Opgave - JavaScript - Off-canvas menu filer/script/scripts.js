"use strict";

// // Changes between the two images for the menu icon when clicked

// Get the menu icons
let menuIcons = document.querySelectorAll("#menu-icon img");

// Add click event listener to each icon
menuIcons.forEach((icon) => {
    icon.addEventListener("click", () => {
        
        // Toggle the visibility of each icon
        menuIcons.forEach((icon) => {
            icon.classList.toggle("hidden");
        });
    });
});