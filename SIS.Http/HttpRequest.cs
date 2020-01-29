using System.Collections.Generic;

namespace SIS.Http
{
    public class HttpRequest
    {
        public HttpRequest(string httpRequestString)
        {
            this.Headers = new List<Header>();
        }

        public HttpMethodType Method { get; set; }

        public string Path { get; set; }

        public HttpVersionType Version { get; set; }

        public IEnumerable<Header> Headers { get; set; }

        public string Body { get; set; }
    }
}
