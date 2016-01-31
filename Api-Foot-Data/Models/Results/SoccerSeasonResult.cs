using System;
using Api_Foot_Data.Models.Common;

namespace Api_Foot_Data.Models.Results
{
    public class SoccerSeasonResult
    {
        public SoccerSeason[] Seasons { get; set; }

        public string error { get; set; }
    }

    public class SoccerSeason
    {
        public LinksSeason _links { get; set; }
        public int id { get; set; }
        public string caption { get; set; }
        public string league { get; set; }
        public string year { get; set; }
        public int currentMatchday { get; set; }
        public int numberOfTeams { get; set; }
        public int numberOfGames { get; set; }
        public DateTime lastUpdated { get; set; }
    }

    public class LinksSeason
    {
        public Link self { get; set; }
        public Link teams { get; set; }
        public Link fixtures { get; set; }
        public Link leagueTable { get; set; }
    }
    
}
