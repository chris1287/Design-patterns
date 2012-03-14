using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactoryPattern
{
    // More details here:
    // http://www.dofactory.com/Patterns/PatternAbstract.aspx#_self1

    class Program
    {
        static void Main(string[] args)
        {
            AbstractFactory factory1 = new Factory1();
            AbstractFactory factory2 = new Factory2();

            Client client1 = new Client(factory1);
            Client client2 = new Client(factory2);

            client1.Run();
            client2.Run();

            Console.ReadKey();
        }
    }
}
