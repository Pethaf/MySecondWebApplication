using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySecondWebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExerciseController : ControllerBase
    {
        [HttpGet("ping")]
        public string Ping()
        {
            return "pong";
        }
        [HttpGet("concat")]
        public string Concat([FromQuery] string value1, [FromQuery] string value2)
        {
            return value1 +" " + value2;
        }
    }
}
