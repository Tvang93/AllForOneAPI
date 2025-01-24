using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllForOneAPI.Services
{
    public class AddingTwoNumbersServices
    {
        public string AddTwoNumbers(string num1, string num2)
        {
            bool validNum1 = int.TryParse(num1, out int convertedNum1);
            bool validNum2 = int.TryParse(num2, out int convertedNum2);
            if(validNum1 && validNum2){
                return $"The sum of {num1} and {num2} is {convertedNum1 + convertedNum2}.";
            }else if(!validNum1 && !validNum2){
                return $"The first number '{num1}' and the second number '{num2}' are both invalid. Please type in a valid number in for both.";
            }else if(!validNum1 && validNum2){
                return $"The first number '{num1}' is an invaild number. Please type in a valid number for your first number";
            }else{
                return $"The second number '{num2}' is an invaild number. Please type in a valid number for your second number";
            }
        }
    }
}