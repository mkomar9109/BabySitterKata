﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace BabySitterNameSpace
{
    public class BabySitter
    {
        public const int startToBedRate = 12;
        public const int bedToMidnightRate = 8;
        public const int midnightToEndRate = 16;

        public bool ValidateTimes(string startTime, string endTime, string bedTime)
        {
            if (!ValidFormat(startTime) || !ValidFormat(endTime) || !ValidFormat(bedTime))
                return false;

            DateTime minStartTime = Convert.ToDateTime("5:00PM");
            minStartTime = minStartTime.AddDays(-1);
            DateTime maxEndTime = Convert.ToDateTime("4:00AM");
            DateTime start = CreateDateTime(startTime);
            DateTime end = CreateDateTime(endTime);
           
            if( start >= minStartTime && end <= maxEndTime)
            {
                return true;
            }          
            else 
                return false;        
        }

        public bool ValidFormat(string time)
        {
            Regex expression = new Regex(@"\d{1,2}\:\d{2}\w{1}\w");
            Match match;
            if (!String.IsNullOrEmpty(time))
            {
                match = expression.Match(time);
                if (match.Success)
                {
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }

        public DateTime CreateDateTime(string time)
        {
            DateTime newTime = Convert.ToDateTime(time);
            if (time.ToUpper().Contains("PM"))
            {
                newTime = newTime.AddDays(-1);
            }
            return newTime;
        }

        public int CalculateNightlyRate(string startTime, string endTime, string bedTime)
        {
            bool isValid = ValidateTimes(startTime, endTime, bedTime);
            if(!isValid)
             return 0; 
            int total = 0;
            DateTime start = CreateDateTime(startTime);
            DateTime end = CreateDateTime(endTime);
            DateTime bed = CreateDateTime(bedTime);
            DateTime midnight = Convert.ToDateTime("12:00AM");

            if (start <= bed && bed <= midnight)
            {
                total = CalculateRateTotal(start, bed, startToBedRate);
                if (midnight < end)
                {
                    total += CalculateRateTotal(bed, midnight, bedToMidnightRate);
                    return total + CalculateRateTotal(midnight, end, midnightToEndRate);
                }
                else
                    return total + CalculateRateTotal(bed, end, bedToMidnightRate);
            }
            else if (midnight < end)
            {
                total = CalculateRateTotal(start, midnight, startToBedRate);
                return total + CalculateRateTotal(midnight, end, midnightToEndRate);
            }
            else
                return CalculateRateTotal(start, end, startToBedRate);
        }

        public int CalculateRateTotal(DateTime start, DateTime End, int rate)
        {
            TimeSpan hrs = End - start;
            int total = (int)hrs.TotalHours;
            total = total * rate;
            return total;
        }
    }
}
