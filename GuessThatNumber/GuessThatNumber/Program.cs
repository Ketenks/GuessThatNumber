﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessThatNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //FUNCTION CALLS
            Console.WriteLine("CALLING FUNCTIONS*******");
            Console.WriteLine();

            Console.WriteLine("Guess that Number!\nAnywhere from 1 to 100");
            GuessThatNumber("");

            //keeps conosle open
            Console.ReadKey();
        }
        //BEGIN FUNCTION DECLARATION

        static void GuessThatNumber(string input)
        {
            //declare function variables
            bool looping = true;
            Random randNumGen = new Random();
            int guessCount = 0;
            //this grabs a single instance of the random number generator
            int randNum = randNumGen.Next(1, 101);
            
                
            //infinite loop of user input
            while (looping)
            {
                //this needs to be in front of everything to set the input
                input = Console.ReadLine();

                //this is the validator of the input to see if it is a number or not
                if ("qwertyuiopasdfghjklzxcvbnm~`!@#$%^&*()_-+=QWERTYUIOP{}|[]\\ASDFGHJKL:;\"\'ZXCVBNM<>?,./".Contains(input))
                {
                    Console.WriteLine("Sorry, not a number.Try again.");
                    looping = false;
                    GuessThatNumber("");
                }

                
                //convert the correct input to a number
                    int number = Convert.ToInt32(input);

                //input has been set so add a guess
                    guessCount++;

                    //condition to compare the input with the randNum
                    if (number == randNum)
                    {
                        Console.WriteLine("Congrats you! You guessed it.");
                        Console.WriteLine("It took you " + guessCount + " guesses to get it.");
                        break;
                    }
                    else if (number > randNum && number - 10 <= randNum)
                    {
                        Console.WriteLine("Ach so close but too high.");
                    }
                    else if (number < randNum && number + 10 >= randNum)
                    {
                        Console.WriteLine("Hey...almost there but too low.");
                    }
                    else if (number < randNum)
                    {
                        Console.WriteLine("Too low you. Maybe another guess.");
                    }
                    else if (number > randNum)
                    {
                        Console.WriteLine("Too high. Way too high.");
                    }
                }


                //ask for new game
                Console.WriteLine("Would you like to play again?\nYes or No?");

                //create separate input for a new game
                string input2 = Console.ReadLine();

                //set up new game
                if (input2 == "Yes" ||input2 == "yes" || input2 == "Y" || input2 == "y")
                {
                    Console.WriteLine("Put in another guess.");
                    GuessThatNumber("");
                }
                else
                {

                }
            
        }
    }
}
