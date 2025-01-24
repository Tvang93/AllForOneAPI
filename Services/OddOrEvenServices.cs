using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllForOneAPI.Services
{
    public class OddOrEvenServices
    {
        public string OddOrEven(string num1)
        {
            int convertedNum;
            bool validNum = int.TryParse(num1, out convertedNum);

            if(validNum){
                if(convertedNum % 2 == 0){
                return $"The number you entered '{num1}' is an even number.";
                }else{
                return $"The number you entered '{num1}' is an odd number.";
                }
            }else{
                return "Invalid Entry. Please type in a number.";
            }
            
        }
    }
}