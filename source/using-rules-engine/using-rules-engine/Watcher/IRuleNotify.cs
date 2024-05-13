using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Watcher
{
    internal interface IRuleNotify
    {
        string Name { get; }
        void Update<T>(IEnumerable<T> data);
    }
}
