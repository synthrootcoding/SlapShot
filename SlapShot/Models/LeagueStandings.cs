using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SlapShot.Models
{

    public class LeagueStandings
    {
        public string get { get; set; }
        public Parameters parameters { get; set; }
        public object[] errors { get; set; }
        public int results { get; set; }
        public Response[][] response { get; set; }
    }

    public class Parameters
    {
        public string league { get; set; }
        public string season { get; set; }
    }

    public class Response
    {
        public int position { get; set; }
        public string stage { get; set; }
        public Group group { get; set; }
        public Team team { get; set; }
        public League league { get; set; }
        public Country country { get; set; }
        public Games games { get; set; }
        public Goals goals { get; set; }
        public int points { get; set; }
        public string form { get; set; }
        public string description { get; set; }
    }

    public class Group
    {
        public string name { get; set; }
    }

    public class Team
    {
        public int id { get; set; }
        public string name { get; set; }
        public string logo { get; set; }
    }

    public class League
    {
        public int id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string logo { get; set; }
        public int season { get; set; }
    }

    public class Country
    {
        public int id { get; set; }
        public string name { get; set; }
        public string code { get; set; }
        public string flag { get; set; }
    }

    public class Games
    {
        public int played { get; set; }
        public Win win { get; set; }
        public Win_Overtime win_overtime { get; set; }
        public Lose lose { get; set; }
        public Lose_Overtime lose_overtime { get; set; }
    }

    public class Win
    {
        public int total { get; set; }
        public string percentage { get; set; }
    }

    public class Win_Overtime
    {
        public int total { get; set; }
        public string percentage { get; set; }
    }

    public class Lose
    {
        public int total { get; set; }
        public string percentage { get; set; }
    }

    public class Lose_Overtime
    {
        public int total { get; set; }
        public string percentage { get; set; }
    }

    public class Goals
    {
        public int _for { get; set; }
        public int against { get; set; }
    }

}
