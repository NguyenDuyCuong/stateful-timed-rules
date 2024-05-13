using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Watcher
{
    internal class DataWatcher<T>
    {
        private List<T> _data = new List<T>();
        public List<T> Data { get { return _data; } set { _data = value; Notify(); } }
        public List<IRuleNotify> Subscribers { get; set; } = new List<IRuleNotify>();

        public void Subscribe(IRuleNotify rule) {
            if (!Subscribers.Any(s => s.Name == rule.Name)) 
                Subscribers.Add(rule);
        }

        public void Unsubscribe(IRuleNotify rule)
        {
            if (Subscribers.Any(s => s.Name == rule.Name))
                Subscribers.Remove(rule);
        }

        public void Notify()
        {
            Subscribers.ForEach(subscriber => Task.Factory.StartNew(() => subscriber.Update(_data)));
        }
    }
}
