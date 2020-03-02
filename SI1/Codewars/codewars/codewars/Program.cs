using System;
using System.Collections.Generic;
using System.Linq;

namespace codewars
{
    class Kata
    {
        public static int BreakChocolate(int n, int m)
        {
            return n * m > 0 ? n * m - 1 : 0;
        }

        public static IEnumerable<string> FriendOrFoe(string[] names)
        {
            return names.Where(x => x.Length < 5);
        }

        public static int[] SortArray(int[] array)
        {
            Queue<int> odds = new Queue<int>(array.Where(e => e % 2 == 1).OrderBy(e => e));

            return array.Select(e => e % 2 == 1 ? odds.Dequeue() : e).ToArray();
        }

        public static string CreatePhoneNumber(int[] numbers)
        {
            return Convert.ToInt64(string.Concat(numbers)).ToString("(000) 000-0000");
        }

        public static int DuplicateCount(string str)
        {
            return str.GroupBy(x => x).Count(y => y.Count() > 1);
        }

        public static int GetVowelCount(string str)
        {
            return str.ToLower().Count(x => "aeiou".Contains(x));
        }

        public static string High(string s)
        {
            return s.Split(' ').OrderBy(a => a.Select(b => b - 96).Sum()).Last();
        }

        public static bool comp(int[] a, int[] b)
        {
            if (a == null || b == null) return false;
            var result = a.Select(x => x * x).OrderBy(x => x).SequenceEqual(b.OrderBy(x => x));
            return result;
        }

        public static int CountDeafRats(string town)
        {
            var targetDivider = town.Split("P");
            foreach (var item in targetDivider)
            {
                Console.WriteLine(item);
            }
            return 0;
        }

        public static int find_it(int[] seq)
        {
            return seq.GroupBy(x => x).Single(y => y.Count() % 2 != 0).Key;
            /* return seq.GroupBy(x => x)
                .Where(y => y.Count() % 2 != 0)
                .Select(a => a.Key)
                .ToArray()[0]; */
        }

        public static Person find_name(List<Person> codecoolers)
        {
            return codecoolers.Single(codecooler => codecooler.Name.Equals("Avril"));
        }

        public static bool IsPangram(string str)
        {
            return str.ToLower()
                .GroupBy(x => x)
                .Select(x => x.Key > 96 && x.Key < 123)
                .Count() == 26;
        }

        public static int MaxSequence(int[] arr)
        {
            
            return 0;
        }

        public static string Rgb(int r, int g, int b)
        {
            int[] rgb = { r, g, b };
            List<string> resultList = new List<string>();
            foreach (int colorNumber in rgb)
            {
                if (colorNumber > 255) 
                {
                    resultList.Add(15.ToString());
                    resultList.Add(15.ToString());
                }
                else if (colorNumber < 0)
                {
                    resultList.Add(0.ToString());
                    resultList.Add(0.ToString());
                }
                else
                {
                    resultList.Add((colorNumber / 16).ToString());

                    double numberAfterDivide = Convert.ToDouble(colorNumber) / 16;
                    string numberDecimals;
                    try
                    {
                        numberDecimals = numberAfterDivide.ToString().Split(".")[1];
                    }
                    catch (IndexOutOfRangeException)
                    {
                        numberDecimals = 0.ToString();
                    }
                    int numberToAdd = (int)Math.Round(Convert.ToDouble("0." + numberDecimals) * 16);
                    resultList.Add(numberToAdd.ToString());
                }
            }

            for (int i = 0; i < resultList.Count; i++)
            {
                switch (resultList[i])
                {
                    case "10":
                        resultList[i] = "A";
                        break;
                    case "11":
                        resultList[i] = "B";
                        break;
                    case "12":
                        resultList[i] = "C";
                        break;
                    case "13":
                        resultList[i] = "D";
                        break;
                    case "14":
                        resultList[i] = "E";
                        break;
                    case "15":
                        resultList[i] = "F";
                        break;
                    default:
                        break;
                }
            }
            return string.Join("", resultList);
        }

        public static bool Alphanumeric(string str)
        {
            string alphanumeric = string.Join("", Enumerable.Range('A', 26).Select(x => (char)x)).ToLower() + "0123456789";
            str = str.ToLower();
            foreach (char c in str) if (!alphanumeric.Contains(c)) return false;
            return str.Length > 0;
        }

        public static int Smallest(long n)
        {
            return n.ToString().Select(x => Convert.ToInt32(x.ToString())).Min();
        }

        static void Main(string[] args)
        {
            Console.WriteLine(BreakChocolate(0, 0));
            
            foreach (var item in FriendOrFoe(new string[] { "Ryan", "Kieran", "Mark" }))
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            foreach (var item in SortArray(new int[] { 5, 3, 2, 8, 1, 4 }))
            {
                Console.Write(item + " ");
            }

            Console.WriteLine(CreatePhoneNumber(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }));

            Console.WriteLine(DuplicateCount("lolololololjbjhfvfgsfshjgjhffgsgc"));

            Console.WriteLine(GetVowelCount("The longest sentence in English is also awesome."));

            Console.WriteLine(High("The longest sentence in English is also awesome."));

            Console.WriteLine(comp(new int[] { 121, 144, 19, 161, 19, 144, 19, 11 },
                new int[] { 121, 14641, 20736, 361, 25921, 361, 20736, 361 }));

            Console.WriteLine(find_it(new[] { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 }));

            Console.WriteLine(IsPangram("The quick brown fox jumps over the lazy dog."));

            Console.WriteLine(find_name(new List<Person>(){ new Person("lol", 12), new Person("Avril", 26)}).Name);

            Console.WriteLine(Rgb(148, 0, 211));

            Console.WriteLine(Alphanumeric("kuki"));

            Console.WriteLine(Smallest(12324343));
        }
    }
}
