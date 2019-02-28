using InterviewCake.sorting;
using Xunit;

namespace InterviewCake.Tests.sorting
{
    public class FindRepeatTests
    {
        [Fact]
        public void JustTheRepeatedNumberTest()
        {
            var numbers = new int[] { 1, 1 };
            var expected = 1;
            var actual = FindRepeatSpaceEdition.FindRepeat(numbers);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShortArrayTest()
        {
            var numbers = new int[] { 1, 2, 3, 2 };
            var expected = 2;
            var actual = FindRepeatSpaceEdition.FindRepeat(numbers);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MediumArrayTest()
        {
            var numbers = new int[] { 1, 2, 5, 5, 5, 5 };
            var expected = 5;
            var actual = FindRepeatSpaceEdition.FindRepeat(numbers);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void LongArrayTest()
        {
            var numbers = new int[] { 4, 1, 4, 8, 3, 2, 7, 6, 5 };
            var expected = 4;
            var actual = FindRepeatSpaceEdition.FindRepeat(numbers);
            Assert.Equal(expected, actual);
        }
    }
}
