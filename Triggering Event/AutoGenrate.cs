using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triggering_Event
{
    public class AutoGenrate
    {
        public void generatePayments()
        {
                DateTime currentDate = DateTime.Now;
            int currentDay = currentDate.Day;
            string currentMonth = currentDate.ToString("MMMM");

            //Console.WriteLine($"Current Day: {currentDay}");
            //Console.WriteLine($"Current Month: {currentMonth}");
                int dueDay = 1;
                int lateDay = 10;
                if (currentDay >= dueDay && currentDay < 11 )
                {
                    Console.WriteLine("Hi, you can pay your bill.");
                }
                else if (currentDay > lateDay)
                {
                    Console.WriteLine("You are late! Please pay your bill as soon as possible.");
                }

                Console.WriteLine($"Current Day: {currentDay}");
                Console.WriteLine($"Current Month: {currentDate.ToString("MMMM")}");
            
        }
    }
}
