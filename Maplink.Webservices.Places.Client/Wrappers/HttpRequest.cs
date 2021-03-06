using System.Collections.Generic;

namespace Maplink.Webservices.Places.Client.Wrappers
{
    public class HttpRequest
    {
        public string Uri { get; set; }
        public string ContentType { get; set; }
        public IEnumerable<KeyValuePair<string, string>> Headers { get; set; }
    }
}