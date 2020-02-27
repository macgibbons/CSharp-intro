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

            // How to loop over a List of Strings

            // for loops
            for (int i = 0; i < names.Count; i++) {
                Console.WriteLine (names[i]);
            }

            // foreach loops
            foreach (string name in names) {
                Console.WriteLine (name);
            }

            // console logging variables
            Console.WriteLine (message);
            Console.WriteLine (numberOfTacos);
            Console.WriteLine (hasMeat);

            // string concacting 
            Console.WriteLine (message + " " + "I'd like " + numberOfTacos + " tacos. Meat? " + hasMeat);

            // string interpolation 
            Console.WriteLine ($"{message} I'd like {numberOfTacos} tacos. Meat? {hasMeat}");

            // conditional statements
            if (numberOfTacos > 5) {
                Console.WriteLine ("Oh Boy, That's a lotta tacos!");
            } else if (numberOfTacos < 3) {
                Console.WriteLine ("Level up your taco game.");
            } else {
                Console.WriteLine ("Sounds like a good number o' tacos.");
            }

        }
    }
}