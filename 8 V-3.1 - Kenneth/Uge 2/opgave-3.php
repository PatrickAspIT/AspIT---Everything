<!DOCTYPE html>
<html lang="en">
<head>
  <meta charset="UTF-8">
  <meta http-equiv="X-UA-Compatible" content="IE=edge">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>PHP</title>
</head>
<body>
  
  <?php
    // Task 3
    echo "Hello World! <br>";

    echo "THIS IS THE START OF TASK 3 <br>";

    // Assignment A
    $string = "the quick brown fox jumped over the lazy dog";

    // Assignment B
    $upperCase = strtoupper($string);
    echo $upperCase . "<br>";

    // Assignment C
    $upperFirst = ucfirst($string);
    echo $upperFirst . "<br>";

    // Assignment D
    $upperWords = ucwords($string);
    echo $upperWords . "<br>";

    // Assignment E
    if (str_contains($string, "fox")) {
      echo "The string contains 'fox' <br>";
    } else {
      echo "The string does not contain 'fox' <br>";
    }

    // Assignment F
    $stringMail = "halu@aspit.dk";
    $mailName = strtok($stringMail, "@");
    echo $mailName . "<br>";

    // Assignment G
    $passwordString = "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZabcefghijklmnopqrstuvwxyz";

    // Assignment G.1
    $passwordLength = 8;

    function generatePassword($passwordString, $passwordLength) {
      $password = substr(str_shuffle($passwordString), 0, $passwordLength);
      return $password;
    }

    // Assignment G.2
    echo generatePassword($passwordString, $passwordLength) . "<br>";

    // Assignment H
    function isPalindrome($string){
      // Remove spaces and convert string to lowercase
      $cleanString = strtolower(str_replace(' ', '', $string));

      // Reverse the string
      $reverseString = strrev($cleanString);

      // Check if the string is a palindrome
      if ($cleanString == $reverseString) {
        echo $string . "is a palindrome <br>";
      }
    }

    $stringQuestion = "faraf";
    isPalindrome($stringQuestion);
  ?>  
  
</body>
</html>