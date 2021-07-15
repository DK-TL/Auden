using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Auden.Observations
{
    public class FirstRepaymentDay : IObservation
    {
        string day;
        public bool CanBeSeen(User user)
        {
            String str = user.driver.FindElement(By.CssSelector("Span[class='loan-schedule-tab-content-text-1atLjYrkN1']")).Text;
            String retrievedDay = str.Substring(0, str.IndexOf(' ')).ToLower();
            return (retrievedDay == day);
        }

        public FirstRepaymentDay(string day)
        {
            this.day = day;
        }

        public static FirstRepaymentDay IsAFriday()
        {
            return new FirstRepaymentDay("friday");
        }
    }
}
