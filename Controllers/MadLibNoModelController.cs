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
    public class MadLibNoModelController : ControllerBase
    {
        private readonly MadLibNoModelServices _madLibNoModelServices;

        public MadLibNoModelController(MadLibNoModelServices madLibNoModelServices)
        {
            _madLibNoModelServices = madLibNoModelServices;
        }

        [HttpGet]
        [Route("MadLib/animal1/container1/leastFavColor/bodyCovering/verb1/favoriteThing/favoriteFood/activityToDo/changeAppearance/favColor")]
        public string MadLib(string animal1, string container1, string leastFavColor, string bodyCovering, string verb1, string favoriteThing, string favoriteFood, string activityToDo, string changeAppearance, string favColor)
        {
            return _madLibNoModelServices.MadLib(animal1, container1, leastFavColor, bodyCovering, verb1, favoriteThing, favoriteFood, activityToDo, changeAppearance, favColor);
        }
    }
}