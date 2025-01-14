using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllForOneAPI.Services
{
    public class AskingQuestionsServices
    {
        public string wakeUpTime(string userName, string wakeTime)
        {
            bool validTime = int.TryParse(wakeTime, out int convertedWakeTime);
            if(validTime && convertedWakeTime > 0 && convertedWakeTime < 13){
                return $"{userName} woke up at {wakeTime} o'clock.";
            }else{
                return $"Your wake time is invalid. Please type in a valid hour time value.";
            }
        }
    }
}