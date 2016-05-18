using System;
using Xunit;
using MyAwesomeLibrary.FSharp;

namespace MyAwesomeLibrary.FSharp.Tests
{
    public class Tests
    {
        [Fact]
        public void MessageTest()
        {
            Assert.Equal("Live long and prosper, Captain Kirk", Lib.GetMessage("Captain Kirk"));
        }
    }
}
