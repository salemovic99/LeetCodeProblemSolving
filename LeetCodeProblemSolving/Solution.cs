using System.Text.RegularExpressions;

namespace LeetCodeProblemSolving
{
    public static class Solution
    {

        public static int RomanToInt(string s)
        {
            Dictionary<char, int> map = new Dictionary<char, int>
                    {
                        { 'I', 1 }, { 'V', 5 }, { 'X', 10 },
                        { 'L', 50 }, { 'C', 100 }, { 'D', 500 }, { 'M', 1000 }
                    };

            int result = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (i != s.Length - 1)
                {
                    if (map[s[i]] < map[s[i + 1]])
                    {
                        result -= map[s[i]];
                    }
                    else
                    {
                        result += map[s[i]];
                    }

                }
            }

            result += map[s[s.Length - 1]];
            return result;
        }
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
