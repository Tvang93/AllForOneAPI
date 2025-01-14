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
    public class ReverseItAlphanumericalController : ControllerBase
    {
        private readonly ReverseItAlphanumericalServices _reverseItAlphanumericalServices;

        public ReverseItAlphanumericalController(ReverseItAlphanumericalServices reverseItAlphanumericalServices)
        {
            _reverseItAlphanumericalServices = reverseItAlphanumericalServices;
        }

        [HttpGet]
        [Route("ReverseItAlphanumerical/{string1}")]
        public string ReverseItAlphanumerical(string string1)
        {
            return _reverseItAlphanumericalServices.ReverseItAlphanumerical(string1);
        }
    }
}