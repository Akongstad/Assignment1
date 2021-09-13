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
        [Fact]
        public void InnerHTML_returns_sample()
        {
            var testString = "<p>A <b>regular expression</b>, <b>regex</b> or <b>regexp</b> (sometimes called a <b>rational expression</b>) is, in <a href=/wiki/Theoretical_computer_science title=Theoretical computer science>theoretical computer science</a> and <a href=/wiki/Formallanguage title=Formal language>formal language</a> theory, a sequence of <a href=/wiki/Character(computing) title=Character (computing)>characters</a> that define a <i>search <a href=/wiki/Pattern_matching title=Pattern matching>pattern</a></i>. Usually this pattern is then used by <a href=/wiki/String_searchingalgorithm title=String searching algorithm>string searching algorithms</a> for find or find and replace operations on <a href=/wiki/String(computer_science) title=String (computer science)>strings</a>.</p>";
            var expected = new List<string> {"theoretical computer science", "formal language", "characters", "pattern", "string searching algorithms", "strings"};
            Assert.Equal(expected, Assignment1.RegExpr.InnerText(testString, "a"));
        }
    }
}
