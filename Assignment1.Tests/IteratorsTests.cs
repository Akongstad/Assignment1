using Xunit;
using System.Collections.Generic;

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
    }
}
