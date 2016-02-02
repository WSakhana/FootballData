using FootballDataSDK.Models.Results;

namespace FootballDataSDK.Services.Interface
{
    public interface ISoccerSeasonsServices
    {
        SoccerSeasonResult SoccerSeasons();
        TeamsResult Teams(int idSeason);
        LeagueTableResult LeagueTable(int idSeason);
        LeagueTableResult LeagueTable(int idSeason, int matchday);
        FixturesResult Fixtures(int idSeason, int matchday, string timeFrame);
        FixturesResult Fixtures(int idSeason);
        FixturesResult Fixtures(int idSeason, int matchday);
        FixturesResult Fixtures(int idSeason, string timeFrame);
    }
}
