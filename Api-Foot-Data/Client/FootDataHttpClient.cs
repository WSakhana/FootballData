using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Api_Foot_Data.Client
{
    class FootDataHttpClient : HttpClient
    {
        public FootDataHttpClient()
        {
            //Include French in the Accept-Langauge header. 
            this.DefaultRequestHeaders.Add("Accept-Language", "fr_FR");

            this.DefaultRequestHeaders.Add("User-Agent",
                "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.8.1.9) Gecko/20071025 Firefox/2.0.0.9");

            this.Timeout = TimeSpan.FromSeconds(5);
        }
        public FootDataHttpClient(string token) : this()
        {
            if (!string.IsNullOrWhiteSpace(token))
            {
                this.DefaultRequestHeaders.Add("X-Auth-Token", token);
            }
        }
    }
}
