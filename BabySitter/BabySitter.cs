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
            
            DateTime start = Convert.ToDateTime(startTime);
            if (startTime.ToUpper().Contains("PM"))
            {
                start = start.AddDays(-1);
            }
            DateTime end = Convert.ToDateTime(endTime);
            if (endTime.ToUpper().Contains("PM"))
            {
                end = end.AddDays(-1);
            }
            DateTime bed = Convert.ToDateTime(bedTime);
            if (bedTime.ToUpper().Contains("PM"))
            {
                bed = bed.AddDays(-1);
            }

            if (start >= minStartTime && end <= maxEndTime)
            {
                if (bed >= start && bed <= end)
                {
                    return true;
                }
                return true;
            }          
            else 
                return false;
           
        }
    }
}
