using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace SlapShot.Models
{
    public class HockeyDAL
    {
        public static string CallLeagueStandingsAPI()
        {
            string url = $"https://api-hockey.p.rapidapi.com/standings/?league=19&season=2020";
            var request = WebRequest.CreateHttp(url);
            request.Headers.Add("x-rapidapi-key", "8ee6bb1f97msh72388712e57f0eep108ff5jsnb7ec224de70c");
            request.Headers.Add("x-rapidapi-host", "api-hockey.p.rapidapi.com");
            var response = (HttpWebResponse)request.GetResponse();
            var rd = new StreamReader(response.GetResponseStream());
            string output = rd.ReadToEnd();
            return output;
        }

        public static LeagueStandings GetLeagueStandings()
        {
            string data = CallLeagueStandingsAPI();
            LeagueStandings n = JsonConvert.DeserializeObject<LeagueStandings>(data);
            return n;
        }

        public static string CallLeagueGamesAPI()
        {
            string url = $"https://api-hockey.p.rapidapi.com/games/?league=19&season=2020";
            var request2 = WebRequest.CreateHttp(url);
            request2.Headers.Add("x-rapidapi-key", "8ee6bb1f97msh72388712e57f0eep108ff5jsnb7ec224de70c");
            request2.Headers.Add("x-rapidapi-host", "api-hockey.p.rapidapi.com");
            var response2 = (HttpWebResponse)request2.GetResponse();
            var rd2 = new StreamReader(response2.GetResponseStream());
            string output2 = rd2.ReadToEnd();
            return output2;
        }

        public static LeagueGames GetLeagueGames()
        {
            var data2 = CallLeagueGamesAPI();
            var n2 = JsonConvert.DeserializeObject<LeagueGames>(data2);
            return n2;
        }
    }
}
