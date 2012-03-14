using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
{
    abstract class Observer
    {
        public abstract void Update(Subject s);
    }

    class ObserverA : Observer
    {
        public override void Update(Subject s)
        {
            Console.WriteLine("{0} observed that {1} changed", GetType().Name, s.GetType().Name);
        }
    }

    class ObserverB : Observer
    {
        public override void Update(Subject s)
        {
            Console.WriteLine("{0} observed that {1} changed", GetType().Name, s.GetType().Name);
        }
    }
}
