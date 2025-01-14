using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AllForOneAPI.Models;
using AllForOneAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace AllForOneAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MadLibController : ControllerBase
    {
        private readonly MadLibServices _madLibServices;

        public MadLibController(MadLibServices madLibServices)
        {
            _madLibServices = madLibServices;
        }

        // [HttpGet]
        // [Route("GetMadLibFillIns")]
        // public List<MadLibFillIn> GetMadLib(){
        //     return _madLibServices.GetMadLibFillIns();
        // }

        [HttpPost]
        [Route("AddMadLib")]
        public string AddMadLib(MadLibFillIn madLibFillIn)
        {
            return _madLibServices.AddMadLib(madLibFillIn);
        }
    }
}