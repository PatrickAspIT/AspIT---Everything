"use strict";

// Create a function that is called every three seconds that changes the src of an image element. There should also be dots at the bottom of the image that indicate which image is being shown. The dots should change as the image changes.

// Create an array of images
// Needs to add new images to the array and the dots should be created dynamically
let images = [
  "bmw1.jpg",
  "bmw2.jpg",
  "bmw3.jpg"
]

let amountOfImages = images.length;
let currentImage = 0;

let delay = 3000;
let img = document.getElementById("mainImage");

// Create dots for each image in the array
for (let i = 0; i < amountOfImages; i++)
{
  let dot = document.createElement("span");
  dot.id = "dot" + i;
  dot.classList.add("dot");
  document.getElementById("dots").appendChild(dot);
}
let previousDot = document.getElementById("dot" + currentImage);

// Add event listeners to the dots and change the image and dots accordingly
let dots = document.getElementById("dots").children;
for (let i = 0; i < amountOfImages; i++)
{
  dots[i].addEventListener("click", function() {
    saveDot();

    // Sets the current image to the index of the dot that was clicked on
    currentImage = i;

    imageSrc();

    delay = 3000;
  });
}

// Create arrows on the left and right side of the image
let leftArrow = document.createElement("span");
leftArrow.classList.add("arrow");
leftArrow.classList.add("left");

let rightArrow = document.createElement("span");
rightArrow.classList.add("arrow");
rightArrow.classList.add("right");

document.body.appendChild(leftArrow);
document.body.appendChild(rightArrow);

// Add event listeners to the arrows and change the image and dots accordingly
leftArrow.addEventListener("click", function() {
  saveDot();

  // If currentImage is 0, set it to the last image in the array. If not, subtract 1 from currentImage.
  if (currentImage == 0)
    currentImage = amountOfImages - 1;
  else
    currentImage--;

  imageSrc();

  delay = 999999;
});

rightArrow.addEventListener("click", function() {
  saveDot();

  // If currentImage is the last image in the array, set currentImage to 0. If not, add 1 to currentImage.
  if (currentImage == amountOfImages - 1)
    currentImage = 0;
  else
    currentImage++;
  
  imageSrc();

  delay = 999999;
});

slideshowSlider();

// Function that changes the image and dots every 3 seconds
function slideshowSlider() 
{
  saveDot();

  imageSrc();

  // If the current image is less than the amount of images, add 1 to the current image. If not, set the current image to 0
  if (currentImage < amountOfImages - 1)
    currentImage++;
  else
    currentImage = 0;
  
  // Calls the function again after 3 seconds
  setTimeout(slideshowSlider, delay);
}

// Saves the previous dot and sets it to lightgrey
function saveDot()
{
  previousDot.classList.remove("dotDarkGrey");
  previousDot = document.getElementById("dot" + currentImage);
}

// Gives the image a src from the array and sets the current dot to darkgrey
function imageSrc()
{
  img.src = images[currentImage];
  let currentDot = document.getElementById("dot" + currentImage);
  currentDot.classList.add("dotDarkGrey");
}