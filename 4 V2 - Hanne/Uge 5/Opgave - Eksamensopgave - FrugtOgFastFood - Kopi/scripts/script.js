"use strict";

// Used for mobile version of the site

// Menu icons
let navImg = document.querySelectorAll("header > img");
// nav menu
let navigation = document.querySelector("nav");

// Toggle hidden class on click of the menu icons
navImg.forEach(img => {
  img.addEventListener("click", () => {
    navigation.classList.toggle("animateNav");
    navigation.classList.toggle("hidden");
    navImg.forEach(img => {
      img.classList.toggle("animateIcons");
      img.classList.toggle("hidden");
    });
  });
});

// Used for desktop version of the site when the width is 1000px or greater (lightBox)

if (window.innerWidth >= 1000)
{
  let frontpageImg = document.querySelectorAll("#indexImg > article > .potentialLightBox");

  frontpageImg.forEach(img => {
    img.addEventListener("click", () => {
      let firstH4 = img.nextElementSibling
      let pText = firstH4.nextElementSibling;
      let secondH4 = pText.nextElementSibling;

      let lightBox = document.createElement("div");
      lightBox.classList.add("lightBox");

      let div = document.createElement("div");

      let lightBoxHead = document.createElement("h4");
      lightBoxHead.textContent = firstH4.textContent;

      let lightBoxText = document.createElement("p");
      lightBoxText.textContent = pText.textContent;

      let lightBoxPrice = document.createElement("h4");
      lightBoxPrice.textContent = secondH4.textContent;

      lightBox.innerHTML = `<img src="${img.src}" alt="${img.alt}">`;

      div.appendChild(lightBoxHead);
      div.appendChild(lightBoxText);
      div.appendChild(lightBoxPrice);
      lightBox.appendChild(div);

      document.body.appendChild(lightBox);
      lightBox.addEventListener("click", () => {
        lightBox.remove();
      });
    });
  });

  let fruitImg = document.querySelectorAll("#fruitSite > .potentialLightBox");

  fruitImg.forEach(img => {
    img.addEventListener("click", () => {
      let lightBoxCenter = document.createElement("div");
      lightBoxCenter.classList.add("lightBoxCenter");
      lightBoxCenter.innerHTML = `<img src="${img.src}" alt="${img.alt}">`;

      document.body.appendChild(lightBoxCenter);
      lightBoxCenter.addEventListener("click", () => {
        lightBoxCenter.remove();
      });
    });
  });

  let opskriftImg = document.querySelectorAll("#opskriftSection > article > .potentialLightBox");

  opskriftImg.forEach(img => {
    img.addEventListener("click", () => {
      let lightBoxCenter = document.createElement("div");
      lightBoxCenter.classList.add("lightBoxCenter");
      lightBoxCenter.innerHTML = `<img src="${img.src}" alt="${img.alt}">`;

      document.body.appendChild(lightBoxCenter);
      lightBoxCenter.addEventListener("click", () => {
        lightBoxCenter.remove();
      });
    });
  });
}

// Used for desktop version of the site except the "Juicer" site

if (document.body.classList.contains("widthMainFooter"))
{

  // <p> tag that contains the current img alt value
  let imgAlt = document.querySelector(".juiceSection > article > p:first-of-type");

  // All images in the juice section
  let juiceImgs = document.querySelectorAll(".juiceSection > article > a > img");

  // Every 3 seconds change the img that dosent have the class .juiceImgHide to the next img in the juiceImgs array. Start by giving every img beside the first the class.
  let i = 1;
  setInterval(() => {
    juiceImgs.forEach(img => {
      img.classList.add("juiceImgHide");
    });
    juiceImgs[i].classList.remove("juiceImgHide");
    imgAlt.textContent = juiceImgs[i].alt;
    i++;
    if (i === juiceImgs.length) {
      i = 0;
    }
  }, 2000);


  // Used to change the top value of the juiceSection depending on if the menu exists in the html or not
  let smallMenu = document.getElementById("smallMenu");
  let juiceSection = document.querySelector(".juiceSection");

  // If the menu exists in the html then the top value of the juiceSection will be 100px + 2.6rem else it will be 80px + 1.2rem
  if (smallMenu)
  {
    juiceSection.style.top = "calc(100px + 2.6rem)";
  }
  else 
  {
    juiceSection.style.top = "calc(80px + 1.2rem)";
  }
}