MobileImageSlider();



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
        Times.src = "../img/bars-solid-white.png";
        Bars.src = "../img/times-solid-white.png";

        Nav.style.display = "block";
 }

    else {
        Times.src = "../img/times-solid-white.png";
        Bars.src = "../img/bars-solid-white.png";

        Nav.style.display = "none";
    }

    
})

// Mikael: Submenu script for mobile
let Arrow = document.querySelector(`.arrow`);
let ArrowImage = Arrow.querySelector(`img`);
let SubMenu = document.querySelector(`.Submenu`);

Arrow.addEventListener("click", function()
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
    
            
})


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