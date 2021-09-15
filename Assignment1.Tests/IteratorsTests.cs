using System.Collections.Generic;
using System;
using Xunit;

namespace Assignment1.Tests {

    public class IteratorsTests {


        [Fact]
        public void FlattenReturnsStreamOfT() {

            var testEnum = new List<List<int>> {
                new List<int> { 0, 1, 2, 3, 4 },
                new List<int> { 5, 6, 7, 8 },
                new List<int> { 9, 10, 11, 12 }
            };


            var test = Assignment1.Iterators.Flatten<int>(testEnum);
            var expected = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            Assert.Equal(test, expected);
        }

        [Fact]
        public void FilterReturnsEven() {

            Predicate<int> even = Assignment1.Iterators.Even;

            var testArray = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            var expected = new List<int> { 0, 2, 4, 6, 8, 10, 12, 14 };

            var actual = Assignment1.Iterators.Filter<int>(testArray, even);

            Assert.Equal(expected, actual);
        }

    }
}
