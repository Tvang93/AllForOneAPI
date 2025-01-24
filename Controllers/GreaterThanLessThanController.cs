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
    public class GreaterThanLessThanController : ControllerBase
    {
        private readonly GreaterThanLessThanServices _greaterThanLessThan;
        public GreaterThanLessThanController(GreaterThanLessThanServices anything)
        {
            _greaterThanLessThan = anything;
        }

        [HttpGet]
        [Route("GreaterThanLessThan/{num1}/{num2}")]
        public string GreaterThanLessThan(string num1, string num2)
        {
            return _greaterThanLessThan.GreaterThanLessThan(num1, num2);
        }
    }
}