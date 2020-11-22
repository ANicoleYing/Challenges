using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekTwoChallenges
{
    class Greeter
    {

        public string SayHello(string Name)
        {
            string Greeting = "Hello " + "Oliver";
            return Greeting;
        }


        public string SayFarewell(string Name)
        {
            string Farewell = ("Until we meet again, " + "Oliver");
            return Farewell;
        }


        public string TimeOfDayGreeting(string Greeting)
        {
            string GoodEvening = ("Good eveniing!");
            return GoodEvening;
        }

    }
}
