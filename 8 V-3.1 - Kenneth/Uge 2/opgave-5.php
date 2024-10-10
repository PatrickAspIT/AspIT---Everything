<!DOCTYPE html>
<html lang="en">
<head>
  <meta charset="UTF-8">
  <meta http-equiv="X-UA-Compatible" content="IE=edge">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <link rel="stylesheet" href="./css/style.css">
  <title>PHP</title>
</head>
<body>
  
  <?php
    // Task 5

    echo "START OF TASK 5 <br>";

    // Assignment 2 & 3
    $students = ["patrick", "chris", "aske", "berkant", "esben", "nicklas", "alex", "rune"];
    $find = "berkant";

    function findPosition($students, $find) {
      $position = array_search($find, $students, true);

      // Check if the student is in the array
      if ($position === false) {
        $text = ucfirst($find) . " is not in the array";
      }
      else {
        $text = ucfirst($find) . " is in array position: " . $position . "<br>";
      }

      return $text;
    }

    echo findPosition($students, $find);

    // Assignment 4
    $shortMonths = ["februar" => 28, "april" => 30, "juni" => 30, "september" => 30, "november" => 30];
    $longMonths = ["januar" => 31, "marts" => 31, "maj" => 31, "juli" => 31, "august" => 31, "oktober" => 31, "december" => 31];    
  ?>  

<div class="container">
        <div class="column">
            <h2>Short Months</h2>
            <ul>
                <?php
                    foreach ($shortMonths as $month => $days) {
                        echo "<li>$month: $days days</li>";
                    }
                ?>
            </ul>
        </div>
        <div class="column">
            <h2>Long Months</h2>
            <ul>
                <?php
                    foreach ($longMonths as $month => $days) {
                        echo "<li>$month: $days days</li>";
                    }
                ?>
            </ul>
        </div>
    </div>

    <?php

    // Assignment 5.a
    $laerere = array(
      array(
      "fornavn" => "Hanne",
      "efternavn" => "Lund",
      "fag" => "Visualisering"
      ),
      array(
      "fornavn" => "Jens",
      "efternavn" => "Clausen",
      "fag" => "Softwarekonstruktion"
      ),
      array(
      "fornavn" => "Ronni",
      "efternavn" => "Hansen",
      "fag" => "Teknik"
      ),
      array(
      "fornavn" => "Ulf",
      "efternavn" => "Skaaning",
      "fag" => "AspIT-Lab"
      )
      );

    // Assignment 5.b
    echo "<pre>";
    print_r($laerere);
    echo "</pre>";

    // Assignment 5.c
    foreach ($laerere as $index => $laerer) { // Outer loop for each teacher
      echo "<strong>Lærer #" . ($index + 1) . ":</strong><br>";
      foreach ($laerer as $key => $value) { // Inner loop for each key-value pair
          echo ucfirst($key) . ": " . $value . "<br>";
      }
      echo "<br>"; // Add a line break between teachers
    }

    ?>
  
</body>
</html>