using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllForOneAPI.Services
{
    public class ReverseItNumbersServices
    {
        public string ReverseItNumbers(string stringNum)
        {
            int convertedNum;
            bool validNum = int.TryParse(stringNum, out convertedNum);
            string reversedNum = "";

            if(validNum){
                if(convertedNum < 0){
                for(int i = stringNum.Length - 2; i >= 0; i--)
                {
                        reversedNum += convertedNum * -1 % 10;
                        convertedNum /= 10;
                }
                return $"The number you entered was: {stringNum} and reversed is: {reversedNum}-.";
                }else{
                    for(int i = stringNum.Length - 1; i >= 0; i--)
                {
                        reversedNum += convertedNum % 10;
                        convertedNum /= 10;
                }
                return $"The number you entered was: {stringNum} and reversed is: {reversedNum}.";
                }
            }else{
                return "Invalid Entry. Please type in a number.";
            }
        }
    }
}