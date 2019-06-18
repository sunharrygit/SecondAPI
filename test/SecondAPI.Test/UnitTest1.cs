using System;
using Xunit;
using SecondAPI.Controllers;

namespace SecondAPI.Test
{
    public class UnitTest1
    {
        ValuesController controller = new ValuesController();
        [Fact]
        public void GetReturnsMyName()
        {
            var returnValue = controller.Get(1);
            Assert.Equal("Les Jackson", returnValue.Value);
    
        }

        [Fact]
        public void Test1()
        {

        }
    }
}
