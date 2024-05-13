using Models;
using Newtonsoft.Json;
using RulesEngine.Extensions;
using RulesEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using workflows;

namespace workflows.RightSeat
{
    internal class RightSeatWorkflow(Certificate certificate) : IRulesWorkflow
    {
        public Certificate Certificate { get; private set; } = certificate;
        public List<Workflow> Workflows { get; private set; } = new List<Workflow>();

        public void Load()
        {
            var files = Directory.GetFiles(Directory.GetCurrentDirectory(), "RightSeat.json", SearchOption.AllDirectories);
            if (files == null || files.Length == 0)
                throw new Exception("Rules not found.");

            var fileData = File.ReadAllText(files[0]);
            Workflows = JsonConvert.DeserializeObject<List<Workflow>>(fileData) ?? new List<Workflow>();
        }
    }
}
