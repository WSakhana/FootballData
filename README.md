#Football data
FootballData SDK is an unofficial C# Library  allowing retrieving data 
from the popular api api.football-data.org.
It is intended for use by developer wishing to make theire own football result apps.

##Example of use
```cs
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
    Console.WriteLine("ERROR : " +leagues.error);
  }

}
```



Official API : http://api.football-data.org/
