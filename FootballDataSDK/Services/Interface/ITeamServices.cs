using FootballDataSDK.Models;
using FootballDataSDK.Models.Enums;
using FootballDataSDK.Models.Results;

namespace FootballDataSDK.Services.Interface
{
    public interface ITeamServices
    {
        Team Team(int idTeam);
        FixturesResult FixturesByTeam(int idTeam);
        FixturesResult FixturesByTeam(int idTeam, string timeFrame, string season, VenueEnum? venue = null);
        PlayersResult Players(int idTeam);

    }
}
