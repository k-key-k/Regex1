using System.Text.RegularExpressions;

namespace regex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            //Task a)
            /*Console.WriteLine("Enter your string: ");
            string input = Console.ReadLine();
            Regex pattern = new Regex(@"abcd2023111111102023");

            if (pattern.IsMatch(input))
            {
                string result = input.Replace("2023", "happy new year");
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Input string does not match the pattern");
            }*/
            //Task b)
            /* Console.WriteLine("Enter your string: ");
             string input = Console.ReadLine();

             Regex pattern = new Regex(@"\d+");
             MatchCollection Nums = pattern.Matches(input);

             int sums = 0, mx = -1000000, index = 0, count = 0;
             if (Nums.Count > 0)

             {
                 foreach (Match match in Nums)
                 {
                     Console.Write(match.Value + " ");
                     sums += int.Parse(match.Value);
                     if (int.Parse(match.Value) > mx)
                     {
                         mx = int.Parse(match.Value);
                         index = count;
                     }
                     count++;
                 }
             }
             Console.WriteLine($"\nsum = {sums}, max num = {mx} and his index = {index}");*/

            //Task c)
            /*Console.WriteLine("Enter your string: ");
            string input = Console.ReadLine();

            Regex pattern = new Regex(@"[+ -]?\d+(\.|,)?\d+");
            MatchCollection matches = pattern.Matches(input);

            if (matches.Count > 0 )
            {
                foreach (Match match in matches)
                {
                    Console.Write(match.Value + " ");
                }
            }

            Regex pattern2 = new Regex(@"[+ -]?\d+(\.|,)\d+");
            */

            //Task d)
            /*Console.WriteLine("Enter your path to file: ");
            string input = Console.ReadLine();

            Regex pattern = new Regex(@"(?:[a-zA-Z]\:|\\\\[\w\.]+\\[\w]+)\\(?:[\w\s\(\)]+\\)+([\wА-Яа-я\.\s]+)");
            
            if (pattern.IsMatch(input))
            {
                string[] path = input.Split(new char[] { ':', '\\' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string path2 in path)
                {
                    Console.WriteLine(path2 + " ");
                }
            }
            else
            {
                Console.WriteLine("Invalid path input");
            }*/
            
            //Task e)
            /*string input = Console.ReadLine();

            Regex pattern = new Regex(@"^(0[1-9]|[1-2]\d|3[0-1])\/(0[1-9]|1[0-2])\/(\d{4})");

            if (pattern.IsMatch(input))
            {
                Console.WriteLine("Valid date");
            }
            else
            {
                Console.WriteLine("invalid date");
            }*/

            //Task 2
            /*Console.WriteLine("Enter five lines:");

            string[] lines = new string[5];
            for (int i = 0; i < lines.Length; i++)
            {
                lines[i] = Console.ReadLine();
            }

            //Task a)
            Regex pattern = new Regex(@"cat.*cat");

            Console.WriteLine();
            foreach (string line in lines)
            {
                if (pattern.IsMatch(line) )
                {
                    Console.WriteLine(line);
                }
            }
            Console.WriteLine();
            //Task b)
            Regex pattern2 = new Regex(@"\b\w{10,}\b");
            int count = 0;
            foreach (string line in lines)
            {
                if (pattern2.IsMatch(line))
                {
                    string output1 = pattern2.Replace(line, "*");
                    string output2 = pattern2.Replace(line, m => m.Value[0].ToString());
                    string output3 = pattern2.Replace(line, m => new string(m.Value[0], m.Value.Length));

                    Console.WriteLine("Applied to " + (count + 1) + " line");
                    Console.WriteLine("Output 1: " + output1);
                    Console.WriteLine("Output 2: " + output2);
                    Console.WriteLine("Output 3: " + output3 + "\n");
                }
                count++;
            }
            Console.WriteLine();
            //Task c)
            Regex pattern3 = new Regex(@"(\w+)ик\b");

            string replacement = "$1";

            foreach (string line in lines)
            {
                if (pattern3.IsMatch(line))
                {
                    string result = pattern3.Replace(line, replacement);
                    Console.WriteLine(result);
                }
            }
            Console.WriteLine();
            //Task d)
            Regex pattern4 = new Regex(@"([08(F|f)]{6})\b");

            foreach (string line in lines)
            {
                if (pattern4.IsMatch(line) )
                {
                    Console.WriteLine("The string \"" + line + "\" is a valid hexadecimal color identifier in HTML.");
                }
                else
                {
                    Console.WriteLine("The input string does not contain a valid hexadecimal color identifier in HTML.");
                }
            }*/
            //Task 3
            /*string input_pass = Console.ReadLine();

            Regex password = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d_]{8,}$");

            if (password.IsMatch(input_pass))
            {
                Console.WriteLine("Password is strong");
            }
            else
            {
                Console.WriteLine("Password is weak");
            }*/
        }
    }
}