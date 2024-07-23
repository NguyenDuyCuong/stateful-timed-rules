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
        private readonly DataWatcher<FlightLog> logs;
        private readonly DataWatcher<Certificate> certs;

        public RulesBuilder(DataWatcher<FlightLog> logs, DataWatcher<Certificate> certs)
        {
            this.logs = logs;
            this.certs = certs;
        }

        public void CreateWorkflows(IRulesWorkflow wf)
        {
            wf.Load();

        }
    }
}
