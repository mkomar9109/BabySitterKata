using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabySitterNameSpace
{
    public class BabySitter
    {
        public bool ValidateTimes(string startTime, string endTime, string bedTime)
        {
            DateTime minStartTime = Convert.ToDateTime("5:00PM");
            minStartTime = minStartTime.AddDays(-1);
            DateTime maxEndTime = Convert.ToDateTime("4:00AM");
            DateTime start = CreateDateTime(startTime);
            DateTime end = CreateDateTime(endTime);
            DateTime bed = CreateDateTime(bedTime);

            if (start >= minStartTime && end <= maxEndTime)
            {
                return true;
            }          
            else 
                return false;        
        }

        public DateTime CreateDateTime(string time)
        {
            DateTime newTime = Convert.ToDateTime(time);
            if(time.ToUpper().Contains("PM"))
            {
                newTime = newTime.AddDays(-1);
            }
            return newTime;
        }

        public int CalculateNightlyRate(string startTime, string endTime, string bedTime)
        {
            return 0;
        }
    }
}
