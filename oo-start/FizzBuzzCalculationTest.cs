using System;
using System.Collections.Generic;
using Xunit;

namespace oo_start
{
    public class FizzBuzzCalculationTest
    {
        [Fact]
        public void should_return_Fizz_when_the_number_is_in_range_1_to_100_and_is_3_times_and_is_not_5_times()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 != 0)
                {
                    Assert.Equal("Fizz", new FizzBuzz(i).calculate());
                }
            }
        }

        [Fact]
        public void should_return_the_number_when_the_number_is_in_range_1_to_100_and_is_not_5_times_and_is_not_3_times()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 || i % 5 == 0) continue;
                Assert.Equal(i.ToString(), new FizzBuzz(i).calculate());
            }
        }

        [Fact]
        public void should_return_Buzz_when_the_number_is_in_range_1_to_100_and_is_not_3_times_and_is_5_times()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 != 0 && i % 5 == 0)
                {
                    Assert.Equal("Buzz", new FizzBuzz(i).calculate());
                }
            }
        }
        
        [Fact]
        public void should_return_FizzBuzz_when_the_number_is_in_range_1_to_100_and_is_3_times_and_is_5_times()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Assert.Equal("FizzBuzz", new FizzBuzz(i).calculate());
                }
            }
        }
        
        [Fact]
        public void  should_return_error_message_when_the_number_is_not_in_range_1_to_100() 
        {
            for (int i = -100; i <= 200; i++)
            {
                if (i < 1 || i > 100)
                {
                    Assert.Equal("Invalid number", new FizzBuzz(i).calculate());
                }
            }
        }
        
        
    }
}