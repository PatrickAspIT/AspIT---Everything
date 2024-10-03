"use strict";

// This is a comment



// If the window width is greater than or equal to 1000px
if (window.innerWidth >= 1000)
{
  lightBox();
  DesktopImageSlider()
  let BannerCheck = document.querySelector("#banner")
  if (BannerCheck != null) {
    slideShow();
  }
}
else if (window.innerWidth >= 1000 && window.location.pathname == "/index.html" || window.location.pathname == "/webshop.html" || window.location.pathname == "/contact.html")
{
  console.log("test")
  slideShow();
}
// If the windows with is less than 1000px
else
{
  MobileImageSlider();
}

// Patrick - LightBox for desktop
function lightBox()
{
  let imageLightBox = document.querySelectorAll(".imageLightBox");

  // When an image is clicked, a lightBox will be created
  imageLightBox.forEach(image => {
    image.addEventListener("click", function() {
      let lightBox = document.createElement("div");
      lightBox.classList.add("lightBox");
      // The image that was clicked will be displayed in the lightBox
      lightBox.innerHTML = `<img src="${this.src}" alt="${this.alt}">`;
      document.body.appendChild(lightBox);

      // When the lightBox is clicked, it will be removed
      lightBox.addEventListener("click", function() {
        lightBox.remove();
      });
    });
  });
}


// Patrick - Slideshow Banner
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

// Noah: Image-slider for mobile
// If there is time add a transition to the images
function MobileImageSlider() {
  let ImageContainer = document.querySelector('#Image-Slider-Mobile');
  let Images = ImageContainer.querySelectorAll('img');
  let currentSlide = 0;   
  Images[currentSlide].classList.add('Active-Slider-Image');  
  setInterval(() => {
     Images[currentSlide].classList.remove('Active-Slider-Image');
     if (currentSlide + 1 >= Images.length) {
        currentSlide = 0;
     }
     else {
        currentSlide = (currentSlide + 1);   
     }      
     Images[currentSlide].classList.add('Active-Slider-Image');     
  }, 3000);
}

// Patrick - Image-slider for desktop
function DesktopImageSlider()
{
  let images = document.querySelectorAll('#Image-Slider-Mobile img');

  if (images.length > 4)
  {
    let overImages = images.length - 4;
    let hiddenArray = [overImages];

    // Gives all images besides the first 4 the class "imageSlideHide"
    for (let i = 0; i < overImages; i++)
    {
      images[i + 4].classList.add("imageSlideHide");
      hiddenArray[i] = i + 4;
    }

    let intervalImageSlider = window.setInterval(changeHide, 3000);

    // Function that changes the class "imageSlideHide" to the previous image(s) in the array
    function changeHide()
    {
      
      // Removes the class "imageSlideHide" from the first image in the array
      images[hiddenArray[0]].classList.remove("imageSlideHide");

      // For each of the values in the array, give it the value of the next index in the array
      for (let i = 0; i <= hiddenArray.length - 1; i++)
      {
        hiddenArray[i] = hiddenArray[i + 1];
      }

      if (hiddenArray[hiddenArray.length - 2] == images.length - 1)
      {
        hiddenArray[hiddenArray.length - 1] = 0;
      }
      else
      {
        hiddenArray[hiddenArray.length - 1] = hiddenArray[hiddenArray.length - 2] + 1;
      }
      images[hiddenArray[hiddenArray.length - 1]].classList.add("imageSlideHide");

    }
  }

  
}

//Mikael: Hamburger menu script for mobile
let Nav = document.querySelector(`.navigation`);
let HamburgerMenu = document.querySelector(`#HamburgerMenu`);
let Bars = document.querySelector(`#HamburgerOpen`);
let Times = document.querySelector(`#HamburgerClose`);

HamburgerMenu.addEventListener("click", function()
{
    console.log("test1")
    if(Times.src.match('./img/times-solid-white.png') && Bars.src.match('./img/bars-solid-white.png')) {
        console.log("test")
        Times.src = "./img/bars-solid-white.png";
        Bars.src = "./img/times-solid-white.png";

        Nav.style.display = "block";
 }

    else {
        Times.src = "./img/times-solid-white.png";
        Bars.src = "./img/bars-solid-white.png";

        Nav.style.display = "none";
    }

    
})

// Mikael: Submenu script for mobile
let Arrow = document.querySelector(`.arrow`);
let ArrowImage = document.querySelector(`.ArrowImage`);
let SubMenu = document.querySelector(`.Submenu`);

function SubMenuOpen()
{
    if(SubMenu.style.display === "block") 
    {
        SubMenu.style.display = "none";

        ArrowImage.style.transform = "rotate(90deg)"
    }
    else
    {
        SubMenu.style.display = "block";
        ArrowImage.style.transform = "rotate(0deg)"
    }
    
            
}