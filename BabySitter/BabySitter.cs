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
            DateTime start = Convert.ToDateTime(startTime);
            DateTime end = Convert.ToDateTime(endTime);

            if (start >= Convert.ToDateTime("5:00pm"))
            {
                return true;
            }
            else if (start < Convert.ToDateTime("5:00pm"))
                return false;

            return true;
           
        }
    }
}
