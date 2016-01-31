using System;

namespace Api_Foot_Data.Models.Common
{
    public class Link
    {
        private string _href;
        public string href {
            get { return _href; }
            set
            {
                _href = value;

                Id = GetId(_href);
            }
        }

        public int? Id { get; set; }

        private int? GetId(string link)
        {
            if (link != null && !string.IsNullOrWhiteSpace(link))
            {

                int id;
                bool parsed =
                    int.TryParse(
                        link.Substring(
                            link.LastIndexOf("/",
                                StringComparison.InvariantCultureIgnoreCase) + 1),
                        out id);

                if (parsed)
                {
                    return id;
                }
                else
                {
                    
                    string str = link.Substring(0,
                        link.LastIndexOf("/", StringComparison.InvariantCultureIgnoreCase));

                    return GetId(str);
                }
            }

            return null;
        }
    }
}