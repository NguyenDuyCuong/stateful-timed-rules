using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Watcher;

namespace Watcher
{
    internal class BlankNotify : IRuleNotify
    {
        public string Name => "Blank";

        public void Update<T>(IEnumerable<T> data)
        {
        }
    }
}
