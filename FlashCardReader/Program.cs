using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using FlashCardReader;

namespace FlashCardReader
{
    class Program
    {
        static void Main(string[] args)
        {
            string action;
            string relativePath = @"Lesson1.txt";
            string textFile;
            int count;
            string frontText, backText;
            char[] delimChars = {':' , '\n' };
            string[] sides;
            FlashCard[] flashCardLibrary;

            // Learn to request new file names from User
            Console.WriteLine("Welcome to FlashCardReader! What would you like to do? 'Import' card library, 'Review' cards or 'Quit'?");

            action = Console.ReadLine();
            if (action.Equals("Quit"))
            {
                return;
            }
            // Learn to check if the file exists
            else if (action.Equals("Import"))
            {
                Console.WriteLine("Reading file and creating flash cards...");
                // Read from the file and store
                textFile = System.IO.File.ReadAllText(relativePath);
                // Create array of information to add to FlashCard objects
                sides = textFile.Split(delimChars);
                // Create FlashCard objects from array
                count = 0;
                flashCardLibrary = new FlashCard[sides.Length];
                //// Test string array variables
                //Console.WriteLine(sides[2]);
                for (int i = 0; i < sides.Length; i += 2)
                {
                    frontText = sides[i];
                    i++;
                    backText = sides[i];
                    i--;
                    // Learn to assign variables to array of FlashCard objects
                    flashCardLibrary[count] = new FlashCard(frontText, backText);

                    // What's being assigned?
                    Console.WriteLine($"Front of a card: {frontText} Back of a card:{backText}");
                    count++;
                }
                
            }
            else if (action.Equals("Review"))
            {
                // Learn how to check if library was added

                // Currently only pulls from the one card library Lesson 1, will learn how to change the file's name on demand and implement later  'New <filename>'
                Console.WriteLine("How would you like to review, 'Ordered' or 'Random'?  Typing 'New' will let you import a new card library");
                    action = Console.ReadLine();
                    if (action.Equals("Ordered"))
                    {
                        //Start displaying cards, starting with the front of the first card
                        Console.WriteLine("Type 'Flip' to see the other side or 'Next' to view the next card.");
                        // Check how user wants to proceed
                        action = Console.ReadLine();
                        // Create flip function() which will return the Back value
                        // Create next function() to display the next card's Front value
                        // Check how user wants to proceed and respond again
                        return;
                    }

                    else if (action.Equals("Random"))
                    {
                        // "shuffle" flash cards.... need to create a function() for this.

                        // Displays first card's Front value and asks user input

                        // Give user options
                        Console.WriteLine("Type 'Flip' to see the other side or 'Next' to view the next card.");
                        // Check how user wants to proceed
                        action = Console.ReadLine();
                        // Create flip function() which will return the Back value
                        // Create next function() to display the next card's Front value
                        // Check how user wants to proceed and respond again
                        return;
                    }
                    // User input doesn't match available options
                    else
                    {
                        Console.WriteLine("Invalid command, please try again.");
                        action = Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid command, please try again.");
                }
                
        }
    
    }
}
