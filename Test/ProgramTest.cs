using NextBirthday;
using System;
using Xunit;

namespace Test
{
    public class ProgramTest
    {
        [Fact]
        public void NextBirthdayDay_ThisYear()
        {
            int daysUntilMonday = (((int)DayOfWeek.Sunday - (int)DateTime.Today.DayOfWeek + 7) % 7) + 1;

            Assert.Equal("Monday", Program.NextBirthdayDay(DateTime.Today.AddDays(daysUntilMonday)));
        }

        [Fact]
        public void NextBirthdayDay_NextYear()
        {
            string answer = DateTime.Today.AddDays(-1).DayOfWeek.ToString();

            Assert.Equal(answer, Program.NextBirthdayDay(DateTime.Today.AddDays(-1)));
        }
    }
}
