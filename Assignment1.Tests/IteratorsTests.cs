using Xunit;
using System.Collections.Generic;
using System;

namespace Assignment1.Tests
{
    public class IteratorsTests
    {
        [Fact]
        public void Flatten_returns_single_stream()
        {
            var streamStream = new List<List<int>>();
            streamStream.Add(new List<int> {1,2,3,4,5});
            streamStream.Add( new List<int> {6,7,8,9,10});
            streamStream.Add( new List<int> {11,12,13,14,15});
            var expected = new List<int>{1,2,3,4,5,6,7,8,9,10,11,12,13,14,15};
            Assert.Equal(expected,Assignment1.Iterators.Flatten(streamStream));

        }
        [Fact]
        public void filter_1to15_returns_only_even()
        {
            Predicate<int> even = Assignment1.Iterators.Even;
            var actual = new List<int>{1,2,3,4,5,6,7,8,9,10,11,12,13,14,15};
            var expected = new List<int>{2,4,6,8,10,12,14};
            Assert.Equal(expected, Assignment1.Iterators.Filter(actual, even));
    
        }
    }
}
