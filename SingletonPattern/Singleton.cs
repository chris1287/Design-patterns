using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingletonPattern
{
    public sealed class Singleton
    {
        private static Singleton _s = null;
        private static readonly object _mutX = new object();

        private Singleton()
        {
            Console.WriteLine("{0} created", this.GetType().Name);
        }

        public static Singleton Instance
        {
            get
            {
                lock (_mutX)
                {
                    if (_s == null)
                    {
                        _s = new Singleton();
                    }
                }

                return _s;
            }
        }
    }
}
