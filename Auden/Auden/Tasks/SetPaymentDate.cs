using System;
using System.Collections.Generic;
using System.Threading;
using OpenQA.Selenium;

namespace Auden.Tasks
{
    public class SetPaymentDate : ITask
    {

        int day;

        public void PerformAs(User user)
        {
            user.driver.FindElement(By.CssSelector($"button[data-recurrencetype='ABSOLUTEMONTHLY'][value='{day}']")).Click();

        }

        public static SetPaymentDate To(int day) => new SetPaymentDate(day);

        public static SetPaymentDate ToWeekendDay()
        {
            Thread.Sleep(2000);
            var startDate = DateTime.Now;
            var first = new DateTime(startDate.Year, startDate.Month, 1);
            List<int> weekends = new List<int>();
            for (int i = 0; i <= DateTime.DaysInMonth(startDate.Year, startDate.Month); i++)
            {
                var nextDay = first.AddDays(i);
                if (nextDay.DayOfWeek == DayOfWeek.Saturday || nextDay.DayOfWeek == DayOfWeek.Sunday)
                {
                    Console.WriteLine((int)Int32.Parse(nextDay.ToString("dd")));
                    weekends.Add((int)Int32.Parse(nextDay.ToString("dd")));
                }
            }


            return new SetPaymentDate(weekends[4]);
        }

        public SetPaymentDate(int day) => this.day = day;
    }
}
