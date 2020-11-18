using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WeekOneChallenges
{
    [TestClass]
    public class Week1
    {
        [TestMethod]
        public void DisplayEachCharacterInName()
        {
            string name = "Supercalifragilisticexpialidocious";
            foreach (char letter in name)
            {
                Console.WriteLine(letter);

            }
        }


        [TestMethod]
        public void IfIWriteIElseNotAnI()
        {    
            string name= "Supercalifragilisticexpialidocious";
            foreach (char letter in name)
            {
                if (letter == 'i')
                {
                    Console.WriteLine('i');
                }
                else
                {
                    Console.WriteLine("Not an i.");
                }
            }
        }


        [TestMethod]
        public void WriteNumberofCharactersInName()
        {
            string name = "Supercalifragilisticexpialidocious";
            int numberOfLetters = 0;
            foreach (char letter in name)
            {
                Console.WriteLine(numberOfLetters++);
            }
        }


        [TestMethod]
        public void NameAgeVariables()
        {
            string firstName = "Amber";
            string lastName = "Ying";
            int myAge = 41;
            {
                Console.WriteLine(firstName + " " + lastName + " " + myAge);
            }
        }


        [TestMethod]
        public void BookMovieArray()
        {
            {
                string[] bookMovieArray = {"The Shining", "The Wiz", "Becoming", "Guns, Germs, and Steel"};
                Console.WriteLine(bookMovieArray);
            }
        }

        [TestMethod]
        public void bookMovieArrayTwo() //Array written to console
        {
            {
                string[] bookMovieArrayTwo = new string[] {"The Shining", "The Wiz", "Becoming", "Guns, Germs, and Steel"};
                Console.WriteLine(bookMovieArrayTwo[0]);
                Console.WriteLine(bookMovieArrayTwo[1]);
                Console.WriteLine(bookMovieArrayTwo[2]);
                Console.WriteLine(bookMovieArrayTwo[3]);
            }

        }

        [TestMethod]
        public void DateTimeTest()
        {
            {
                DateTime now = DateTime.Now;
                Console.WriteLine(now);
            }

        }


        [TestMethod]
        public void ListOfDatesTest()
        {
            {
                DateTime now = DateTime.Now;                  
                List<string> listOfDates = new List<string>(); 
                listOfDates.Add("October 10, 2020");            
                listOfDates.Add("February 5, 2020");
                listOfDates.Add("October 10, 2008");
                listOfDates.Add("February 5, 2008");
                listOfDates.Add("May 9, 2004");
                Console.WriteLine(now);
                Console.WriteLine(listOfDates[0]);
                Console.WriteLine(listOfDates[1]);
                Console.WriteLine(listOfDates[2]);
                Console.WriteLine(listOfDates[3]);
                Console.WriteLine(listOfDates[4]);
            }
        }

        [TestMethod]
        public void AgePlusSeven()
        {
            {
                int age = 41;
                Console.WriteLine(age + 7);
                Console.WriteLine(age - 7);
                Console.WriteLine(age * 7);
                Console.WriteLine(age / 7);
                Console.WriteLine(age % 7);
            }
        }

        [TestMethod]
        public void HowMuchSleep()
        {
            {
                int hoursSlept = 7;

                Console.WriteLine("How many of hours of sleep did you get?");

                if (hoursSlept >= 10) 
                {
                    Console.WriteLine("Wow that's a lot of sleep!");
                }

                else if (hoursSlept > 8 && hoursSlept < 10)
                { 
                    Console.WriteLine("You should be pretty rested.");
                }

                else if (hoursSlept > 4 && hoursSlept < 8)
                {
                    Console.WriteLine("Bummer!");
                }

                else
                {
                    Console.WriteLine("Oh man, get some sleep!");
                }
 
            }
        }

        [TestMethod]
        public void SwitchHowWasYourDay()

        {
            string yourDay = "Great";

            switch (yourDay)
            {
                case "Great":
                    Console.WriteLine("My day was great!");
                    break;

                case "Good":
                    Console.WriteLine("My day was good; nothing special.");
                    break;

                case "Okay":
                    Console.WriteLine("My day was okay. I've had better.");
                    break;

                case "Bad":
                    Console.WriteLine("My day was bad. So much went wrong!");
                    break;

                case ":(":
                    Console.WriteLine("I'm sorry.");
                    break;

                default:
                    Console.WriteLine("Nothing to say.")
            }

        }
    } 
}
