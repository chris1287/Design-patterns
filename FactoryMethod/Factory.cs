using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod
{
    abstract class Factory
    {
        public abstract Product CreateProduct();
    }

    // Implementations

    class ScrewdriverFactory : Factory
    {
        public override Product CreateProduct()
        {
            return new Screwdriver();
        }
    }

    class HammerFactory : Factory
    {
        public override Product CreateProduct()
        {
            return new Hammer();
        }
    }

    class SawFactory : Factory
    {
        public override Product CreateProduct()
        {
            return new Saw();
        }
    }
}
