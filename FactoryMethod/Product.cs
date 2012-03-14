using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod
{
    abstract class Product
    {
        public abstract void Use();
    }

    // Implementations
    
    class Screwdriver : Product
    {
        public override void Use()
        {
            Console.WriteLine("I screw");
        }
    }

    class Hammer : Product
    {
        public override void Use()
        {
            Console.WriteLine("I hammer");
        }
    }

    class Saw : Product
    {
        public override void Use()
        {
            Console.WriteLine("I saw");
        }
    }
}
