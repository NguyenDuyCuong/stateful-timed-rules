using RulesEngine.Extensions;
using RulesEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Watcher;

namespace workflows.RightSeat
{
    internal class RightSeatProcessor : IRuleNotify
    {
        private RulesEngine.RulesEngine engine = new RulesEngine.RulesEngine();
        public string Name => "RightSeat";

        public async void Update<T>(IEnumerable<T> data)
        {
            // trigger data -> evaluate
            List<RuleResultTree> results = await engine.ExecuteAllRulesAsync(Name, data);

            // raise events
            results.OnSuccess((eventName) =>
            {
                Console.WriteLine($"Result '{eventName}' is as expected.");
            });

            results.OnFail(() =>
            {
                Console.WriteLine($"Result is failed.");
            });
        }
    }
}
