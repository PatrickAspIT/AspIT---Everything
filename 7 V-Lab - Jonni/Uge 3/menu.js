// Used to give background-color to menu after it has descended
window.addEventListener('scroll', function() {
  var menu = document.getElementById('menu');
  if (window.scrollY > 900) { // Change to the distance I want, around 900 seems good
      menu.classList.add('scrolled');
  } else {
      menu.classList.remove('scrolled');
  }
});