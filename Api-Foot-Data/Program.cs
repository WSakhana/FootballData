using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Api_Foot_Data.Models.Enums;
using Api_Foot_Data.Services;

namespace Api_Foot_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            SoccerSeasonsServices client = new SoccerSeasonsServices();
            client.AuthToken = "e027889b7b464580b2de5cfa491961df";

            var leagues = client.SoccerSeasons();
            //396, FL1
            var fix = client.Fixture(396, "n7");
            var eq = client.Teams(396);

            FixtureServices clientFixture = new FixtureServices();
            clientFixture.AuthToken = "e027889b7b464580b2de5cfa491961df";

            var ClMatches = clientFixture.Fixtures("n20", "PD");
            var PdMatches = clientFixture.Fixtures("n99", "CL");

            var fixx = clientFixture.Fixtures(140564);
        }
    }
    
    
}
