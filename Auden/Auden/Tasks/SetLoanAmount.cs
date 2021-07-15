using OpenQA.Selenium;
using System;
using System.Threading;

namespace Auden.Tasks
{
    public class SetLoanAmount : ITask
    {

        int loanAmount;

        public void PerformAs(User user)
        {
            Thread.Sleep(5000);
            int increments = (loanAmount - 200) / 10;


            IWebElement element = user.driver.FindElement(By.Name("amount"));

            if (increments >= 0)
            {
                for (int i = 0; i < increments; i++)
                {
                    Thread.Sleep(1000);
                    element.SendKeys(Keys.ArrowRight);
                }
            }
            else
            {
                for (int i = 0; i < Math.Abs(increments); i++)
                {
                    Thread.Sleep(1000);
                    element.SendKeys(Keys.ArrowLeft);
                }
            }


        }

        public static SetLoanAmount To(int loanAmount) => new SetLoanAmount(loanAmount);

        public SetLoanAmount(int loanAmount) => this.loanAmount = loanAmount;
    }
}