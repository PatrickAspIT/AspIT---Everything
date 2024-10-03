"use strict"; // Activates strict mode

// Function to start the game
function startGame()
{
  let userName = prompt("Indtast dit navn:");

  // Check if the user has entered a name
  if (userName)
  {
    // Welcome message
    let welcome = confirm("Hej " + userName + ". Er du klar til at spille?");
  
    if (welcome == true)
    {
      let score = 0;
      // Question 1
      let question1 = prompt("Spørgsmål 1:\nHvad er 3 * 7?");
      if (question1 == 21)
      {
        alert("Korrekt");
        let answer1 = "Spørgsmål 1: Korrekt";
        score++;
      }
      else 
      {
        alert("Forkert");
        let answer1 = "Spørgsmål 1: Forkert";
      }
      // Question 2
      let question2 = prompt("Spørgsmål 2:\nHvad er 13 * 10?");
      if (question2 == 130)
      {
        alert("Korrekt");
        let answer2 = "Spørgsmål 2: Korrekt";
        score++;
      }
      else 
      {
        alert("Forkert");
        let answer2 = "Spørgsmål 2: Forkert";
      }
      // Question 3
      let question3 = prompt("Spørgsmål 3:\nHvad er 4 % 2?");
      if (question3 == 0)
      {
        alert("Korrekt");
        let answer3 = "Spørgsmål 3: Korrekt";
        score++;
      }
      else 
      {
        alert("Forkert");
        let answer3 = "Spørgsmål 3: Forkert";
      }
      // Question 4
      let question4 = prompt("Spørgsmål 4:\nHvad er Danmarks hovedstad?");
      if (question4 == "København")
      {
        alert("Korrekt");
        let answer4 = "Spørgsmål 4: Korrekt";
        score++;
      }
      else 
      {
        alert("Forkert");
        let answer4 = "Spørgsmål 4: Forkert";
      }
      // Question 5
      let question5 = prompt("Spørgsmål 5:\nHvad er dit navn?");
      if (question5 == userName)
      {
        alert("Korrekt");
        let answer5 = "Spørgsmål 5: Korrekt";
        score++;
      }
      else 
      {
        alert("Forkert");
        let answer5 = "Spørgsmål 5: Forkert";
      }
  
      // SHOW RESULT
      let result = document.querySelector('#result'); 
      result.innerHTML = '<h2>Samlet score for ' + userName + ': ' + score +'</h2>';
      result.innerHTML += answer1 + '<br>'; 
      result.innerHTML += answer2 + '<br>'; 
      result.innerHTML += answer3 + '<br>';
      result.innerHTML += answer4 + '<br>';
      result.innerHTML += answer5;
    }
  }
}