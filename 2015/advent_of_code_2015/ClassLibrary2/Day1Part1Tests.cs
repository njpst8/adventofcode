using System;
using NUnit.Framework;

namespace Puzzle.Tests
{
    [TestFixture]
    public class Day1Part1Tests
    {
        [TestCase("(())", ExpectedResult = 0L)]
        [TestCase("()()", ExpectedResult = 0L)]
        [TestCase("(((", ExpectedResult = 3L)]
        [TestCase("(()(()(", ExpectedResult = 3L)]
        [TestCase("))(((((", ExpectedResult = 3L)]
        [TestCase("())", ExpectedResult = -1L)]
        [TestCase("))(", ExpectedResult = -1L)]
        [TestCase(")))", ExpectedResult = -3L)]
        [TestCase(")())())", ExpectedResult = -3L)]
        public long Test1(string input)
        {
            return Day1Part1.Execute(input);
        }
    }
}
