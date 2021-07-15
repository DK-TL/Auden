using System;
using System.Collections.Generic;
using System.Text;
using Auden.Tasks;
using NUnit.Framework;
using Auden.Observations;
using OpenQA.Selenium;

namespace Auden
{
    public class User
    {

        public IWebDriver driver;

        public User AttemptsTo(params ITask[] listOfTasks)
        {
            for (int task = 0; task < listOfTasks.Length; task++)
            {
                listOfTasks[task].PerformAs(this);
            }

            return this;
        }

        public void ShouldSee(IObservation observation)
        {
            Assert.That(observation.CanBeSeen(this));
        }
    }
}
