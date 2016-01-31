using Api_Foot_Data.Models.Common;

namespace Api_Foot_Data.Models
{
    public class Team
    {
        public LinksTeam _links { get; set; }
        public string name { get; set; }
        public string code { get; set; }
        public string shortName { get; set; }
        public string squadMarketValue { get; set; }
        public string crestUrl { get; set; }

        public string error { get; set; }
    }

    public class LinksTeam
    {
        public Link self { get; set; }
        public Link fixtures { get; set; }
        public Link players { get; set; }
    }
}