using RulesEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workflows
{
    internal class BlankWorkflow : IRulesWorkflow
    {
        public List<Workflow> Workflows => new List<Workflow>();

        public string Name => "Blank";

        public void Load()
        {   
        }

        public void Update<T>(IEnumerable<T> data)
        {
            
        }
    }
}
