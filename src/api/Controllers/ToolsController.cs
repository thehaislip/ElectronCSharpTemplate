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
                new { Title = "ASG", Path = @"C:\Program Files (x86)\ASG-Remote Desktop 2015\ASGRD.exe", Image = "" },
                new { Title = "BOSCO", Path = @"C:\Users\itpr16638\Desktop\BOSCO20\BOSCO20.exe",Image = "" }
            };
            return Ok(result);
        }
    }
}