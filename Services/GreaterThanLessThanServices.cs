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
        public string GreaterThanLessThan(int num1, int num2)
        {
            if(num1 == num2){
                firstStatement = $"Your first number: {num1} is equal to your second number: {num2}.";
                secondStatement = $"Your second number: {num2} is equal to your first number: {num1}.";
                return firstStatement + secondStatement;
            }else if(num1 > num2){
                firstStatement = $"Your first number: {num1} is greater than your second number: {num2}.";
                secondStatement = $"Your second number: {num2} is less than your first number: {num1}.";
                return firstStatement + secondStatement;
            }else{
                firstStatement = $"Your first number: {num1} is less than your second number: {num2}.";
                secondStatement = $"Your second number: {num2} is greater than your first number: {num1}.";
                return firstStatement + secondStatement;
            }
        }
    }
}