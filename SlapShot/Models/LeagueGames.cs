using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SlapShot.Models
{

    public class LeagueGames
    {
        public string get { get; set; }
        public ParametersLG parameters { get; set; }
        public object[] errors { get; set; }
        public int results { get; set; }
        public Response2[] response { get; set; }
    }

    public class ParametersLG
    {
        public string league { get; set; }
        public string season { get; set; }
    }

    public class Response2
    {
        public int id { get; set; }
        public DateTime date { get; set; }
        public string time { get; set; }
        public int timestamp { get; set; }
        public string timezone { get; set; }
        public string week { get; set; }
        public object timer { get; set; }
        public Status status { get; set; }
        public Country2 country { get; set; }
        public League2 league { get; set; }
        public Teams teams { get; set; }
        public Scores scores { get; set; }
        public Periods periods { get; set; }
        public bool events { get; set; }
    }

    public class Status
    {
        public string _long { get; set; }
        public string _short { get; set; }
    }

    public class Country2
    {
        public int id { get; set; }
        public string name { get; set; }
        public string code { get; set; }
        public string flag { get; set; }
    }

    public class League2
    {
        public int id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string logo { get; set; }
        public int season { get; set; }
    }

    public class Teams
    {
        public Home home { get; set; }
        public Away away { get; set; }
    }

    public class Home
    {
        public int id { get; set; }
        public string name { get; set; }
        public string logo { get; set; }
    }

    public class Away
    {
        public int id { get; set; }
        public string name { get; set; }
        public string logo { get; set; }
    }

    public class Scores
    {
        public int? home { get; set; }
        public int? away { get; set; }
    }

    public class Periods
    {
        public string first { get; set; }
        public string second { get; set; }
        public string third { get; set; }
        public string overtime { get; set; }
        public string penalties { get; set; }
    }

}
