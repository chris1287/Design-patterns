using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
{
    abstract class Subject
    {
        protected List<Observer> _observers = new List<Observer>();

        public void AddObserver(Observer o)
        {
            _observers.Add(o);
        }

        public void RemoveObserver(Observer o)
        {
            _observers.Remove(o);
        }

        public abstract void Notify();
    }

    class SubjectA : Subject
    {
        private int _amount;

        public int Amount
        {
            get
            {
                return _amount;
            }

            set
            {
                if (_amount != value)
                {
                    _amount = value;
                    Notify();
                }
            }
        }

        public override void Notify()
        {
            foreach (Observer o in _observers)
                o.Update(this);
        }
    }
}
