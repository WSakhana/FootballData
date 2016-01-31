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
    public class FixtureServices
    {
        public string AuthToken { get; set; }

        /// <summary>
        /// List fixtures across a set of soccerseasons.
        /// </summary>
        /// <returns></returns>
        public FixturesResult Fixtures()
        {
            return Fixtures("", "");
        }
        public FixturesResult Fixtures(string timeFrame, string league)
        {
            string url = $"http://api.football-data.org/v1/fixtures?timeFrame={timeFrame}&league={league}";

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

        public FixtureDetailsResult Fixtures(int idFixture)
        {
            return Fixtures(idFixture, 10);
        }
        public FixtureDetailsResult Fixtures(int idFixture, int head2head)
        {
            string url = $"http://api.football-data.org/v1/fixtures/{idFixture}?head2head={head2head}";

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

                        return new FixtureDetailsResult { error = err.error };
                    }


                    var response = JsonConvert.DeserializeObject<FixtureDetailsResult>(responseString);

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
