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
        public void ValidateBedTimeisBetweenStartAndStopTimeReturnTrue()
        {
            bool validTimes = obj.ValidateTimes("6:00pm", "4:00am", "9:00pm");
            Assert.AreEqual(true, validTimes);
        }

    }
}
