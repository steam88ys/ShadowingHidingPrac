﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ShadowingHidingPrac31
{
    internal class Program
    {
        class Parent
        {
            public int variable = 273;
        }

        class Child : Parent
        {
            public new string variable = "shadowing";
        }

        public static int number = 10;
        static void Main(string[] args)
        {
            int number = 20;
            Console.WriteLine(number);
            Child child = new Child();
            Console.WriteLine(child.variable);
            Parent p = child;
            Console.WriteLine(p.variable);
        }
    }
}