using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dev_12;

namespace UnitTests
{
    [TestClass]
    public class UnitTests1
    {
        public const int BLACK = 1;
        public const int WHITE = 0;

        [TestMethod]
        public void Inputer_ParseColor_ValidUppercaseInput_Test()
        {
            Inputer inputer = new Inputer();
            Assert.AreEqual(BLACK, inputer.ParseColor("Black"));
        }

        [TestMethod]
        public void Inputer_ParseColor_ValidLowercaseInput_Test()
        {
            Inputer inputer = new Inputer();
            Assert.AreEqual(WHITE, inputer.ParseColor("white"));
        }

        [TestMethod]
        public void Inputer_ParseColor_ValidLowercaseShortInput_Test()
        {
            Inputer inputer = new Inputer();
            Assert.AreEqual(BLACK, inputer.ParseColor("b"));
        }

        [TestMethod]
        public void Inputer_ParseColor_ValidUppercaseShortInput_Test()
        {
            Inputer inputer = new Inputer();
            Assert.AreEqual(WHITE, inputer.ParseColor("W"));
        }
        
        [TestMethod]
        [ExpectedException(typeof(FormatException), "Invalid format or color.")]
        public void Inputer_ParseColor_InvalidInput_Test()
        {
            Inputer inputer = new Inputer();
            inputer.ParseColor("a");
        }

        [TestMethod]
        public void Inputer_ParsePosition_ValidInputUppercaseInput_Test()
        {
            Inputer inputer = new Inputer();
            int[] a1 = { 1, 1};
            Assert.AreEqual(a1, inputer.ParsePosition("A1"));
        }

        [TestMethod]
        public void Inputer_ParsePosition_ValidInputLowercaseInput_Test()
        {
            Inputer inputer = new Inputer();
            int[] h8 = { 8, 8 };
            Assert.AreEqual(h8, inputer.ParsePosition("h8"));
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException), "Only black fields are allowed")]
        public void Inputer_ParsePosition_InputWhiteField_Test()
        {
            Inputer inputer = new Inputer();
            inputer.ParsePosition("a2");
        }
        
        [TestMethod]
        [ExpectedException(typeof(FormatException), "Wrong format of coordinate")]
        public void Inputer_ParsePosition_InputNotLetter_Test()
        {
            Inputer inputer = new Inputer();
            inputer.ParsePosition("11");
        }
                
        [TestMethod]
        [ExpectedException(typeof(FormatException), "Wrong format of coordinate")]
        public void Inputer_ParsePosition_InputEarlierDigit_Test()
        {
            Inputer inputer = new Inputer();
            inputer.ParsePosition("i0");
        }

        [TestMethod]
        public void StepsCalculater_Move_BlackReachableField_Test()
        {
            Board board = new Board();
            StepsCalculater stepsCalculater = new StepsCalculater();
            Checkers checker = new Checkers();
            checker.Color = BLACK;
            checker.PositionX = 8;
            checker.PositionY = 8;
            Assert.AreEqual(7, stepsCalculater.Move(checker, board, board.Select(1)));
        }

        [TestMethod]
        public void StepsCalculater_Move_WhiteReachableField_Test()
        {
            Board board = new Board();
            StepsCalculater stepsCalculater = new StepsCalculater();
            Checkers checker = new Checkers();
            checker.Color = WHITE;
            checker.PositionX = 1;
            checker.PositionY = 1;
            Assert.AreEqual(7, stepsCalculater.Move(checker, board, board.Select(64)));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Position is unreachable.")]
        public void StepsCalculater_Move_BlackUnreachableField_Test()
        {
            Board board = new Board();
            StepsCalculater stepsCalculater = new StepsCalculater();
            Checkers checker = new Checkers();
            checker.Color = BLACK;
            checker.PositionX = 4;
            checker.PositionY = 4;
            stepsCalculater.Move(checker, board, board.Select(32));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Position is unreachable.")]
        public void StepsCalculater_Move_WhiteUnreachableField_Test()
        {
            Board board = new Board();
            StepsCalculater stepsCalculater = new StepsCalculater();
            Checkers checker = new Checkers();
            checker.Color = WHITE;
            checker.PositionX = 4;
            checker.PositionY = 4;
            stepsCalculater.Move(checker, board, board.Select(32));
        }
    }
}
