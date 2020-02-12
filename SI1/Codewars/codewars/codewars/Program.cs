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
        }
    }
}
