using Api_Foot_Data.Models.Common;

namespace Api_Foot_Data.Models.Results
{
    public class TeamsResult
    {
        public Links _links { get; set; }
        public int count { get; set; }
        public Team[] teams { get; set; }

        public string error { get; set; }
    }
    
}
