using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Auden.Observations
{
    public class LoanAmount : IObservation
    {
        int loanAmount;

        public bool CanBeSeen(User user)
        {
            String loanAmountString = user.driver.FindElement(By.CssSelector("p[data-testid='loan-amount-value']")).Text;
            String loanAmountStringNumber = loanAmountString.Substring(1, loanAmountString.Length - 1);
            int res = 0;
            bool parseSuccessful = int.TryParse(loanAmountStringNumber, out res);

            Console.WriteLine("the amount is: " + res);
            return loanAmount == res;

        }

        public static LoanAmount IsEqualTo(int amount)
        {
            return new LoanAmount(amount);
        }

        public LoanAmount(int amount)
        {
            loanAmount = amount;
        }
    }
}