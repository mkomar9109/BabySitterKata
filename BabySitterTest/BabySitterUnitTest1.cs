using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BabySitterNameSpace;


namespace BabySitterTestNameSpace
{
    [TestClass]
    public class BabySitterTest
    {
        BabySitter obj = new BabySitter();
        bool validTimes;
        int total;
        [TestMethod]
        public void ValidateStartStopAndBedTimes()
        {
            bool validTimes = obj.ValidateTimes("5:00pm","12:00am", "9:00pm");
            Assert.AreEqual(true, validTimes);
        }

        [TestMethod]
        public void ValidateStartTimeIsOnOrAfter5PMReturnsTrue()
        {
            validTimes = obj.ValidateTimes("5:00pm", "12:00am", "9:00pm");
            Assert.AreEqual(true, validTimes);
        }

        [TestMethod]
        public void ValidateStopTimeIsOnOrBefore4AMReturnsTrue()
        {
            validTimes = obj.ValidateTimes("6:00pm", "4:00am", "9:00pm");
            Assert.AreEqual(true, validTimes);
        }

         [TestMethod]
        public void ValidateStartTimeBeforeFiveReturnsFalse()
        {
            validTimes = obj.ValidateTimes("4:00pm", "4:00am", "9:00pm");
            Assert.AreEqual(false, validTimes);
        }

        [TestMethod]
        public void ValidateStopTimeAfterFourReturnsFalse()
        {
            validTimes = obj.ValidateTimes("5:00pm", "5:00am", "9:00pm");
            Assert.AreEqual(false, validTimes);
        }

        [TestMethod]
        public void ValidateNullStopTimeReturnsFalse()
        {
            validTimes = obj.ValidateTimes("5:00pm", null, "9:00pm");
            Assert.AreEqual(false, validTimes);
        }

        [TestMethod]
        public void ValidateEmptyStopTimeReturnsFalse()
        {
            validTimes = obj.ValidateTimes("5:00pm", "", "9:00pm");
            Assert.AreEqual(false, validTimes);
        }

        [TestMethod]
        public void ValidateNullStartTimeReturnsFalse()
        {
            validTimes = obj.ValidateTimes(null, "3:00am", "9:00pm");
            Assert.AreEqual(false, validTimes);
        }

        [TestMethod]
        public void ValidateEmptyStartTimeReturnsFalse()
        {
            validTimes = obj.ValidateTimes("", "3:00am", "9:00pm");
            Assert.AreEqual(false, validTimes);
        }


        [TestMethod]
        public void ValidateCalculateNightlyRateReturnsInteger()
        {
            total = obj.CalculateNightlyRate("5:00pm", "1:00am", "9:00pm");
            Assert.AreEqual(88,total);
        }

        [TestMethod]
        public void ValidateCalculateNightlyRateReturnsIntegerWhenBedTimeIsIncludedAndEndTimeIsBeforeMidnight()
        {
            total = obj.CalculateNightlyRate("5:00pm", "11:00pm", "9:00pm");
            Assert.AreEqual(64, total);
        }

        [TestMethod]
        public void ValidateCalculateNightlyRateReturnsIntegerWhenBedTimeIsNotBetweenStartAndEndTimeAndEndTimeGreaterThanMidnight()
        {
            total = obj.CalculateNightlyRate("5:00pm", "1:00am", "2:00am");
            Assert.AreEqual(100, total);
        }

        [TestMethod]
        public void ValidateCalculateNightlyRateReturnsIntegerWhenBedTimeIsNotBetweenStartAndEndTimeAndEndTimeIsLessThanMidnight()
        {
            total = obj.CalculateNightlyRate("5:00pm", "11:00pm", "4:00pm");
            Assert.AreEqual(72, total);
        }

        [TestMethod]
        public void ValidatePartialHours()
        {
            total = obj.CalculateNightlyRate("5:30pm", "11:00pm", "3:30pm");
            Assert.AreEqual(60, total);
        }

        [TestMethod]
        public void ValidateValidFormatReturnsTrue()
        {
            validTimes = obj.ValidFormat("12:30am");
            Assert.AreEqual(true, validTimes);
        }

        [TestMethod]
        public void ValidateValidFormatReturnsFalseIfStringisEmpty()
        {
            validTimes = obj.ValidFormat("");
            Assert.AreEqual(false, validTimes);
        }

        [TestMethod]
        public void ValidateValidFormatReturnsFalseIfStringisRandomString()
        {
            validTimes = obj.ValidFormat("@#ls");
            Assert.AreEqual(false, validTimes);
        }




    }
}
