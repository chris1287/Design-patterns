using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory[] factories = new Factory[3];
            factories[0] = new ScrewdriverFactory();
            factories[1] = new HammerFactory();
            factories[2] = new SawFactory();

            foreach (Factory f in factories)
            {
                Product p = f.CreateProduct();
                p.Use();
            }

            Console.ReadKey();
        }
    }
}
