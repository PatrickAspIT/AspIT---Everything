"use strict";

// Select the gallery element
let gallery = document.querySelector('#gallery');

// Add event listener to the gallery
gallery.addEventListener('click', function(e) {
  // Check if the clicked element is an image
  if (e.target.nodeName === 'IMG') 
  {
    // Get the src attribute of the clicked image and split it into an array
    let source = e.target.src;
    let sourceSplit = source.split('_');

    // Create a new div element, give it the class 'overlay', and add it to the body
    let newDiv = document.createElement('div');
    newDiv.className = 'overlay';
    document.body.appendChild(newDiv);

    // Create a new image element and set its src attribute to the second element of the split array from the source of the clicked image and add it to the new div
    let newImage = document.createElement('img');
    newImage.src = './img/' + sourceSplit[1];
    newDiv.appendChild(newImage);

    // Prevent click propagation when clicking on the image
    newImage.addEventListener('click', function(event) {
      event.stopPropagation();
    });
  }
});
    
// // Remove overlay when clicked
document.body.addEventListener('click', function(e) {
  if (e.target.className === 'overlay') {
    e.target.remove();
  }
});