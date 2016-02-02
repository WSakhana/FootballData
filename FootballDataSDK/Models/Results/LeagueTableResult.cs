using FootballDataSDK.Models.Common;

namespace FootballDataSDK.Models.Results
{

    public class LeagueTableResult
    {
        public Links _links { get; set; }
        public string leagueCaption { get; set; }
        public int matchday { get; set; }
        public Standing[] standing { get; set; }

        public string error { get; set; }
    }

    
    public class Standing
    {
        public LinksStanding _links { get; set; }
        public int position { get; set; }
        public string teamName { get; set; }
        public string crestURI { get; set; }
        public int playedGames { get; set; }
        public int points { get; set; }
        public int goals { get; set; }
        public int goalsAgainst { get; set; }
        public int goalDifference { get; set; }
        public int wins { get; set; }
        public int draws { get; set; }
        public int losses { get; set; }
        public Home home { get; set; }
        public Away away { get; set; }
    }

    public class LinksStanding
    {
        public Link team { get; set; }
    }

    

    public class Home
    {
        public int goals { get; set; }
        public int goalsAgainst { get; set; }
        public int wins { get; set; }
        public int draws { get; set; }
        public int losses { get; set; }
    }

    public class Away
    {
        public int goals { get; set; }
        public int goalsAgainst { get; set; }
        public int wins { get; set; }
        public int draws { get; set; }
        public int losses { get; set; }
    }
    
}
