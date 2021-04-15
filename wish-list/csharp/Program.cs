// create a function of wishes that logs your wishes to the console
// there's a list of wishes
// there's a for loop that loops through each wish and prints it to the console

// Person ronny = new Person("Ronny", new DateTime(2000, 4, 1), new List<string> { "wrastlin'"} );
// Person june = new Person("June", new DateTime(1988, 10, 31), new List<string> { "carpentry", "animal husbandry"} );
// Person selam = new Person("Selam", new DateTime(1994, 5, 22), new List<string> { "opera", "juggling", "skeet shooting"} );

// List<Person> people = new List<Person>() { ronny, salam };
// people.Add(june);
using System.Collections.Generic;
using System.Linq;
using System;

namespace wishWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("My wishes...");

            List<string> wishes = new List<string>() 
            {
              "An original eight track of William Shatner's 'Lucy in the Sky with Diamonds'",
              "The ability to think of interesting wishes on short notice",
              "A washtub of Skittles",
              "World peace, but not the kind of world peace where all the humans are removed from existence",
              "A TV that is NOT internet-capable",
              "The ability to fly, but, like, really fast...not just, like, how fast I can walk, but, like, fast, you know?"
            };

            foreach (string wish in wishes)
            {
              Console.WriteLine($"{wish}");
            }
        }
    }
};

// Console.WriteLine("text");

// Wish eighttrack = new Wish("An original eight track of William Shatner's 'Lucy in the Sky with Diamonds'");
// Wish shortnotice = new Wish("The ability to think of interesting wishes on short notice");
// Wish skittles = new Wish("A washtub of Skittles");
// Wish worldpeace = new Wish("World peace, but not the kind of world peace where all the humans are removed from existence");
// Wish tv = new Wish("A TV that is NOT internet-capable");
// Wish flight = new Wish("The ability to fly, but, like, really fast...not just, like, how fast I can walk, but, like, fast, you know?");

// List<Wish> wish = new List<Wish>() { eighttrack, shortnotice, skittles, worldpeace, tv, flight };

// List<Wish> wishes = new List<Wish>() 
//   {
//     "An original eight track of William Shatner's 'Lucy in the Sky with Diamonds'",
//     "The ability to think of interesting wishes on short notice",
//     "A washtub of Skittles",
//     "World peace, but not the kind of world peace where all the humans are removed from existence",
//     "A TV that is NOT internet-capable",
//     "The ability to fly, but, like, really fast...not just, like, how fast I can walk, but, like, fast, you know?"

//   };

//   foreach (string wish in wishes)
//   {
//     Console.WriteLine($"{wish}");
//   }

// for (int i=0; i<GetAllWishes.length; i++)
// {
//     Console.WriteLine($"The number is {i}");
// }