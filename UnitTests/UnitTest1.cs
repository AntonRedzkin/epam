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
            InputerFromConsole inputer = new InputerFromConsole();
            Assert.AreEqual(BLACK, inputer.ParseColor("Black"));
        }

        [TestMethod]
        public void Inputer_ParseColor_ValidLowercaseInput_Test()
        {
            InputerFromConsole inputer = new InputerFromConsole();
            Assert.AreEqual(WHITE, inputer.ParseColor("white"));
        }

        [TestMethod]
        public void Inputer_ParseColor_ValidLowercaseShortInput_Test()
        {
            InputerFromConsole inputer = new InputerFromConsole();
            Assert.AreEqual(BLACK, inputer.ParseColor("b"));
        }

        [TestMethod]
        public void Inputer_ParseColor_ValidUppercaseShortInput_Test()
        {
            InputerFromConsole inputer = new InputerFromConsole();
            Assert.AreEqual(WHITE, inputer.ParseColor("W"));
        }
        
        [TestMethod]
        [ExpectedException(typeof(FormatException), "Invalid format or color.")]
        public void Inputer_ParseColor_InvalidInput_Test()
        {
            InputerFromConsole inputer = new InputerFromConsole();
            inputer.ParseColor("a");
        }

        [TestMethod]
        public void Inputer_ParsePosition_ValidInputUppercaseInput_Test()
        {
            InputerFromConsole inputer = new InputerFromConsole();
            int[] a1 = new int[2];
            a1[0] = 1;
            a1[1] = 1;
            Assert.AreEqual(a1, inputer.ParsePosition("A1"));
        }

        [TestMethod]
        public void Inputer_ParsePosition_ValidInputLowercaseInput_Test()
        {
            InputerFromConsole inputer = new InputerFromConsole();
            int[] h8 = new int[2];
            h8[0] = 8;
            h8[1] = 8;
            Assert.AreEqual(h8, inputer.ParsePosition("h8"));
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException), "Only black fields are allowed")]
        public void Inputer_ParsePosition_InputWhiteField_Test()
        {
            InputerFromConsole inputer = new InputerFromConsole();
            inputer.ParsePosition("a2");
        }
        
        [TestMethod]
        [ExpectedException(typeof(FormatException), "Wrong format of coordinate")]
        public void Inputer_ParsePosition_InputNotLetter_Test()
        {
            InputerFromConsole inputer = new InputerFromConsole();
            inputer.ParsePosition("11");
        }
                
        [TestMethod]
        [ExpectedException(typeof(FormatException), "Wrong format of coordinate")]
        public void Inputer_ParsePosition_InputEarlierDigit_Test()
        {
            InputerFromConsole inputer = new InputerFromConsole();
            inputer.ParsePosition("i0");
        }

        [TestMethod]
        public void StepsCalculater_Move_BlackChecker_ReachableSquare_Test()
        {
            Board board = new Board();
            Algorithm stepsCalculater = new Algorithm(ref board);
            Checkers checker = new Checkers();
            checker.Color = BLACK;
            checker.PositionX = 8;
            checker.PositionY = 8;
            int wantedSquare = 1;
            stepsCalculater.FindNumberOfSteps(checker, wantedSquare);
            int expectedNumOfSteps = 7;
            Assert.AreEqual(expectedNumOfSteps, stepsCalculater.NumberOfSteps );
        }

        [TestMethod]
        public void StepsCalculater_Move_WhiteChecker_ReachableSquare_Test()
        {
            Board board = new Board();
            Algorithm stepsCalculater = new Algorithm(ref board);
            Checkers checker = new Checkers();
            checker.Color = WHITE;
            checker.PositionX = 1;
            checker.PositionY = 1;
            int wantedSquare = 64;
            stepsCalculater.FindNumberOfSteps(checker, wantedSquare);
            int expectedNumOfSteps = 7;
            Assert.AreEqual(expectedNumOfSteps, stepsCalculater.NumberOfSteps);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Position is unreachable.")]
        public void StepsCalculater_Move_BlackChecker_UnreachableSquare_Test()
        {
            Board board = new Board();
            Algorithm stepsCalculater = new Algorithm(ref board);
            Checkers checker = new Checkers();
            checker.Color = BLACK;
            checker.PositionX = 4;
            checker.PositionY = 4;
            int wantedSquare = 32;
            stepsCalculater.FindNumberOfSteps(checker, wantedSquare);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Position is unreachable.")]
        public void StepsCalculater_Move_WhiteChecker_UnreachableSquare_Test()
        {
            Board board = new Board();
            Algorithm stepsCalculater = new Algorithm(ref board);
            Checkers checker = new Checkers();
            checker.Color = WHITE;
            checker.PositionX = 4;
            checker.PositionY = 4;
            int wantedSquare = 32;
            stepsCalculater.FindNumberOfSteps(checker, wantedSquare);
        }
    }
}
