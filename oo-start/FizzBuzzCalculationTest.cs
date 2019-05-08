using System;
using System.Collections.Generic;
using Xunit;

namespace oo_start
{
    public class FizzBuzzCalculationTest
    {
        [Fact]
        public void should_return_Fizz_when_number_is_3()
        {
            Assert.Equal("Fizz", new  FizzBuzz(3).calculate());
        }

    }
}