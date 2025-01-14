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
    public class RestaurantPickerController : ControllerBase
    {
        private readonly RestaurantPickerServices _restaurantPickerServices;
    
        public RestaurantPickerController(RestaurantPickerServices restaurantPickerServices)
        {
            _restaurantPickerServices = restaurantPickerServices;
        }

        [HttpGet]
        [Route("RestuarantPicker/{chickenBeefOrSeaFood}")]
        public string RestaurantPicker(string chickenBeefOrSeaFood)
        {
            return _restaurantPickerServices.RestaurantPicker(chickenBeefOrSeaFood);
        }
    }
}