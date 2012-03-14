using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfRequest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] request = { 2, 4, 1, 3, 7, 8 };

            Handler he = new HandleEven();
            Handler ho = new HandleOdd();

            he.SetSuccessor(ho);

            foreach (int r in request)
            {
                he.HandleRequest(r);
            }

            Console.ReadKey();
        }
    }
}
