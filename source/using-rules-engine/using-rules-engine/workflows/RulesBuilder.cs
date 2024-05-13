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
    internal class RulesBuilder
    {
        public void CreateWorkflows(IRulesWorkflow wf)
        {
            wf.Load();
        }
    }
}
