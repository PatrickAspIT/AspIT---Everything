"use strict";

// Create a menuItems object with the following key-value pairs
let menuItems = {
  Home: 'home.html',
  Products: 'products.html',
  Pricing: 'pricing.html',
  Vision: 'vision.html',
  About: 'about.html',
  Contact: 'contact.html'
};

// Create a nav element and set its class to "menu"
let navElement = document.createElement(`nav`);
navElement.classList.add(`menu`);

// Create a ul element
let ulElement = document.createElement(`ul`);

// Create a list item for each menu item
// Each list item has an a tag with the href set to the menu item's URL and the text set to the menu item's name
for (let menuItem in menuItems) 
{
  var liElement = document.createElement(`li`);
  var aElement = document.createElement(`a`);
  aElement.href = menuItems[menuItem];
  aElement.appendChild(document.createTextNode(menuItem));
  liElement.appendChild(aElement);
  ulElement.appendChild(liElement);
}

// Add the ul element to the nav element
navElement.appendChild(ulElement);

// Add the nav element to the body
document.body.appendChild(navElement);