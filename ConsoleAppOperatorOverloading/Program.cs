using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using FractionNS;
namespace ConsoleAppOperatorOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction.Precision = 6;
            // int[] ar1 = { 1,2,3};

            // int[] ar2 = { 1,2,3};
            //string str1 = "hello";
            //string str2 = "hello";
            // int n1 = 1;
            // int n2 = 1;

            //WriteLine(ar1 == ar2);
            //WriteLine(ar1.Equals(ar2));
            // WriteLine(object.Equals(ar1, ar2));
            // WriteLine(object.ReferenceEquals(ar1, ar2));
            // WriteLine();
            // WriteLine(str1 == str2);
            // WriteLine(str1.Equals(str2));
            // WriteLine(object.Equals(str1, str2));
            // WriteLine(object.ReferenceEquals(str1, str2));
            // WriteLine();
            // WriteLine(n1 == n2);
            // WriteLine(n1.Equals(n2));
            // WriteLine(object.Equals(n1, n2));
            // WriteLine(object.ReferenceEquals(n1, n2));//boxing

            Fraction f1 = new Fraction(1, 2);
            WriteLine(f1);
            Fraction f2 = new Fraction(1, 2);
            WriteLine(f1 == f2);
            WriteLine(f1.Equals(f2));
            WriteLine($"{f1.GetHashCode()}\t{f2.GetHashCode()}");

            Dictionary<Fraction, double> d = new Dictionary<Fraction, double>();
            d.Add(new Fraction(1, 2), 1.0 / 2);
            d.Add(new Fraction(1, 4), 1.0 / 4);

            WriteLine(d.ContainsKey(new Fraction(1, 2)));
            WriteLine(d.ContainsKey(new Fraction(4, 16)));
            //WriteLine(new Fraction(1, 2) + new Fraction(1, 2));

            //WriteLine(++f1);
            //WriteLine(f1);
            //WriteLine(new Fraction(27, 18).Simplification());

            //Dictionary<string, double> d1 = new Dictionary<string, double>();
            //d1.Add("1/2", 1.0 / 2);
            //d1.Add("1/4", 1.0 / 4);

            //WriteLine(d1.ContainsKey("1/2"));

            //double dn = 1.0;
            //dn += (double)f1;
            //WriteLine(dn);
            //WriteLine((Fraction)dn);

            string str = Console.ReadLine();
            Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();
            foreach (var item in str.Split(' '))
            {
                if (keyValuePairs.ContainsKey(item))
                    keyValuePairs[item]++;
                else
                    keyValuePairs.Add(item, 1);

            }

            foreach (string item in keyValuePairs.Keys)
            {
                WriteLine($"{item}\t{keyValuePairs[item]}");
            }

            //SortedList
        }
    }
}
