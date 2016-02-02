using FootballDataSDK.Models.Common;

namespace FootballDataSDK.Models.Results
{
    public class TeamsResult
    {
        public Links _links { get; set; }
        public int count { get; set; }
        public Team[] teams { get; set; }

        public string error { get; set; }
    }
    
}
