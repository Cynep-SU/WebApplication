using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public class Response
    {
        public Dictionary<string, string> response = new Dictionary<string, string>();
        public string version = "1.0";

        public Response(string text, string tts)
        {
            response.Add("text", text);
            response.Add("tts", tts);
        }

        public Object to_json()
        {
            return new { response, version };
        }
    }
}