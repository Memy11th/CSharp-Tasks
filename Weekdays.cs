using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Five
{
    internal class Weekdays
    {
        enum Weekday
        {
            Monday,
            Tuesday,
            Wednesday ,
            Thursday,
            Friday ,
            Saturday ,
            Sunday
        }

        public void GetWeekDays()
        {
            Console.WriteLine("Weekdays are : ");
            foreach(Weekday day in Enum.GetValues(typeof(Weekday))){
                Console.WriteLine(day);
            };
        }
    }
}
