using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Assignment1 {
    public static class RegExpr {
        public static IEnumerable<string> SplitLine(IEnumerable<string> lines) {
            foreach (var line in lines) {
                var words = Regex.Split(line, "[^a-zA-Z0-9]");
                foreach (var word in words) {
                    yield return word;
                }
            }
        }

        public static IEnumerable<(int width, int height)> Resolution(IEnumerable<string> resolutions) {

            foreach (var line in SplitLine(resolutions)) {

                var match = Regex.Match(line, "(?<width>[0-9]+)[x](?<height>[0-9]+)");
                var width = match.Groups["width"].Captures;
                var height = match.Groups["height"].Captures;

                for (var i = 0; i < height.Count; i++) {
                    yield return (int.Parse(width[i].ToString()), int.Parse(height[i].ToString()));
                }
            }

        }

        public static IEnumerable<string> InnerText(string html, string tag) {
            throw new NotImplementedException();
        }
    }
}
