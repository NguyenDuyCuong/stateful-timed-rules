﻿// See https://aka.ms/new-console-template for more information

using Models;
using System.Configuration;
using Watcher;
using workflows;
using workflows.RightSeat;

using (var context = new RulesDemoContext(ConfigurationManager.ConnectionStrings[nameof(RulesDemoContext)].ConnectionString))
{
    RulesDBInitializer.Initialize(context);

    var user = context.Users.First();
    var logs = new DataWatcher<FlightLog>();
    var certs = new DataWatcher<Certificate>();
    var builder = new RulesBuilder(logs, certs);

    // trigger Cert -> init monitoring
    var cert = new Certificate() { Name = "Right Seat Currency B737", User = user };

    IRulesWorkflow rulesWF = new BlankWorkflow();
    IRuleNotify ruleProcessor = new BlankNotify();

    if (cert.Name.StartsWith("Right Seat Currency"))
    {
        rulesWF = new RightSeatWorkflow(cert);
        ruleProcessor = new RightSeatProcessor();
    }
        
    //// load default workflow
    builder.CreateWorkflows(rulesWF);

    // fake trigger data 
    logs.Data = context.FlightLogs.ToList();
    certs.Data = new List<Certificate>() { cert };
}

Console.ReadLine();
Console.WriteLine("Done!");
