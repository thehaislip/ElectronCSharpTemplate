using System;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/[controller]")]
    public class ToolsController : Controller
    {
        // GET api/Tools
        [HttpGet]
        public IActionResult Get()
        {
            var result = new [] {
                new { Title = "ASG", Path = "", Image = "" },
                new { Title = "BOSCO", Path = "",Image = "" }
            };
            return Ok(result);
        }
    }
}