using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCode.Tests
{
    [TestClass]
    public class PuzzlesTests
    {
        [TestMethod]
        public void Day1Part1()
        {
            //1122 produces a sum of 3(1 + 2) because the first digit(1) matches the second digit and the third digit(2) matches the fourth digit.
            //1111 produces 4 because each digit(all 1) matches the next.
            //1234 produces 0 because no digit matches the next.
            //91212129 produces 9 because the only digit that matches the next one is the last digit, 9.

            var case1 = Puzzles.Day1.Part1("1122");
            var case2 = Puzzles.Day1.Part1("1111");
            var case3 = Puzzles.Day1.Part1("1234");
            var case4 = Puzzles.Day1.Part1("91212129");

            Assert.AreEqual(3, case1);
            Assert.AreEqual(4, case2);
            Assert.AreEqual(0, case3);
            Assert.AreEqual(9, case4);
        }

        [TestMethod]
        public void Day1Part2()
        {
            //1212 produces 6: the list contains 4 items, and all four digits match the digit 2 items ahead.
            //1221 produces 0, because every comparison is between a 1 and a 2.
            //123425 produces 4, because both 2s match each other, but no other digit has a match.
            //123123 produces 12.
            //12131415 produces 4.

            var case1 = Puzzles.Day1.Part2("1212");
            var case2 = Puzzles.Day1.Part2("1221");
            var case3 = Puzzles.Day1.Part2("123425");
            var case4 = Puzzles.Day1.Part2("123123");
            var case5 = Puzzles.Day1.Part2("12131415");

            Assert.AreEqual(6, case1);
            Assert.AreEqual(0, case2);
            Assert.AreEqual(4, case3);
            Assert.AreEqual(12, case4);
            Assert.AreEqual(4, case5);
        }

        [TestMethod]
        public void Day2Part1()
        {
            string[] lines = new string[]
            {
                "5  1   9   5",
                "7  5   3",
                "2  4   6   8"
            };

            var case1 = Puzzles.Day2.Part1(lines);

            Assert.AreEqual(18, case1);
        }

        [TestMethod]
        public void Day2Part2()
        {
            string[] lines = new string[]
            {
                "5 9 2 8",
                "9 4 7 3",
                "3 8 6 5"
            };

            var case1 = Puzzles.Day2.Part2(lines);

            Assert.AreEqual(9, case1);
        }

        [TestMethod]
        public void Day3Part1()
        {

            var case1 = Puzzles.Day3.Part1(1);
            var case2 = Puzzles.Day3.Part1(12);
            var case3 = Puzzles.Day3.Part1(23);
            var case4 = Puzzles.Day3.Part1(1024);

            Assert.AreEqual(0, case1);
            Assert.AreEqual(3, case2);
            Assert.AreEqual(2, case3);
            Assert.AreEqual(31, case4);
        }
    }
}
