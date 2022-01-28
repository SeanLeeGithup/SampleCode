using SampleCode;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class StringHelperTest
    {
        [Fact]
        public void StringReverseWillReturnFullStringReversed()
        {
            Assert.Equal("sA tseT", StringHelper.ReverseString("Test As"));
        }

        [Fact]
        public void ReverseStringAsArrWillReturnWordReverseInString()
        {
            Assert.Equal("tseT sA", StringHelper.ReverseStringAsArr("Test As"));
        }
    }
}
