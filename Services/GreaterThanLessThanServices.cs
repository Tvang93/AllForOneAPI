using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllForOneAPI.Services
{
    public class GreaterThanLessThanServices
    {
        public string firstStatement = "";
        public string secondStatement = "";
        public string GreaterThanLessThan(string num1, string num2)
        {
            bool validNum1 = int.TryParse(num1, out int convertedNum1);
            bool validNum2 = int.TryParse(num2, out int convertedNum2);
            if(!validNum1 && !validNum2){
                return $"The first number '{num1}' and the second number '{num2}' are both invalid. Please type in a valid number in for both.";
            }else if(!validNum1 && validNum2){
                return $"The first number '{num1}' is an invaild number. Please type in a valid number for your first number";
            }else if(validNum1 && !validNum2){
                return $"The second number '{num2}' is an invaild number. Please type in a valid number for your second number";
            }
            
            if(convertedNum1 == convertedNum2){
                firstStatement = $"Your first num '{num1}' is equal to your second num '{num2}'.";
                secondStatement = $"Your second num '{num2}' is equal to your first num '{num1}'.";
                return firstStatement + secondStatement;
            }else if(convertedNum1 > convertedNum2){
                firstStatement = $"Your first num '{num1}' is greater than your second num '{num2}'.";
                secondStatement = $"Your second num '{num2}' is less than your first num '{num1}'.";
                return firstStatement + secondStatement;
            }else{
                firstStatement = $"Your first num '{num1}' is less than your second num '{num2}'.";
                secondStatement = $"Your second num '{num2}' is greater than your first num '{num1}'.";
                return firstStatement + secondStatement;
            }
        }
    }
}