using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainAlgorithmsTests
{
    internal class TestData
    {
        public static List<int> Exp10ArrPositive = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        public static List<int> Exp10ArrNegative = new List<int> { -9, -8, -7, -6, -5, -4, -3, -2, -1 };
        public static List<int> Exp10ArrAllSigns = new List<int> { -9, -8, -7, -6, -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        public static bool CompareArrays(List<int> arr1, List<int> arr2)
        {
            for (int i = 0; i < arr1.Count; i++)
                if (arr1[i] != arr2[i])
                    return false;
            return true;
        }
    }
}
