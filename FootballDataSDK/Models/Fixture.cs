using System;
using FootballDataSDK.Models.Common;

namespace FootballDataSDK.Models
{
    public class Fixture
    {
        public Links _links { get; set; }
        public DateTime date { get; set; }
        public string status { get; set; }
        public int matchday { get; set; }
        public string homeTeamName { get; set; }
        public string awayTeamName { get; set; }
        public ResultMatch ResultMatch { get; set; }
    }
}