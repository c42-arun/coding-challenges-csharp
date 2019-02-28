using System;
using Xunit;

using InterviewCake.matching_parenthesis;

namespace InterviewCake.Tests.matching_parenthesis
{
    public class MatchingParenthesisTest
    {
        [Fact]
        public void AllOpenersThenClosersTest()
        {
            var expected = 7;
            //var actual = MatchingParenthesis.O_of_1_my_solution("((((()))))", 2);
            var actual = MatchingParenthesis.O_of_1_provided_solution("((((()))))", 2);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MixedOpenersAndClosersTest()
        {
            var expected = 10;
            //var actual = MatchingParenthesis.O_of_1_my_solution("()()((()()))", 5);
            var actual = MatchingParenthesis.O_of_1_provided_solution("()()((()()))", 5);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void NoMatchingCloserTest()
        {
            //Assert.Throws<ArgumentException>(() => MatchingParenthesis.O_of_1_my_solution("()(()", 2));
            Assert.Throws<ArgumentException>(() => MatchingParenthesis.O_of_1_provided_solution("()(()", 2));
        }

        [Fact]
        public void AllOpenersThenClosersTestUsingStack()
        {
            var expected = 7;
            var actual = MatchingParenthesis.O_of_N_using_Stack("((((()))))", 2);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MixedOpenersAndClosersTestUsingStack()
        {
            var expected = 10;
            var actual = MatchingParenthesis.O_of_N_using_Stack("()()((()()))", 5);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void NoMatchingCloserTestUsingStack()
        {
            Assert.Throws<ArgumentException>(() => MatchingParenthesis.O_of_N_using_Stack("()(()", 2));
        }
    }
}
