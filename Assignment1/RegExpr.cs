using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Assignment1
{
    public static class RegExpr
    {

        public static void Main(string[] args)
        {
            string input = "Hello how are u im123 go2";
            string input2 = "Yes very good232";
            List<string> lines = new List<string>();
            lines.Add(input);
            lines.Add(input2);
            Console.WriteLine(SplitLine(lines));


        }
        public static IEnumerable<string> SplitLine(IEnumerable<string> lines)
        {
            string pattern = "[^a-zA-Z0-9]";

            foreach (string s in lines)
            {
                foreach (var match in Regex.Split(s, pattern))
                {
                    yield return match;
                }
            }
        }

        public static IEnumerable<(int width, int height)> Resolution(IEnumerable<string> resolutions)
        {
            string pattern = "(?<width>\\d+)[x](?<height>\\d+)";
            foreach (var line in SplitLine(resolutions))
            {
                var match = Regex.Match(line, pattern);
                var width = match.Groups["width"].Captures;
                var height = match.Groups["height"].Captures;
                for (int i = 0; i < height.Count; i++)
                {
                    yield return (int.Parse(width[i].ToString()), int.Parse(height[i].ToString()));
                }

            }
        }
        public static IEnumerable<string> InnerText(string html, string tag)
        {
            var pattern = "<(["+tag+"]).*?>(.*?)</\\1>";
            var matches = Regex.Matches(html, pattern);
        
            foreach (Match match in matches)
            {
                var inner = match.Groups[2].Value;
                var innermatch = Regex.Replace(inner,"<(.*?)>","");
                yield return innermatch;
            }

            
        }
    }
}
