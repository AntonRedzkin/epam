using System;
using ElectronicNotepad;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest1
{
    [TestClass]
    public class UnitTest1
    {
        private TestContext testContextInstance;
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }

        [TestMethod()]
        [DataSource("System.Data.OleDb", "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\"D:\\ENotes.mdb\"",
           "Table1",
           DataAccessMethod.Sequential)]
        public void NoteTest()
        {
            string content = testContextInstance.DataRow["NoteText"].ToString();
            string date = testContextInstance.DataRow["NoteDate"].ToString();
            string newContent = string.Format("Date:{0} \nText:{1}", date, content);
            Note target = new Note(date);
            target.AddText(content);
            Assert.AreEqual(newContent, target.ToString());
        }

        //[TestMethod()]
        //[DataSource("System.Data.OleDb", "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\"D:\\ENotes.mdb\"",
        //   "Table2",
        //   DataAccessMethod.Sequential)]
        //public void NoteTest2()
        //{
        //    string text = testContextInstance.DataRow["Text"].ToString();
        //    string date = testContextInstance.DataRow["Date"].ToString();

        //    string newText = string.Format("Date:{0} \n Text:{1}", date, text); ;

        //    Note target = new Note(date);
        //    target.AddText(text);

        //    Assert.AreEqual(newText, target.ToString());
        //}
    }
}
