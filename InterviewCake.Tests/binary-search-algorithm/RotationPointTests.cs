using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

using InterviewCake.sorting_searching_logs;

namespace InterviewCake.Tests.binary_search_algorithm
{
    public class RotationPointTests
    {
        [Fact]
        public void SmallArrayTest()
        {
            var actual = RotationPointSolution.FindRotationPoint(new string[] { "cape", "cake" });
            var expected = 1;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MediumArrayTest()
        {
            var actual = RotationPointSolution.FindRotationPoint(new string[] { "grape", "orange", "plum", "radish",
            "apple" });
            var expected = 4;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void LargeArrayTest()
        {
            var actual = RotationPointSolution.FindRotationPoint(
                new string[] { "ptolemaic", "retrograde", "supplant", "undulate", "xenoepist",
            "asymptote", "babka", "banoffee", "engender", "karpatka", "othellolagkage" });
            var expected = 5;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PossiblyMissingEdgeCaseTest()
        {
            // Are we missing any edge cases?
        }
    }
}
