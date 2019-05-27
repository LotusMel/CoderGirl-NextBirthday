using System;

namespace NextBirthday
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("When is your birthday?");
            DateTime myBirthday = DateTime.Parse(Console.ReadLine());
            DateTime nextYear = myBirthday.AddYears(1);
            Console.WriteLine(NextBirthdayDay(myBirthday));
            Console.ReadLine();
        }

        public static string NextBirthdayDay(DateTime nextYear)
        {
            return nextYear.DayOfWeek.ToString();
        }
    }
}
