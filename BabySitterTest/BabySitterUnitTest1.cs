using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BabySitterNameSpace;


namespace BabySitterTestNameSpace
{
    [TestClass]
    public class BabySitterTest
    {
        BabySitter obj = new BabySitter();
        [TestMethod]
        public void ValidateStartStopAndBedTimes()
        {
            bool validTimes = obj.ValidateTimes("5:00pm","12:00am", "9:00pm");
            Assert.AreEqual(true, validTimes);
        }

        [TestMethod]
        public void ValidateStartTimeIsOnOrAfter5PMReturnsTrue()
        {
            bool validTimes = obj.ValidateTimes("5:00pm", "12:00am", "9:00pm");
            Assert.AreEqual(true, validTimes);
        }

        [TestMethod]
        public void ValidateStopTimeIsOnOrBefore4AMReturnsTrue()
        {
            bool validTimes = obj.ValidateTimes("6:00pm", "4:00am", "9:00pm");
            Assert.AreEqual(true, validTimes);
        }

         [TestMethod]
        public void ValidateStartTimeBeforeFiveReturnsFalse()
        {
            bool validTimes = obj.ValidateTimes("4:00pm", "4:00am", "9:00pm");
            Assert.AreEqual(false, validTimes);
        }

        [TestMethod]
        public void ValidateStopTimeAfterFourReturnsFalse()
        {
            bool validTimes = obj.ValidateTimes("5:00pm", "5:00am", "9:00pm");
            Assert.AreEqual(false, validTimes);
        }

        [TestMethod]
        public void ValidateNullStopTimeReturnsFalse()
        {
            bool validTimes = obj.ValidateTimes("5:00pm", null, "9:00pm");
            Assert.AreEqual(false, validTimes);
        }

        [TestMethod]
        public void ValidateEmptyStopTimeReturnsFalse()
        {
            bool validTimes = obj.ValidateTimes("5:00pm", "", "9:00pm");
            Assert.AreEqual(false, validTimes);
        }

        [TestMethod]
        public void ValidateNullStartTimeReturnsFalse()
        {
            bool validTimes = obj.ValidateTimes(null, "3:00am", "9:00pm");
            Assert.AreEqual(false, validTimes);
        }

        [TestMethod]
        public void ValidateEmptyStartTimeReturnsFalse()
        {
            bool validTimes = obj.ValidateTimes("", "3:00am", "9:00pm");
            Assert.AreEqual(false, validTimes);
        }


        [TestMethod]
        public void ValidateCalculateNightlyRateReturnsInteger()
        {
            int total = obj.CalculateNightlyRate("5:00pm", "1:00am", "9:00pm");
            Assert.AreEqual(88,total);
        }

        [TestMethod]
        public void ValidateCalculateNightlyRateReturnsIntegerWhenBedTimeIsIncludedAndEndTimeIsBeforeMidnight()
        {
            int total = obj.CalculateNightlyRate("5:00pm", "11:00pm", "9:00pm");
            Assert.AreEqual(64, total);
        }

        [TestMethod]
        public void ValidateCalculateNightlyRateReturnsIntegerWhenBedTimeIsNotBetweenStartAndEndTimeAndEndTimeGreaterThanMidnight()
        {
            int total = obj.CalculateNightlyRate("5:00pm", "1:00am", "2:00am");
            Assert.AreEqual(100, total);
        }

        [TestMethod]
        public void ValidateCalculateNightlyRateReturnsIntegerWhenBedTimeIsNotBetweenStartAndEndTimeAndEndTimeIsLessThanMidnight()
        {
            int total = obj.CalculateNightlyRate("5:00pm", "11:00pm", "4:00pm");
            Assert.AreEqual(72, total);
        }



    }
}
