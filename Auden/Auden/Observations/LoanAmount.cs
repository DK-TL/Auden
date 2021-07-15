using OpenQA.Selenium;
using System;

namespace Auden.Observations
{
    public class LoanAmount : IObservation
    {
        int loanAmount;

        public bool CanBeSeen(User user)
        {
            string loanAmountString = user.driver.FindElement(By.CssSelector("p[data-testid='loan-amount-value']")).Text;
            string loanAmountStringNumber = loanAmountString.Substring(1, loanAmountString.Length - 1);
            int res = 0;
            bool parseSuccessful = int.TryParse(loanAmountStringNumber, out res);

            Console.WriteLine("the amount is: " + res);
            return loanAmount == res;

        }

        public static LoanAmount IsEqualTo(int amount) => new LoanAmount(amount);

        public LoanAmount(int amount) => loanAmount = amount;
    }
}