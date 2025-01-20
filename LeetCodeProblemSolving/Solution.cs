using System.Text.RegularExpressions;

namespace LeetCodeProblemSolving
{
    public static class Solution
    {


        public static IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> pascalTringle = new List<IList<int>>();



            for (int i = 1; i < numRows; i++)
            {
                IList<int> row = new List<int>();

                for (int j = 0; j <= i; j++)
                {


                    if (j == 0 || j == i)
                    {
                        row.Add(1);
                    }
                    else
                    {
                        row.Add(pascalTringle[i - 1][j - 1] + pascalTringle[i - 1][j]);

                    }
                }
                pascalTringle.Add(row);
            }


            return pascalTringle;
        }
        public static int LengthOfLastWord(string s)
        {
            s = s.Trim();
            int length = 0;

            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] != ' ')
                {
                    length++;
                }
                else
                {
                    break;
                }
            }

            return length;
        }

        public static bool IsPalindrome(string s)
        {
            if (s == " " || string.IsNullOrEmpty(s)) return true;


            string pattern = @"[^a-zA-Z0-9]";
            var text = Regex.Replace(s, pattern, replacement: "").ToLower();
            var reversedText = string.Empty;

            for (int i = text.Length - 1; i >= 0; i--)
            {
                reversedText += text[i];
            }

            return text == reversedText;


        }

        public static bool IsSubsequence(string s, string t)
        {

            if (s.Length == 0) return true;

            if (s.Length > t.Length) return false;

            int i = 0, j = 0;

            while (j < t.Length)
            {
                if (s[i] == t[j])
                {
                    i++;
                    j++;
                    if (i == s.Length)
                        return true;
                }
                else
                {
                    j++;

                }

            }

            return false;


        }
    }
}
