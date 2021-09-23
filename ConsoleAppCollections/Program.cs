using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FractionNS;
using static System.Console;
namespace ConsoleAppCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            ArrayList arrayList = new ArrayList(10);//List<Fraction>
            WriteLine($"{arrayList.Count}\t{arrayList.Capacity}");

            arrayList.Add(17);
            arrayList.Add("hello");
            arrayList.Add(3.14);
            arrayList.Add(DateTime.Today);
            foreach (object item in arrayList)
            {
                Write($"{item}\t");
            }
            WriteLine();
            WriteLine($"{arrayList.Count}\t{arrayList.Capacity}");

            //2 Stack
            Stack stack = new Stack(arrayList);//Stack<Fraction>
            foreach (var item in stack)
            {
                Write($"{item}\t");

            }
            WriteLine();
            WriteLine($"{stack.Count}");

            //3 Queue
            Hashtable hashtable = new Hashtable();//Dictionary<Fraction,double>
            hashtable.Add(1, 1);
            hashtable.Add("one", 1);
            hashtable.Add(1.0, 1);
            hashtable.Add(1.0m, 1);
            foreach (DictionaryEntry item in hashtable)
            {
                WriteLine($"{item.Key}\t{item.Value}");
            }
            foreach (object item in hashtable.Keys)
            {
                WriteLine($"{item}\t{hashtable[item]}");
            }

            Dictionary<Fraction, double> dictionary = new Dictionary<Fraction, double>();//Dictionary<Fraction,double>
            dictionary.Add(new Fraction(1, 2), 1.0 / 2);
            dictionary.Add(new Fraction(2, 4), 1.0 / 3);
            dictionary.Add(new Fraction(2, 5), 1.0 / 2);
            foreach (KeyValuePair<Fraction, double> item in dictionary)
            {
                WriteLine($"{item.Key}\t{item.Value}");
            }
            foreach (Fraction item in dictionary.Keys)
            {
                //WriteLine($"{item}\t{dictionary[item]}");
                WriteLine($"{ item}\t{ dictionary[item]}");

            }

            //Dictionary<string, double> dictionary1 = new Dictionary<string, double>();//Dictionary<Fraction,double>
            //dictionary1.Add("o", 1.0 / 2);
            //dictionary1.Add("t1", 1.0 / 3);
            //dictionary1.Add("t", 1.0 / 2);
            //foreach (KeyValuePair<string, double> item in dictionary1)
            //{
            //    WriteLine($"{item.Key}\t{item.Value}");
            //}
            //foreach (string item in dictionary1.Keys)
            //{
            //    //WriteLine($"{item}\t{dictionary[item]}");
            //    WriteLine($"{item}\t{dictionary1[item]}");

            //}
        }
    }
}
