using System;

namespace Auden.Observations
{
    public interface IObservation
    {
        public Boolean CanBeSeen(User user);
    }
}