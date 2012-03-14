using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfRequest
{
    abstract class Handler
    {
        protected Handler _successor;

        public void SetSuccessor(Handler successor)
        {
            _successor = successor;
        }

        public abstract void HandleRequest(int request);
    }

    class HandleOdd : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request % 2 != 0)
            {
                Console.WriteLine("{0} handles {1}", GetType().Name, request);
            }
            else if (_successor != null && _successor != this)
            {
                _successor.HandleRequest(request);
            }
            else
            {
                Console.WriteLine("{0} will not be handled");
            }
        }
    }

    class HandleEven : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request % 2 == 0)
            {
                Console.WriteLine("{0} handles {1}", GetType().Name, request);
            }
            else if (_successor != null && _successor != this)
            {
                _successor.HandleRequest(request);
            }
            else
            {
                Console.WriteLine("{0} will not be handled");
            }
        }
    }
}
