using System;
using System.Collections.Generic;
using System.Text;

namespace Auden.Tasks
{
    public class NavigateTo : ITask
    {
        string url;

        public void PerformAs(User user)
        {
            user.driver.Navigate().GoToUrl(url);
        }

        public static NavigateTo URL(string url)
        {
            return new NavigateTo(url);
        }

        public NavigateTo(string url) { this.url = url; }
    }
}
