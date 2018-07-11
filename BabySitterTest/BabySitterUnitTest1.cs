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
        public void ValidateStartTimeIsBefore5PMReturnsTrue()
        {
            BabySitter obj = new BabySitter();
            bool validTimes = obj.ValidateTimes("5:00pm", "12:00am", "9:00pm");
            Assert.AreEqual(true, validTimes);
        }

        [TestMethod]
        public void ValidateStartTimeIsBefore5PMReturnsFalse()
        {
            BabySitter obj = new BabySitter();
            bool validTimes = obj.ValidateTimes("4:00pm", "12:00am", "9:00pm");
            Assert.AreEqual(false, validTimes);
        }

        
    }
}
