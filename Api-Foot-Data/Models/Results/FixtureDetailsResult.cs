namespace Api_Foot_Data.Models.Results
{
    public class FixtureDetailsResult
    {
        public Fixture fixture { get; set; }
        public Head2Head head2head { get; set; }

        public string error { get; set; }
    }
}
