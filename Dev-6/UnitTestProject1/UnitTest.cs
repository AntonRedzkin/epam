using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dev_6;


namespace UnitTests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void FormatSeter_WithValidFormat()
        {
            DateTimeFormatSeter set = new DateTimeFormatSeter();
            string nowDateTime = string.Empty;
            string format = "dd:MM:yy HH:mm:ss";
            set.FormatSeter(format, out nowDateTime);
            string actual = nowDateTime;
            string expected = DateTime.Now.ToString(format);
            Assert.AreEqual(expected, actual, "Date Time Format not seted correctly");
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void FormatSeter_WithWrongFormat()
        {
            DateTimeFormatSeter set = new DateTimeFormatSeter();
            string nowDateTime = string.Empty;
            string format = "/";
            set.FormatSeter(format, out nowDateTime);
        }

        [TestMethod]
        public void FormatSeter_WithWrongFormat_Catch_NoException()
        {
            DateTimeFormatSeter set = new DateTimeFormatSeter();
            string nowDateTime = string.Empty;
            string format = "s/";
            try
            {
                set.FormatSeter(format, out nowDateTime);
            }
            catch (FormatException e)
            {
                // assert 
                ExpectedExceptionAttribute.Equals(e, typeof(FormatException));
                return;
            }
            Assert.Fail("No exception was thrown.");
        }
    }
}
