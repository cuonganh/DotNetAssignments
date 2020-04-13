using System;
using System.Text;

namespace StringForbidden
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
            Console.WriteLine("Original string: ");
            Console.WriteLine(str);

            string[] fob = new string[3];
            fob[0] = "PHP";
            fob[1] = "CLR";
            fob[2] = "Microsoft";

            Console.WriteLine("The expected result:");
            Console.WriteLine(replace(str, fob));

        }

        static string replace(string input, string[] words)
        {
            StringBuilder asterisk = new StringBuilder("*");
            StringBuilder sb = new StringBuilder(input);

            foreach (string w in words)
            {
                while (asterisk.Length < w.Length)
                {
                    asterisk.Append("*");
                }
                sb.Replace(w, asterisk.ToString(0, w.Length));

            }

            return sb.ToString();
        }
    }
}