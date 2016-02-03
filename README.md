# Football data
FootballData SDK is an unofficial C# Library  allowing retrieving data 
from the popular api api.football-data.org.
It is intended for use by developer wishing to make theire own football result apps.

## Nuget Package

Visit https://www.nuget.org/packages/FootballDataSDK

```nuget
  To install FootballData SDK, run the following command in the Package Manager Console
  PM > Install-Package FootballDataSDK
```



## Example of use
```cs
using FootballDataSDK.Services;

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



### Official API
Visit http://api.football-data.org/
