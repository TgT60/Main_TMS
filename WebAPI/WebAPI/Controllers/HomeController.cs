using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("home")]
    public class HomeController : ControllerBase
    {
        private readonly IHomeService _homeService;
        private readonly IConfiguration _config;
        public HomeController(IHomeService homeService, IConfiguration config)
        {
            _homeService = homeService;
            _config = config;
        }
        [HttpGet("say")]
        public string SayHello()
        {
            return _homeService.SaySomeThing();
        
        }
    }
}
