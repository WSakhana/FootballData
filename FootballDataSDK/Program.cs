using FootballDataSDK.Services;

namespace FootballDataSDK
{
    class Program
    {
        static void Main(string[] args)
        {
            FootDataServices client = new FootDataServices();
            client.AuthToken = "e027889b7b464580b2de5cfa491961df";
            
            var leagues = client.SoccerSeasons();
            //396, FL1
            var fix = client.Fixtures(396, "n7");
            var eq = client.Teams(396);
            
            var ClMatches = client.Fixtures("n20", "PD");
            var PdMatches = client.Fixtures("n99", "CL");

            var fixx = client.Fixture(140564);
        }
    }
    
    
}
