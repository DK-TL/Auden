using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Auden;
using Auden.Tasks;
using Auden.Observations;
using OpenQA.Selenium.Interactions;
using System.Threading;

namespace Auden.Features
{
    [Binding]
    public class AudenLoansSteps
    {

        User user;

        public AudenLoansSteps(User user)
        {
            this.user = user;
        }


        [Given(@"I am on the auden short term loan page")]
        public void GivenIAmOnTheAudenShortTermLoanPage()
        {
            user.AttemptsTo(
                NavigateTo.URL("https://www.auden.com/short-term-loan")
                );
        }

        [When(@"I select a slider amount of (.*)")]
        public void WhenISelectASliderAmountOf(int amount)
        {
            user.AttemptsTo(
                  SetLoanAmount.To(amount));
        }


        [Then(@"I should see that the loan amount is equal to the slider amount")]
        public void ThenIShouldSeeThatTheLoanAmountIsEqualToTheSliderAmount()
        {
            user.ShouldSee(LoanAmount.IsEqualTo(370));
        }

        [When(@"I attempt to increment the slider to a position higher than (.*)")]
        public void WhenIAttemptToIncrementTheSliderToAPositionHigherThan(int p0)
        {
            user.AttemptsTo(
                SetLoanAmount.To(600));
        }

        [Then(@"I should see that the maximum amount is (.*)")]
        public void ThenIShouldSeeThatTheMaximumAmountIs(int amount)
        {
            user.ShouldSee(LoanAmount.IsEqualTo(amount));
        }

        [When(@"I attempt to increment the slider to a position lower than (.*)")]
        public void WhenIAttemptToIncrementTheSliderToAPositionLowerThan(int amount)
        {
            user.AttemptsTo(
                SetLoanAmount.To(amount - 100));
        }

        [Then(@"I should see that the minimum amount is (.*)")]
        public void ThenIShouldSeeThatTheMinimumAmountIs(int amount)
        {
            user.AttemptsTo(SetPaymentDate.To(10));
            user.ShouldSee(LoanAmount.IsEqualTo(amount));

        }

        [When(@"I set the repayment date to a weekend date")]
        public void WhenISetTheRepaymentDateToAWeekendDate()
        {
            Thread.Sleep(3000);
            user.AttemptsTo(SetPaymentDate.ToWeekendDay());
        }

        [Then(@"the repayment date should default to the date of the friday that just passed")]
        public void ThenTheRepaymentDateShouldDefaultToTheDateOfTheFridayThatJustPassed()
        {
            user.ShouldSee(FirstRepaymentDay.IsAFriday());
        }



    }
}
