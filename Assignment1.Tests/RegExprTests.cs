using Xunit;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Assignment1.Tests
{
    public class RegExprTests
    {
        [Fact]
        public void SplitLine_splits_line_to_words()
        {
            
            string input = "Hello how are u im123 go2";
            string input2 = "Yes very good232";
            List<string> lines = new List<string>();
            lines.Add(input);
            lines.Add(input2);
            //Console.WriteLine(Assignment1.RegExpr.SplitLine(lines));
            
            var expected = new List<string>();
            expected.Add("Hello");
            expected.Add("how");
            expected.Add("are");
            expected.Add("u");
            expected.Add("im123");
            expected.Add("go2");
            expected.Add("Yes");
            expected.Add("very");
            expected.Add("good232");
            Assert.Equal(expected, Assignment1.RegExpr.SplitLine(lines));
        }
        [Fact]
        public void Resoulution_passes_sample()
        {
            var sample = new List<string> {"1920x1080", "1024x768, 800x600, 640x480", "320x200, 320x240, 800x600", "1280x960"};
            var expected = new (int, int)[] {(1920, 1080),(1024,768),(800,600),(640, 480),(320, 200),(320, 240),(800, 600),(1280, 960)};
            var actual = Assignment1.RegExpr.Resolution(sample);
            Assert.Equal(expected, actual);
        }
    }
}
