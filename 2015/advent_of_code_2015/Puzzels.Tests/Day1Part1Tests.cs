using System;
using NUnit.Framework;

namespace Puzzle.Tests
{
    [TestFixture]
    public class Day1Part1Tests
    {
        [TestCase("(())", 0)]
        [TestCase("(())", 0)]
        [TestCase("(())", 3)]
        [TestCase("(())", 3)]
        [TestCase("(())", 3)]
        [TestCase("(())", -1)]
        [TestCase("(())", -1)]
        [TestCase("(())", -3)]
        [TestCase("(())", -3)]
        public long Test(string input, long expectedFloor)
        {
            return Day1Part1.Execute(input);
        }
    }
}
