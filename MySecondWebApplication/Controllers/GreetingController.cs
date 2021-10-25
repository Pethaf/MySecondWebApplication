using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MySecondWebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GreetingController : ControllerBase
    {
        [HttpGet("ping")]
        public string Ping()
        {
            return "pong";
        }
        [HttpGet]
        [Route("hello")]
        public string Hello([FromQuery] string name)
        {
            return $"Hello! + {name}";
        }
    }
}
