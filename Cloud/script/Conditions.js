"use strict";

// OPGAVE 1 - Største tal
let firstNumber = prompt("Indtast et tal!");
let secondNumber = prompt("Indtast et tal igen!");

if (firstNumber > secondNumber)
{
  window.alert("Største nummer: " + firstNumber);
}
else 
{
  window.alert("Største nummer: " + secondNumber);
}

// OPGAVE 2 - Mindste tal
let thirdNumber = prompt("Indtast et tal!");
let fourthNumber = prompt("Indtast et tal igen!");
let fifthNumber = prompt("Indtast et tal igen, igen!");

if (thirdNumber < fourthNumber && thirdNumber < fifthNumber)
{
  window.alert("Mindste nummer: " + thirdNumber);
}
else if (fourthNumber < thirdNumber && fourthNumber < fifthNumber)
{
  window.alert("Mindste nummer: " + fourthNumber);
}
else 
{
  window.alert("Mindste nummer: " + fifthNumber);
}

// OPGAVE 3 - Lige eller ulige
let sixthNumber = prompt("Indtast et tal!");

if (sixthNumber % 2 == 0)
{
  window.alert("Du har indtastet et lige nummer: " + sixthNumber);
}
else 
{
  window.alert("Du har indtastet et ulige nummer: " + sixthNumber);
}

// OPGAVE 4 - Karakterer
let grade = prompt("Indtast hvor mange rigtige du har fået i en opgave!");

if (grade == 0)
{
  window.alert("Din karakter er: -3");
}
else if (grade >= 1 && grade <= 10)
{ 
  window.alert("Din karakter er: 00");
}
else if (grade >= 11 && grade <= 20)
{ 
  window.alert("Din karakter er: 02");
}
else if (grade >= 21 && grade <= 40)
{ 
  window.alert("Din karakter er: 4");
}
else if (grade >= 41 && grade <= 55)
{ 
  window.alert("Din karakter er: 7");
}
else if (grade >= 56 && grade <= 70)
{ 
  window.alert("Din karakter er: 10");
}
else if (grade >= 71 && grade <= 80)
{ 
  window.alert("Din karakter er: 12");
}
else 
{
  window.alert("Du har indtastet en ugylding værdi!");
}

// OPGAVE 5 - Beregninger 
let seventhNumber = prompt("Indtast et tal!");

window.alert(seventhNumber + " ganget med sig selv er: " + (seventhNumber * 2));
window.alert("Kvadratroden af " + seventhNumber + " er: " + (Math.sqrt(seventhNumber)));
window.alert(seventhNumber + " opløftet i " + seventhNumber + ". potens er: " + (seventhNumber ** seventhNumber));

// OPGAVE 6 - Måneder og årstider
let d = new Date();

switch (d.getMonth())
{
  case 0:
    window.alert("Januar - Vinter");
    break;
  case 1:
    window.alert("Februar - Vinter");
    break;
  case 2:
    window.alert("Marts - Forår");
    break;
  case 3:
    window.alert("April - Forår");
    break;
  case 4:
    window.alert("Maj - Forår");
    break;
  case 5:
    window.alert("Juni - Sommer");
    break;
  case 6:
    window.alert("Juli - Sommer");
    break;
  case 7:
    window.alert("August - Sommer");
    break;
  case 8:
    window.alert("September - Efterår");
    break;
  case 9:
    window.alert("Oktober - Efterår");
    break;
  case 10:
    window.alert("November - Efterår");
    break;
  case 11:
    window.alert("December - Vinter");
    break;
  default:
    break;
}