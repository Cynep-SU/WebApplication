using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    [Route("test")]
    public class Test : Controller
    {
        [HttpGet]
        [HttpPost]
        public Object Create(string s)
        {
            Console.WriteLine(s);
            /*if (alice != null)
            {
                Console.WriteLine(alice.request.command, alice.request.command);
                return new Response(alice.request.command, alice.request.command).to_json();
            }*/
            return new Response("123", "123").to_json();
        }
    }
}