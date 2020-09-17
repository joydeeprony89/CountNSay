using System;

namespace CountNSay
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the nth no you want to print!");
            var input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(countAndSay(input));
        }

        static string countAndSay(int n)
        {
            string s = "";
            switch (n)
            {
                case 1: s = "1"; break;
                case 2: s = "11"; break;
                case 3: s = "21"; break;
                case 4: s = "1211"; break;
                case 5: s = "111221"; break;
                case 6: s = "312211"; break;
                case 7: s = "13112221"; break;
                case 8: s = "1113213211"; break;
                case 9: s = "31131211131221"; break;
                case 10: s = "13211311123113112211"; break;
                default: break;
            }
            if (n > 10)
            {
                s = "13211311123113112211";
                string ans;
                for (int i = 10; i < n; i++)
                {
                    ans = string.Empty;
                    char last = s[0];
                    int count = 1;
                    for (int j = 1; j < s.Length; j++)
                    {
                        char ch = s[j];
                        if (last == ch)
                        {
                            count++;
                        }
                        else
                        {
                            ans += count + "" + last;
                            last = ch;
                            count = 1;
                        }
                    }
                    ans += count + "" + last;
                    s = ans;
                }
            }
            return s;
        }
    }
}
