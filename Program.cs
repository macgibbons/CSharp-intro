using System;
using System.Collections.Generic;

namespace MyApp2 {
    class Program {
        static void Main (string[] args) {

            // defining variables - C# is type specific
            string message = "hello world";
            int numberOfTacos = 10;
            bool hasMeat = false;
            List<string> names = new List<string> () { "Adam", "Brenda", "Rose" };

            // console logging variables
            Console.WriteLine (message);
            Console.WriteLine (numberOfTacos);
            Console.WriteLine (hasMeat);

            // string concacting 
            Console.WriteLine (message + " " + "I'd like " + numberOfTacos + " tacos. Meat? " + hasMeat);

            // string interpolation 
            Console.WriteLine ($"{message} I'd like {numberOfTacos} tacos. Meat? {hasMeat}");

        }
    }
}