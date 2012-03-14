using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Observer oa = new ObserverA();
            Observer ob = new ObserverB();
            SubjectA s = new SubjectA();

            s.AddObserver(oa);
            s.AddObserver(ob);

            s.Amount = 3;
            s.Amount = 4;

            Console.ReadKey();
        }
    }
}
