using System;
using System.Collections.Generic;
using System.Linq;

// 1. make an array of insults
// 2. get a random number
// 3. write one function that does everything
// 4. make a while that stops at 3
// 5. random math function between 0 and the length of the array
// 6. print 1 random insult to the terminal

List<string> insults = new List<string>() 
{
  "You look like what morning breath smells like.",
  "If you tried to give me cpr I would probably throw myself back under water",
  "I am not a fan of you",
  "You think you're so special...and you are. The fact of your existence is nearly impossible to believe",
  "I'd rather walk than be on the same plane as you",
  "If I were given a million dollars to hang out with you...I would, but then I'd have to spend half of it on therapy",
  "Do you have to be so...like that?"
};

int randomNumber = new Random().Next(0, 6);

List<int> randomNumbers = new List<int>(){};

while (randomNumbers.Count < 3) {
  int singleRandomNum = new Random().Next(0, 6);
  if (!randomNumbers.Contains(singleRandomNum)) {
    randomNumbers.Add(singleRandomNum);
  }
}

// randomNumbers.ForEach(num => Console.WriteLine(num));

foreach (int randomNum in randomNumbers)
{
  Console.WriteLine(insults[randomNum]);
}

// int randomNumOne = randomNumber[0];

// foreach (int randomNum in randomNumber)
// {
//   Console.WriteLine(insults[randomNum]);
// }

// while (randomNum.Count < 3) 
// {
//   int singleRandomNum = new Random().Next(0, 7);
//   if (!randomNum.Contains(singleRandomNum)) {
//     randomNum.Add(singleRandomNum);
//   }
// }



// Function to "roll" a die
//  Generates a random number between 1 and 6
//  Constructs a new Die object with the random number as its value
// Die Roll()
// {
//     int dieValue = new Random().Next(1, 6);
//     Die die = new Die(dieValue);
//     return die;
// }