using Api_Foot_Data.Models.Results;

namespace Api_Foot_Data.Models
{
    public class Head2Head
    {
        public int count { get; set; }
        public string timeFrameStart { get; set; }
        public string timeFrameEnd { get; set; }
        public int homeTeamWins { get; set; }
        public int awayTeamWins { get; set; }
        public int draws { get; set; }
        public LastTeamResult lastHomeWinHomeTeam { get; set; }
        public LastTeamResult lastWinHomeTeam { get; set; }
        public LastTeamResult lastAwayWinAwayTeam { get; set; }
        public LastTeamResult lastWinAwayTeam { get; set; }
        public Fixture[] fixtures { get; set; }
    }
}