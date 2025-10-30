using System;

namespace ExamProgram
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== EXAM PROGRAM ===\n");
            
            // Stack Demo
            Console.WriteLine("--- STACK ---");
            Stack s = new Stack(3);
            s.Push(10); s.Push(20); s.Push(30);
            Console.WriteLine($"Peek: {s.Peek()}");
            Console.WriteLine($"Pop: {s.Pop()}");
            Console.WriteLine($"Peek: {s.Peek()}\n");
            
            // Queue Demo  
            Console.WriteLine("--- QUEUE ---");
            Queue q = new Queue(3);
            q.Enqueue(100); q.Enqueue(200); q.Enqueue(300);
            Console.WriteLine($"Peek: {q.Peek()}");
            Console.WriteLine($"Dequeue: {q.Dequeue()}");
            Console.WriteLine($"Peek: {q.Peek()}\n");
            
            // Student Demo
            Console.WriteLine("--- STUDENT INFO ---");
            Student stu = new Student("John", 20, 85.5);
            stu.DisplayInfo();
            
            Console.ReadKey();
        }
    }

    class Stack
    {
        private int top = -1;
        private int[] arr;
        public Stack(int size) => arr = new int[size];
        public void Push(int val)
        {
            if (top == arr.Length - 1) { Console.WriteLine("Stack Full!"); return; }
            arr[++top] = val;
        }
        public int Pop() => (top == -1) ? -1 : arr[top--];
        public int Peek() => (top == -1) ? -1 : arr[top];
    }

    class Queue
    {
        private int front = -1, rear = -1;
        private int[] arr;
        public Queue(int size) => arr = new int[size];
        public void Enqueue(int val)
        {
            if (rear == arr.Length - 1) { Console.WriteLine("Queue Full!"); return; }
            if (front == -1) front++;
            arr[++rear] = val;
        }
        public int Dequeue() => (front == -1) ? -1 : arr[front++];
        public int Peek() => (front == -1) ? -1 : arr[front];
    }

    class Student
    {
        public string Name;
        public int Age;
        public double Grade;
        public Student(string n, int a, double g) { Name = n; Age = a; Grade = g; }
        public void DisplayInfo() => Console.WriteLine($"Name: {Name}, Age: {Age}, Grade: {Grade}");
    }
}