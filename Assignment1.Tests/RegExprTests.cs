using System;
using System.Collections.Generic;
using Xunit;

namespace Assignment1.Tests {
    public class RegExprTests {

        [Fact]
        public void SplitLineIntoWords() {
            var testArray = RegExpr.SplitLine(new List<string> { "awd dawdwa lolol", "diawd123 r432 lasd" });
            var expected = new List<string> { "awd", "dawdwa", "lolol", "diawd123", "r432", "lasd" };

            var actual = Assignment1.RegExpr.SplitLine(testArray);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PrintResolutionPrLine() {
            var testArray = new List<string> { "1920x1080", "1024x768, 800x600" };
            var expected = new (int, int)[] { (1920, 1080), (1024, 768), (800, 600) };
            var actual = Assignment1.RegExpr.Resolution(testArray);


            Assert.Equal(expected, actual);

        }
    }
}
