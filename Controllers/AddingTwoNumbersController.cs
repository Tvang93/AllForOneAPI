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
    public class AddingTwoNumbersController : ControllerBase
    {
        private readonly AddingTwoNumbersServices _addingTwoNumbersServices;

        public AddingTwoNumbersController(AddingTwoNumbersServices addTwoNumbersServices)
        {
            _addingTwoNumbersServices = addTwoNumbersServices;
        }

        [HttpGet]
        [Route("AddTwoNumbers/{num1}/{num2}")]
        public string AddTwoNumbers(string num1, string num2)
        {
            return _addingTwoNumbersServices.AddTwoNumbers(num1, num2);
        }
    }
}