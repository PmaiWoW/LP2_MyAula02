using System;

namespace Tuples
{
    class Program
    {
        private static Random rnd;

        static void Main(string[] args)
        {
            rnd = new Random();
            int i;
            double d;
            bool b;

            object[] objs1 = GetStuff1();
            Console.WriteLine("Return by Array:");
            foreach (object o in objs1) { Console.WriteLine(o); }

            Tuple<int, double, bool> objs2 = GetStuff2();
            Console.WriteLine($"\nReturn by Tuple:\nint: {objs2.Item1} double: {objs2.Item2} " +
                $"bool: {objs2.Item3}");

            Stuff objs3 = GetStuff3();
            Console.WriteLine($"\nReturn by Struct:\nint: {objs3.I} double: " +
                $"{objs3.D} bool: {objs3.B}");

            GetStuff4(out i, out d, out b);
            Console.WriteLine($"\nReturn by Out:\nint: {i} double: {d} " +
                $"bool: {b}");

        }

        private static object[] GetStuff1()
        {
            object[] objs = new object[3];
            objs[0] = rnd.Next();
            objs[1] = rnd.NextDouble();
            objs[2] = rnd.NextDouble() < 0.5;
            return objs;
        }

        private static Tuple<int, double, bool> GetStuff2()
        {
            Tuple<int, double, bool> objs = new Tuple<int, double,
                bool>(rnd.Next(), rnd.NextDouble(), rnd.NextDouble() < 0.5);
            return objs;
        }

        private static Stuff GetStuff3()
        {
            Stuff objs = new Stuff(rnd.Next(), rnd.NextDouble(), 
                rnd.NextDouble() < 0.5);
            return objs;
        }

        private static void GetStuff4(out int i, out double d, out bool b)
        {
            i = rnd.Next();
            d = rnd.NextDouble();
            b = rnd.NextDouble() < 0.5;
        }
    }
}
