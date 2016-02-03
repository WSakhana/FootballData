using System;
using FootballDataSDK.Services;

namespace FootballDataSDK
{
    class Program
    {
        static void Main(string[] args)
        {

            FootDataServices client = new FootDataServices();
            //This is Optional (Can be used without Token, but it's limited [request number])
            client.AuthToken = "Your Auth-Token Here ...";

            var leagues = client.SoccerSeasons();

            if (string.IsNullOrEmpty(leagues.error))
            {
                foreach (var soccerSeason in leagues.Seasons)
                {
                    Console.WriteLine(soccerSeason.league + " : " + soccerSeason.caption);
                }
            }
            else
            {
                Console.WriteLine("ERROR : " + leagues.error);
            }

        }
    }
    
    
}
