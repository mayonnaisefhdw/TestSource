using System;
using Xunit;

namespace test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int i = 2;
            Assert.True(i == 2);
        }

        [Fact]
        public void Test2()
        {
            int i = 2;
            Assert.True(i*2 == 4);
        }
    }
}
