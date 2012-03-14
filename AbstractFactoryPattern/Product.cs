using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactoryPattern
{
    abstract class AbstractProductA
    {
        public abstract void Interact(AbstractProductB product);
    }

    abstract class AbstractProductB
    {
        public abstract void Interact(AbstractProductA product);
    }

    // Implementations

    class ProductA1 : AbstractProductA
    {
        public override void Interact(AbstractProductB product)
        {
            Console.WriteLine("{0} interacts with {1}", this.GetType().Name, product.GetType().Name);
        }
    }

    class ProductA2 : AbstractProductA
    {
        public override void Interact(AbstractProductB product)
        {
            Console.WriteLine("{0} interacts with {1}", this.GetType().Name, product.GetType().Name);
        }
    }

    class ProductB1 : AbstractProductB
    {
        public override void Interact(AbstractProductA product)
        {
            Console.WriteLine("{0} interacts with {1}", this.GetType().Name, product.GetType().Name);
        }
    }

    class ProductB2 : AbstractProductB
    {
        public override void Interact(AbstractProductA product)
        {
            Console.WriteLine("{0} interacts with {1}", this.GetType().Name, product.GetType().Name);
        }
    }
}
