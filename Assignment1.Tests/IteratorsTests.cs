using Xunit;
using System.Collections.Generic;
using System;

namespace Assignment1.Tests
{
    

    public class IteratorsTests
    {

        [Fact]

        public void Flatten_returns_stream_of_T()
        {
            //Assign
            var testStream = new List<List<int>> {
                new List<int> {1,2,3,4,5},
                new List<int> {11,22,53,74,85},
                new List<int> {12,25,37,44,52}
            };

            var expected = new List<int> {1,2,3,4,5,11,22,53,74,85,12,25,37,44,52};

            //Act
            var actual = Assignment1.Iterators.Flatten<int>(testStream);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]

        public void Filter_only_returns_even_number(){
            
            //Assign
            Predicate<int> even = Assignment1.Iterators.Even;

            var testStream = new List<int> {1,2,3,4,5,11,22,53,74,85,12,25,37,44,52};

            var expected = new List<int> {2,4,22,74,12,44,52};

            //Act
            var actual = Assignment1.Iterators.Filter<int>(testStream, even);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
