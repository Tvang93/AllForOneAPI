using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllForOneAPI.Services
{
    public class ReverseItAlphanumericalServices
    {
        public string ReverseItAlphanumerical(string string1)
        {
            string reversedString = "";
            for(int i = string1.Length - 1; i >=0; i--)
            {
                reversedString += string1[i];
            }
            return $"You've entered '{string1}'. Reversed it is '{reversedString}'.";
        }
    }
}