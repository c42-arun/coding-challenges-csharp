using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace InterviewCake.Tests
{
    public class Class1
    {
        [Fact]
        public void PassingTest()
        {
            Assert.Equal(4, Add(2, 2));
        }

        [Fact]
        public void FailingTest()
        {
            Assert.NotEqual(5, Add(2, 2));
        }

        [Theory]
        [InlineData(3)]
        [InlineData(5)]
        //[InlineData(6)]
        public void MyFirstTheory(int value)
        {
            Assert.True(IsOdd(value));
        }

        int Add(int x, int y)
        {
            return x + y;
        }

        bool IsOdd(int value)
        {
            return value % 2 == 1;
        }
    }
}
