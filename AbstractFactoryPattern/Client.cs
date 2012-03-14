using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactoryPattern
{
    class Client
    {
        private AbstractProductA _productA;
        private AbstractProductB _productB;

        public Client(AbstractFactory factory)
        {
            _productA = factory.CreateProductA();
            _productB = factory.CreateProductB();
        }

        public void Run()
        {
            _productA.Interact(_productB);
            _productB.Interact(_productA);
        }
    }
}
