using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AllForOneAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace AllForOneAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloWorldController : ControllerBase
    {
        private readonly HelloWorldServices _helloWorldServices;
        public HelloWorldController(HelloWorldServices helloWorldServices){
            _helloWorldServices = helloWorldServices;
        }

        [HttpGet]
        [Route("HelloWorld/{userName}")]
        public string HelloWorld(string userName)
        {
            return _helloWorldServices.HelloWorld(userName);
        }
    }
}