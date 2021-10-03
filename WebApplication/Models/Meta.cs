using System.Collections.Generic;

namespace WebApplication.Models
{
    public class Meta
    {
        public string locale { get; set; }
        public string timezone { get; set; }
        public string client_id { get; set; }
        public Dictionary<string, Dictionary<string, string>> interfaces { get; set; }
        
    }
}