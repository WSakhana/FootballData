using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Api_Foot_Data.Client;
using Api_Foot_Data.Models;
using Api_Foot_Data.Models.Common;
using Api_Foot_Data.Models.Enums;
using Api_Foot_Data.Models.Results;
using Newtonsoft.Json;

namespace Api_Foot_Data.Services
{
    public class TeamServices
    {
        public string AuthToken { get; set; }

        public Team Team(int idTeam)
        {
            string url = $"http://api.football-data.org/v1/teams/{idTeam}";

            using (var client = new FootDataHttpClient(AuthToken))
            {
                try
                {
                    var res = client.GetAsync(new Uri(url)).Result;

                    string responseString = res.Content.ReadAsStringAsync().Result;

                    // Sanity Check
                    if (string.IsNullOrEmpty(responseString) || res.StatusCode != HttpStatusCode.OK)
                    {
                        var err = JsonConvert.DeserializeObject<ErrorResult>(responseString);

                        return new Team { error = err.error };
                    }


                    var response = JsonConvert.DeserializeObject<Team>(responseString);

                    return response;

                }
                catch (Exception ex)
                {
                    //Ignore..
                }
            }

            return null;
        }

        public FixturesResult Fixtures(int idTeam)
        {
            //string timeFrame, string season, VenueEnum? venue = null
            return Fixtures(idTeam, null, null, null);
        }

        public FixturesResult Fixtures(int idTeam,string timeFrame, string season, VenueEnum? venue = null)
        {
            string url = $"http://api.football-data.org/v1/teams/{idTeam}/fixtures?timeFrame={timeFrame}&season={season}&venue={venue}";

            using (var client = new FootDataHttpClient(AuthToken))
            {
                try
                {
                    var res = client.GetAsync(new Uri(url)).Result;

                    string responseString = res.Content.ReadAsStringAsync().Result;

                    // Sanity Check
                    if (string.IsNullOrEmpty(responseString) || res.StatusCode != HttpStatusCode.OK)
                    {
                        var err = JsonConvert.DeserializeObject<ErrorResult>(responseString);

                        return new FixturesResult { error = err.error };
                    }

                    var response = JsonConvert.DeserializeObject<FixturesResult>(responseString);

                    return response;
                }
                catch (Exception ex)
                {
                    //Ignore..
                }
            }

            return null;
        }

        public PlayersResult Player(int idTeam)
        {
            string url = $"http://api.football-data.org/v1/teams/{idTeam}/players";

            using (var client = new FootDataHttpClient(AuthToken))
            {
                try
                {
                    var res = client.GetAsync(new Uri(url)).Result;

                    string responseString = res.Content.ReadAsStringAsync().Result;

                    // Sanity Check
                    if (string.IsNullOrEmpty(responseString) || res.StatusCode != HttpStatusCode.OK)
                    {
                        var err = JsonConvert.DeserializeObject<ErrorResult>(responseString);

                        return new PlayersResult { error = err.error };
                    }


                    var response = JsonConvert.DeserializeObject<PlayersResult>(responseString);

                    return response;

                }
                catch (Exception ex)
                {
                    //Ignore..
                }
            }

            return null;
        }
    }
}
