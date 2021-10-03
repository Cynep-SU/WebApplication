using System.Collections.Generic;

namespace WebApplication.Models
{
    public class Alice
    {
        public Meta meta{ get; set; }
        public Session session{ get; set; }
        public Request request{ get; set; }
        public string version { get; set; }
    }
}