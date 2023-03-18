using System;

//Домашнее задание 2.2

namespace homework2._2
{
    static class ExtensionClass
    {
        public static void ExtensionMethod(this string value)
        {
            Console.WriteLine($"2-ой способ вызова метода, как расширяющего --> {value}");
        }
    }  
}

