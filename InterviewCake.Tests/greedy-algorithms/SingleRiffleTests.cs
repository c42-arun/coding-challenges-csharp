using InterviewCake.greedy_algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace InterviewCake.Tests.greedy_algorithms
{
    public class SingleRiffleTests
    {
        [Fact]
        public void BothHalvesAreTheSameLengthTest()
        {
            var half1 = new int[] { 1, 4, 5 };
            var half2 = new int[] { 2, 3, 6 };
            var shuffledDeck = new int[] { 1, 2, 3, 4, 5, 6 };
            var result = SingleRiffle.IsSingleRiffle(half1, half2, shuffledDeck);
            Assert.True(result);
        }

        [Fact]
        public void HalvesAreDifferentLengthsTest()
        {
            var half1 = new int[] { 1, 5 };
            var half2 = new int[] { 2, 3, 6 };
            var shuffledDeck = new int[] { 1, 2, 6, 3, 5 };
            var result = SingleRiffle.IsSingleRiffle(half1, half2, shuffledDeck);
            Assert.False(result);
        }

        [Fact]
        public void OneHalfIsEmptyTest()
        {
            var half1 = new int[] { };
            var half2 = new int[] { 2, 3, 6 };
            var shuffledDeck = new int[] { 2, 3, 6 };
            var result = SingleRiffle.IsSingleRiffle(half1, half2, shuffledDeck);
            Assert.True(result);
        }

        [Fact]
        public void ShuffledDeckIsMissingCardsTest()
        {
            var half1 = new int[] { 1, 5 };
            var half2 = new int[] { 2, 3, 6 };
            var shuffledDeck = new int[] { 1, 6, 3, 5 };
            var result = SingleRiffle.IsSingleRiffle(half1, half2, shuffledDeck);
            Assert.False(result);
        }

        [Fact]
        public void ShuffledDeckHasExtraCards()
        {
            var half1 = new int[] { 1, 5 };
            var half2 = new int[] { 2, 3, 6 };
            var shuffledDeck = new int[] { 1, 2, 3, 5, 6, 8 };
            var result = SingleRiffle.IsSingleRiffle(half1, half2, shuffledDeck);
            Assert.False(result);
        }
    }
}
