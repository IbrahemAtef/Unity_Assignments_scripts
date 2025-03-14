using UnityEngine;

namespace Assignment29
{
    public static class Utilities
    {
        public static int Add(params int[] numbers)
        {
            if (numbers.Length == 0) return -1;
            int result = 0;
            foreach (int n in numbers)
                result += n;
            return result;
        }

        public static string RepeatString(this string str, int n)
        {
            string result = "";
            for (int i = 0; i < n; i++)
                result += str;
            return result;
        }
    }
}
