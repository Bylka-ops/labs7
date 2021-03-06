﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    class RationalNumber:IComparable
    {
        private int N { get; set; }
        private int M { get; set; }

        public RationalNumber(int n,int m)
        {
            N = n;
            M = m;
        }

        public RationalNumber()
        {
            N = 0;
            M = 0;
        }

        public RationalNumber(string str)
        {
            string[] rez = str.Split();
            N = Convert.ToInt32(rez[0]);
            M = Convert.ToInt32(rez[1]);
        }

        public void Print()
        {
            Console.WriteLine("{0}/{1}", N, M);
        }

        public static implicit operator int(RationalNumber rationalNumber)
        {
            return rationalNumber.N / rationalNumber.M;
        }

        public static explicit operator double(RationalNumber rationalNumber)
        {
            return rationalNumber.N / rationalNumber.M;
        }

        public static RationalNumber operator +(RationalNumber rationalNumber1, RationalNumber rationalNumber2)
        {
            RationalNumber rez=new RationalNumber();
            rez.N = (rationalNumber1.N * rationalNumber2.M) + (rationalNumber2.N * rationalNumber1.M);
            rez.M = rationalNumber1.M * rationalNumber2.M;
            return rez;
        }

        public static RationalNumber operator -(RationalNumber rationalNumber1, RationalNumber rationalNumber2)
        {
            RationalNumber rez = new RationalNumber();
            rez.N = (rationalNumber1.N * rationalNumber2.M) - (rationalNumber2.N * rationalNumber1.M);
            rez.M = rationalNumber1.M * rationalNumber2.M;
            return rez;
        }

        public static RationalNumber operator *(RationalNumber rationalNumber1, RationalNumber rationalNumber2)
        {
            RationalNumber rez = new RationalNumber();
            rez.N = rationalNumber1.N*rationalNumber2.N;
            rez.M = rationalNumber1.M * rationalNumber2.M;
            return rez;
        }

        public static RationalNumber operator /(RationalNumber rationalNumber1, RationalNumber rationalNumber2)
        {
            RationalNumber rez = new RationalNumber();
            rez.N = rationalNumber1.N * rationalNumber2.M;
            rez.M = rationalNumber1.M * rationalNumber2.N;
            return rez;
        }

        public static bool operator <(RationalNumber rationalNumber1, RationalNumber rationalNumber2)
        {
            return rationalNumber1.N / rationalNumber1.M < rationalNumber2.N / rationalNumber2.M;
        }

        public static bool operator >(RationalNumber rationalNumber1, RationalNumber rationalNumber2)
        {
            return rationalNumber1.N / rationalNumber1.M > rationalNumber2.N / rationalNumber2.M;
        }

        public int CompareTo(object obj)
        {
            RationalNumber rationalNumber1 = obj as RationalNumber;
            return (this.N / this.M).CompareTo(rationalNumber1.N / rationalNumber1.M);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Рациональное число");
            Console.WriteLine("Введите целое чило");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите натуральное чило");
            int M = Convert.ToInt32(Console.ReadLine());
            RationalNumber rationalNumber1 = new RationalNumber(N, M);
            RationalNumber rationalNumber2 = new RationalNumber("12 5");
            rationalNumber1.Print();
            rationalNumber2.Print();
            int intNumber= rationalNumber1;
            double doubleNumber = rationalNumber2;
            Console.WriteLine(intNumber);
            Console.WriteLine(doubleNumber);
            Console.WriteLine(rationalNumber1 + rationalNumber2);
            Console.WriteLine(rationalNumber1 - rationalNumber2);
            Console.WriteLine(rationalNumber1 * rationalNumber2);
            Console.WriteLine(rationalNumber1 / rationalNumber2);
            Console.WriteLine(rationalNumber1 > rationalNumber2);
            Console.WriteLine(rationalNumber1 < rationalNumber2);
            Console.WriteLine(rationalNumber1.CompareTo(rationalNumber2));
            Console.ReadKey();
        }
    }
}
