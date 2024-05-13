using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

internal class RulesDBInitializer
{
    public static void Initialize(RulesEngineContext dbContext)
    {
        //creates db if not exists 
        dbContext.Database.EnsureCreated();
        if (dbContext.FlightLogs.Any()) return;

        var user = dbContext.Users.First();
        var logs = new FlightLog[]
        {
            new FlightLog { User = user, FlightNumber = "1", FlightDate = DateTime.UtcNow.AddDays(-10), FlightHours = 10,
                Augmented = false, TakeOff = true, TakeOffLocation = "HN", Landing = true, LandingLocation = "SG", Rank = "Captain", 
                RightSeat = true, Role = "PF" },
            new FlightLog { User = user, FlightNumber = "2", FlightDate = DateTime.UtcNow.AddDays(-9), FlightHours = 10,
                Augmented = false, TakeOff = true, TakeOffLocation = "HN", Landing = true, LandingLocation = "SG", Rank = "Captain",
                RightSeat = true, Role = "PF" },
            new FlightLog { User = user, FlightNumber = "3", FlightDate = DateTime.UtcNow.AddDays(-8), FlightHours = 10,
                Augmented = false, TakeOff = true, TakeOffLocation = "HN", Landing = true, LandingLocation = "SG", Rank = "Captain",
                RightSeat = true, Role = "PF" },
            new FlightLog { User = user, FlightNumber = "4", FlightDate = DateTime.UtcNow.AddDays(-7), FlightHours = 10,
                Augmented = true, TakeOff = true, TakeOffLocation = "HN", Landing = true, LandingLocation = "SG", Rank = "Captain",
                RightSeat = true, Role = "PF" },
            new FlightLog { User = user, FlightNumber = "5", FlightDate = DateTime.UtcNow.AddDays(-6), FlightHours = 10,
                Augmented = true, TakeOff = true, TakeOffLocation = "HN", Landing = true, LandingLocation = "SG", Rank = "Captain",
                RightSeat = true, Role = "PF" },
            new FlightLog { User = user, FlightNumber = "6", FlightDate = DateTime.UtcNow.AddDays(-5), FlightHours = 10,
                TakeOff = true, Landing = true, Rank = "Captain", RightSeat = true, Role = "PF", IsETR = true, Training = "B737 - Recurrent - Session 6-2 - CA/FO" },
            new FlightLog { User = user, FlightNumber = "7", FlightDate = DateTime.UtcNow.AddDays(-4), FlightHours = 10,
                TakeOff = true, Landing = true, Rank = "Captain", RightSeat = true, Role = "PF", IsETR = true, Training = "B737 - Recurrent - Session 6-2 - CA/FO" },
            new FlightLog { User = user, FlightNumber = "8", FlightDate = DateTime.UtcNow.AddDays(-3), FlightHours = 10,
                TakeOff = true, Landing = true, Rank = "Captain", RightSeat = true, Role = "PF", IsETR = true, Training = "B737 - Recurrent - Session 6-2 - CA/FO" },
        };

        dbContext.FlightLogs.AddRange(logs);
        dbContext.SaveChanges();
    }
}
