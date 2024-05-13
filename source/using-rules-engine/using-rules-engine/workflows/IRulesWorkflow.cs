using Models;
using RulesEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Watcher;

namespace workflows
{
    internal interface IRulesWorkflow
    {
        List<Workflow> Workflows { get; }
        void Load();
    }
}
