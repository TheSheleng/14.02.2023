using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._02._2023
{
    class Arr : ICalc, ICalc2, IOutput2
    {
        public int[] arr;
        public int Less(int valueToCompare)
        {
            int res = 0;
            foreach (int i in arr)
            {
                if (i < valueToCompare) res++;
            }
            return res;
        }
        public int Greater(int valueToCompare)
        {
            int res = 0;
            foreach (int i in arr)
            {
                if (i > valueToCompare) res++;
            }
            return res;
        }
        public void ShowEven()
        {
            foreach (int i in arr)
            {
                if (i % 2 ==  0) Console.WriteLine($"{i} ");
            }
        }
        public void ShowOdd()
        {
            foreach (int i in arr)
            {
                if (i % 2 == 1) Console.WriteLine($"{i} ");
            }
        }
        public int CountDistinct()
        {
            List<int> unic = new List<int>();

            foreach (int i in arr)
            {
                if (unic.FindIndex(item => item == i) == -1 && )
                    unic.Add(i);
            }
            return unic.Count;
        }
        public int EqualToValue(int valueToCompare)
        {
            int res = 0;
            foreach (int i in arr)
            {
                if (i == valueToCompare) res++;
            }
            return res;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
