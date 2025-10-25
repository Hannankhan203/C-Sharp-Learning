using System;

namespace ExamProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Basic C# Exam Program ===");
            
            // Variables and Data Types
            int number = 10;
            double decimalNumber = 3.14;
            string text = "Hello World";
            bool isTrue = true;
            
            Console.WriteLine($"\n--- Variables and Data Types ---");
            Console.WriteLine($"Integer: {number}");
            Console.WriteLine($"Double: {decimalNumber}");
            Console.WriteLine($"String: {text}");
            Console.WriteLine($"Boolean: {isTrue}");
            
            // Arithmetic Operations
            Console.WriteLine($"\n--- Arithmetic Operations ---");
            int a = 15;
            int b = 4;
            Console.WriteLine($"{a} + {b} = {a + b}");
            Console.WriteLine($"{a} - {b} = {a - b}");
            Console.WriteLine($"{a} * {b} = {a * b}");
            Console.WriteLine($"{a} / {b} = {a / b}");
            Console.WriteLine($"{a} % {b} = {a % b}");
            
            // Conditional Statements
            Console.WriteLine($"\n--- Conditional Statements ---");
            int score = 85;
            
            if (score >= 90)
            {
                Console.WriteLine($"Score: {score} - Grade: A");
            }
            else if (score >= 80)
            {
                Console.WriteLine($"Score: {score} - Grade: B");
            }
            else if (score >= 70)
            {
                Console.WriteLine($"Score: {score} - Grade: C");
            }
            else
            {
                Console.WriteLine($"Score: {score} - Grade: F");
            }
            
            // Loops
            Console.WriteLine($"\n--- Loops ---");
            
            // For loop
            Console.WriteLine("For loop (1-5):");
            for (int i = 1; i <= 5; i++)
            {
                Console.Write(i + " ");
            }
            
            // While loop
            Console.WriteLine("\nWhile loop (5-1):");
            int counter = 5;
            while (counter > 0)
            {
                Console.Write(counter + " ");
                counter--;
            }
            
            // Arrays
            Console.WriteLine($"\n\n--- Arrays ---");
            int[] numbers = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Array elements:");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
            
            // Methods
            Console.WriteLine($"\n\n--- Methods ---");
            int result = AddNumbers(7, 3);
            Console.WriteLine($"7 + 3 = {result}");
            
            // Object Oriented Programming - Simple Class
            Console.WriteLine($"\n--- Classes and Objects ---");
            Student student1 = new Student("John", 20, 85.5);
            student1.DisplayInfo();
            
            Console.WriteLine($"\nPress any key to exit...");
            Console.ReadKey();
        }
        
        // Method example
        static int AddNumbers(int x, int y)
        {
            return x + y;
        }
    }
    
    // Simple class example
    class Student
    {
        public string Name;
        public int Age;
        public double Grade;
        
        public Student(string name, int age, double grade)
        {
            Name = name;
            Age = age;
            Grade = grade;
        }
        
        public void DisplayInfo()
        {
            Console.WriteLine($"Student: {Name}, Age: {Age}, Grade: {Grade}");
        }
    }
}