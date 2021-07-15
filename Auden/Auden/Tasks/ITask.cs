using System;
using System.Collections.Generic;
using System.Text;
using Auden;

namespace Auden.Tasks
{
    public interface ITask
    {
        public void PerformAs(User user);
    }
}
