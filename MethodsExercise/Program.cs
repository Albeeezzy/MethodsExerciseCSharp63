﻿namespace MethodsExercise
{
    public class Program
    {
        public static void Introduction(string guest)
        {
            //Console.WriteLine($"Hello {guest}!  Welcome to dragon flying school!  Since this is your first time with us we need to gather information about you before we get started!");
        }

        public static void DataCollection()
        {
            //Console.WriteLine("First, please us what your name is:");
            //string name = Console.ReadLine();
            //Console.WriteLine($"Welcome {name}, my name is Jason!  It will be a pleasure working with you. Next please tell us your favorite type of dragon:");
            //string dragon = Console.ReadLine();
            //Console.WriteLine($"Woah, the {dragon} is also my favorite type!  How old are you?");
            //string age = Console.ReadLine();
            //Console.WriteLine($"You're {age}?!  You look a lot younger!  Alright, last question!  What is your favorite food?");
            //string food = Console.ReadLine();
            //Console.WriteLine($"Yum!  Well {name}, that is all the information I needed from you!  I will ensure you get assigned to a {dragon} for your upcoming lessons, and ensure there is plenty of {food} for you to eat!  Good luck with your upcoming lessons!");
            
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Multiply(int c, int d)
        {
            return c * d;
        }

        public static int Divide(int e, int f)
        {
            return e / f;
        }

        public static int Subtract(int g, int h)
        {
            return g - h;
        }
        
        static void Main(string[] args)
        {
            //Introduction(guest:"Newbie");
            
            //DataCollection();
            
            Console.WriteLine(Add(5, 4));
            Console.WriteLine(Multiply(3, 6));
            
            int sum = Add(a: 5, b: 7);
            Console.WriteLine(sum);
            
            int multiply = Multiply(c: 21, d: 4);
            Console.WriteLine(multiply);

            int add = Add(a: 3, b: 50) + Multiply(c: 5, d: 10);
            Console.WriteLine(add);
            
            int divide = Multiply(10, 30) / Divide(20, 5);
            Console.WriteLine(divide);
            
            
        }
    }
}
