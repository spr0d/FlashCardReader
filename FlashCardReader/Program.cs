using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FlashCardReader
{
    class Program
    {
        static void Main(string[] args)
        {
            string action;
            string textFile;

            Console.WriteLine("Welcome to FlashCards! What would you like to do? 'Import' card library or 'Review' cards");

            action = Console.ReadLine();

            if (action.Equals("Import"))
            {
                Console.WriteLine("Reading file...");
                // Learn how to read from a file
            }
            else if (action.Equals("Review"))

            {
                Console.WriteLine("How would you like to review, 'Ordered' or 'Random'?  Typing 'New' will let you import a new card library");
                action = Console.ReadLine();
                //Keep flash cards ordered to display
                if (action.Equals("Ordered"))
                {
                    Console.WriteLine("Type 'Flip' to see the other side or 'Next' to view the next card. Type 'New file' to import different a different set of cards.");
                    action = Console.ReadLine();
                    // Check how user wants to proceed
                    return;
                }
                // "shuffle" flash cards.... need to create a function() for this.
                else if (action.Equals("Random"))
                {
                    //Displays first card's Front value and asks user input
                    Console.WriteLine("Type 'Flip' to see the other side or 'Next' to view the next card.");
                    // Check how user wants to proceed
                    action = Console.ReadLine();
                    // Create flip function() which will return the Back value
                    // Create next function() to display the next card's Front value
                    // Check how user wants to proceed and respond again
                    return;
                }
                else if (action.Equals("New"))
                {
                    // Learn how to loop back up to effectively start over
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
