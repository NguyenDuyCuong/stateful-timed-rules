using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class RulesDemoContext : RulesEngineContext
{
    public string ConnectionString { get; private set; }

    public RulesDemoContext(string connectionString)
    {
        ConnectionString = connectionString;
    }

    public RulesDemoContext()
    {
        ConnectionString = ConfigurationManager.ConnectionStrings[nameof(RulesDemoContext)].ConnectionString;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
      => options.UseSqlite(ConnectionString);

}