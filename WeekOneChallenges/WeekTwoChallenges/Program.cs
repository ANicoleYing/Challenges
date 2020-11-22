using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekTwoChallenges
{
    class Program
    {
        static void Main(string[] args)
        {

            Greeter GreeterTwo = new Greeter();
            GreeterTwo.SayHello();
            GreeterTwo.SayFarewell();
            GreeterTwo.TimeOfDayGreeting();

            Console.ReadLine();
        }
    }
}
