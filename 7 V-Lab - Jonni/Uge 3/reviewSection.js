// Used to change text for the reviewSection and change the color of the circle icons
document.addEventListener("DOMContentLoaded", function() {
  const reviews = [
      '"Jeg skulle have lavet min have, efter at have ombygget mit hus, og Viborg Planteservice klarede hele arbejdet, mens jeg var på golfbanen. <br><br>- John Bo Martens, Viborg"',
      '"Jeg skulle have ryddet op i min have, efter Oktober, og Viborg Planteservice klarede det hele, mens jeg var på arbejde.<br><br>- Timothy Nielsen, Fredericia"',
      '"Jeg skulle have nogen til at se efter mine træer, og Viborg Planteservice klarede det hele, mens jeg var på ferie.<br><br>- Sarah Jensen, Aarhus"',
  ];

  let currentReview = 0;

  function updateReview() {
    // Create a new paragraph element and set the review text
    const paragraph = document.createElement('p');
    paragraph.innerHTML = reviews[currentReview];

    // Get the review section and update its content with the new paragraph
    const reviewSection = document.getElementById('reviewBox');
    reviewSection.innerHTML = ''; // Clear any existing content
    reviewSection.appendChild(paragraph); // Append the new paragraph

    // Update the active circle
    document.querySelectorAll('.circle').forEach((circle, index) => {
        if (index === currentReview) {
            circle.classList.add('active');
        } else {
            circle.classList.remove('active');
        }
    });

    // Move to the next review, looping back to the first
    currentReview = (currentReview + 1) % reviews.length;
  }

  // Run the function immediately on page load
  updateReview();

  // Initialize the review cycle
  setInterval(updateReview, 15000); // Change every 15 seconds

  // Allow manual switching when clicking on the circles
  document.querySelectorAll('.circle').forEach((circle, index) => {
      circle.addEventListener('click', function() {
          currentReview = index;
          updateReview();
      });
  });
});