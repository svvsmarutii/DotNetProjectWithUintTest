using System;
using Xunit;
using simpleapi.Controllers;

namespace simpleapi.test
{
    public class UnitTest1
    {
        ValuesController controller = new ValuesController();
        [Fact]
        public void mytestone()
        {
            var returnvalue = controller.Get(1);
            Assert.Equal("Something else", returnvalue.Value);
        }


        [Fact]
        public void Test1()
        {
            var returnvalue = controller.Get("vardhan");
            Assert.Equal("lux", returnvalue.Value);
        }
    }
}
