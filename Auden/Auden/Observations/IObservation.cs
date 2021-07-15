using System;
using System.Collections.Generic;
using System.Text;

namespace Auden.Observations
{
    public interface IObservation
    {
        public Boolean CanBeSeen(User user);
    }
}