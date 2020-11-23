using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyFirstAppCSharp {
    public static class EntiersExtension {


        public static bool isDivisible(this int value, int divisor) {
            return value % divisor == 0;
        }

        public static IEnumerable<int> FilterByDivisible(this IEnumerable<int> values, int divisor) {
            return values.Where((v) => v.isDivisible(divisor));
        }

        public static IEnumerable<int> FilterByPositive(this IEnumerable<int> values) {
            return values.Where((v) => v>=0);
        }
    }
}
