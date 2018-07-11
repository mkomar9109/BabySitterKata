using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BabySitterNameSpace;


namespace BabySitterTestNameSpace
{
    [TestClass]
    public class BabySitterTest
    {
        [TestMethod]
        public void ValidateStartStopAndBedTimes()
        {
            BabySitter obj = new BabySitter();
            bool validTimes = obj.ValidateTimes("5:00pm","12:00am", "9:00pm");
            Assert.AreEqual(true, validTimes);
        }

        [TestMethod]
        public void ValidateStartTimeIsOnOrAfter5PMReturnsTrue()
        {
            BabySitter obj = new BabySitter();
            bool validTimes = obj.ValidateTimes("5:00pm", "12:00am", "9:00pm");
            Assert.AreEqual(true, validTimes);
        }

        [TestMethod]
        public void ValidateStopTimeIsOnOrBefore4AMReturnsTrue()
        {
            BabySitter obj = new BabySitter();
            bool validTimes = obj.ValidateTimes("6:00pm", "4:00am", "9:00pm");
            Assert.AreEqual(true, validTimes);
        }

        [TestMethod]
        public void ValidateBedTimeisBetweenStartAndStopTimeReturnTrue()
        {
            BabySitter obj = new BabySitter();
            bool validTimes = obj.ValidateTimes("6:00pm", "4:00am", "9:00pm");
            Assert.AreEqual(true, validTimes);
        }

    }
}
