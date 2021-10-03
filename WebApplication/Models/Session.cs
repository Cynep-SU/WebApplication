using System.Collections.Generic;

namespace WebApplication.Models
{
    public class Session
    {
        public int message_id { get; set; }
        public string session_id { get; set; }
        public string skill_id { get; set; }
        public Dictionary<string, string> user { get; set; }
        public Dictionary<string, string> aplication { get; set; }
        public string @new { get; set; }
        public string user_id { get; set; }
        
    }
}