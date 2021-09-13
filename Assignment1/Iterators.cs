using System;
using System.Collections.Generic;

namespace Assignment1 {
    public static class Iterators {

        public static void Main(string[] args) {

            Console.WriteLine("Starting!");

            var test = new List<string> { "1920x1080", "1024x768, 800x600, 640x480", "320x200, 320x240, 800x600", "1280x960" };

            var t = RegExpr.Resolution(test);

            foreach (var bib in t) {
                Console.WriteLine($"({bib.width}, {bib.height})");
            }
        }

        public static bool Even(int i) {
            return i % 2 == 0;
        }


        public static IEnumerable<T> Flatten<T>(IEnumerable<IEnumerable<T>> items) {
            foreach (var item in items) {
                foreach (var i in item) {
                    yield return i;
                }
            }
        }

        public static IEnumerable<T> Filter<T>(IEnumerable<T> items, Predicate<T> predicate) {
            foreach (var item in items) {
                if (predicate(item)) {
                    yield return item;
                }
            }
        }
    }
}
