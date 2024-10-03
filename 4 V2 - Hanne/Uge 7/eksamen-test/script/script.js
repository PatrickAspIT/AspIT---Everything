"use strict";

// Patrick - Slideshow Banner
if (window.innerWidth >= 1000)
{
  slideShow();
}

function slideShow()
{
  let images = [
    "./img/Banner-1.jpg",
    "./img/Banner-2.jpg",
    "./img/Banner-3.jpg",
    "./img/Banner-4.jpg"
  ]

  let amountOfImages = images.length;
  let currentImage = 0;

  let delay = 3000;
  let interval = window.setInterval(slideshowBanner, delay);
  let banner = document.querySelector("#banner");
  let img = document.querySelector("#mainImage");
  console.log("Start: " + delay);

    // Create dots for each image in the array
  for (let i = 0; i < amountOfImages; i++)
  {
    let dot = document.createElement("span");
    dot.id = "dot" + i;
    dot.classList.add("dot");
    document.getElementById("dots").appendChild(dot);
  }

  // Adds eventlisteners the every dot
  let dots = document.getElementById("dots").children;
  for (let i = 0; i < amountOfImages; i++)
  {
    // When a dot is clicked, the current image will be set to the dot´s index
    dots[i].addEventListener("click", function() 
    {
      currentImage = i;
      img.src = images[currentImage];
      clearInterval(interval);
      delay = 10000;
      interval = window.setInterval(slideshowBanner, delay);
      img.classList.remove("animationBanner");
      updateDots();
    });
  }

  // Create arrows on the left and right side of the image
  let leftArrow = document.createElement("span");
  leftArrow.classList.add("bannerArrow");
  leftArrow.classList.add("left");

  let rightArrow = document.createElement("span");
  rightArrow.classList.add("bannerArrow");
  rightArrow.classList.add("right");

  banner.appendChild(leftArrow);
  banner.appendChild(rightArrow);

  // Updates the image and decreases ´currentImage´ to the previous in the array
  leftArrow.addEventListener("click", function() 
  {
    if (currentImage == 0)
    {
      currentImage = amountOfImages - 1;
    }
    else
    {
      currentImage--;
    }
        
    img.src = images[currentImage];

    updateDots();
    clearInterval(interval);
    delay = 10000;
    interval = window.setInterval(slideshowBanner, delay);
    img.classList.remove("animationBanner");
  });

  // Updates the image and increases ´currentImage´ to the next in the array
  rightArrow.addEventListener("click", function()
  {
    updateImage();

    clearInterval(interval);
    delay = 10000;
    interval = window.setInterval(slideshowBanner, delay);
    img.classList.remove("animationBanner");
  });
   
  slideshowBanner();
  // Function that changes the image and dots every 3 seconds
  function slideshowBanner()
  {
    clearInterval(interval);
    delay = 3000;
    interval = window.setInterval(slideshowBanner, delay);
    updateImage();

  }

  // Updates the image and increases ´currentImage´ to the next in the array
  function updateImage()
  {
    img.classList.add("animationBanner");
    img.src = images[currentImage];
    updateDots();

    // If the current image is less than the amount of images, add 1 to the current image
    // Else set the current image to 0
    if (currentImage < amountOfImages - 1)
    {
      currentImage++;
    }
    else
    {
      currentImage = 0;
    }
  }

  // Add the class "current" to the active dot and remove it from the previous dot
  function updateDots()
  {
    let dots = document.querySelectorAll(".dot");
    dots.forEach(dot => {
      dot.classList.remove("current");
    });
    dots[currentImage].classList.add("current");
  }
}