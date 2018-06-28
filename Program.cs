using System;

namespace HashFunction
{
    class Program
    {
        static int[] dict = new int[150];

        static void Main(string[] args)
        {
            

            Console.WriteLine("this = " + HashCode("this", 0.2));
            Console.WriteLine("hits = " + HashCode("hits", 0.2));
            Console.WriteLine("shit = " + HashCode("shit", 0.2));

            insert("this", 2);
            insert("shit", 10);

            Console.WriteLine("get(\"this\") = " + get("this"));
            Console.WriteLine("get(\"shit\") = " + get("shit"));


            Console.ReadKey();
        }

        public static void insert(string key, int value)
        {
            dict[HashCode(key, 0.2)] = value;
        }

        public static int get(string key)
        {
            return dict[HashCode(key, 0.2)];
        }

        public static int HashCode(String s, double g)
        {
            return s.Length == 0 ? 0 : (int)(HashCode(s.Substring(1, s.Length - 1), g) + (s[0] * Math.Pow(g, (double)s.Length - 1)));
        }
    }
}
