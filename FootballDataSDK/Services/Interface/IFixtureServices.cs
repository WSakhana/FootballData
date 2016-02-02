using FootballDataSDK.Models.Results;

namespace FootballDataSDK.Services.Interface
{
    public interface IFixtureServices
    {
        FixturesResult Fixtures();
        FixturesResult Fixtures(string timeFrame, string league);
        FixtureDetailsResult Fixture(int idFixture);
        FixtureDetailsResult Fixture(int idFixture, int head2Head);
    }
}
