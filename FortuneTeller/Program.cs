using System;

namespace NextBirthday
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("When is your birthday?");
            DateTime myBirthday = DateTime.Parse(Console.ReadLine());
            NextBirthdayDay(myBirthday);
        }
        // TODO: Create a method that takes the date someone was born and returns the name of the day on their next birthday.
        public static string NextBirthdayDay(DateTime myBirthday)
        {
            Console.WriteLine("Your birthday will be on a {0} this year and on a {1} next year", 
                myBirthday.DayOfWeek, myBirthday.AddYears(1).DayOfWeek);
            return Console.ReadLine();
        }
    }
}
