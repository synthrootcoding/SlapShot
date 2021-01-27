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
            HttpWebRequest request = WebRequest.CreateHttp(url);
            request.Headers.Add("x-rapidapi-key", "7cb9277a3emsh6e1c4215102d801p100293jsn7a4fd6481cb1");
            request.Headers.Add("x-rapidapi-host", "api-hockey.p.rapidapi.com");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader rd = new StreamReader(response.GetResponseStream());
            string output = rd.ReadToEnd();
            return output;
        }

        public static LeagueStandings GetLeagueStandings()
        {
            string data = CallLeagueStandingsAPI();
            LeagueStandings n = JsonConvert.DeserializeObject<LeagueStandings>(data);
            return n;
        }
    }
}
