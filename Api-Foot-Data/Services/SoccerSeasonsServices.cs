using System;
using System.Net;
using System.Net.Http;
using Api_Foot_Data.Client;
using Api_Foot_Data.Models;
using Api_Foot_Data.Models.Common;
using Api_Foot_Data.Models.Results;
using Newtonsoft.Json;

namespace Api_Foot_Data.Services
{
    public class SoccerSeasonsServices
    {
        public string AuthToken { get; set; }

        /// <summary>
        /// List all available soccer seasons.	
        /// </summary>
        /// <returns></returns>
        public SoccerSeasonResult SoccerSeasons()
        {
            string url = "http://api.football-data.org/v1/soccerseasons";
            
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

                        return new SoccerSeasonResult { error = err.error };
                    }

                    var response = JsonConvert.DeserializeObject<SoccerSeason[]>(responseString);

                    return new SoccerSeasonResult
                    {
                        Seasons = response
                    };

                }
                catch (Exception ex)
                {
                    //Ignore..
                }
            }

            return null;
        }

        public TeamsResult Teams(int idSeason)
        {
            string url = $"http://api.football-data.org/v1/soccerseasons/{idSeason}/teams";

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

                        return new TeamsResult {error = err.error};
                    }


                    var response = JsonConvert.DeserializeObject<TeamsResult>(responseString);

                    return response;

                }
                catch (Exception ex)
                {
                    //Ignore..
                }
            }

            return null;
        }

        public LeagueTableResult LeagueTable(int idSeason)
        {
            return LeagueTable(idSeason, -1);
        }

        public LeagueTableResult LeagueTable(int idSeason, int matchday)
        {
            string mDay = "";

            if (matchday > 0)
            {
                mDay = matchday + "";
            }

            string url = $"http://api.football-data.org/v1/soccerseasons/{idSeason}/leagueTable?matchday={mDay}";

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

                        return new LeagueTableResult { error = err.error };
                    }


                    var response = JsonConvert.DeserializeObject<LeagueTableResult>(responseString);

                    return response;
                }
                catch (Exception ex)
                {
                    //Ignore..
                }
            }

            return null;
        }

        
        public FixturesResult Fixture(int idSeason,  int matchday, string timeFrame)
        {
            string p1 = "";
            if (matchday > 0)
                p1 = matchday + "";

            string url =
                $"http://api.football-data.org/v1/soccerseasons/{idSeason}/fixtures?matchday={p1}&timeFrame={timeFrame}";

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

        public FixturesResult Fixture(int idSeason)
        {
            return Fixture(idSeason, -1, null);
        }
        public FixturesResult Fixture(int idSeason, int matchday)
        {
            return Fixture(idSeason, matchday, null);
        }

        public FixturesResult Fixture(int idSeason, string timeFrame)
        {
            return Fixture(idSeason, -1, timeFrame);
        }

    }
}
