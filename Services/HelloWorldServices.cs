using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllForOneAPI.Services
{
    public class HelloWorldServices
    {
        public string HelloWorld(string userName){
            return $"Hello, {userName}! How are you?";
        }
    }
}