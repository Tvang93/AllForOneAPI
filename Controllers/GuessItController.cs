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
    public class GuessItController : ControllerBase
    {
        private readonly GuessItServices _guessItServices;

        public GuessItController(GuessItServices guessItServices)
        {
            _guessItServices = guessItServices;
        }

        [HttpGet]
        [Route("ChooseMode/{easyMediumOrHard}/{guessNum}")]
        public string ChooseMode(string easyMediumOrHard, string guessNum)
        {
           switch(easyMediumOrHard.ToLower())
           {
                case "easy":
                return _guessItServices.EasyGuess(guessNum);
                case "medium":
                return _guessItServices.MediumGuess(guessNum);
                case "hard":
                return _guessItServices.HardGuess(guessNum);
                default:
                return "Invalid mode choice. Please type in easy, medium, or hard.";
           }
        }
    }
}