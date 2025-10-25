using System;

class StackDemo
{
    public static void Main(string[] args)
    {
        Stack abc = new Stack(5);// identifer
        abc.push(4);
        abc.push(5);
        abc.push(3);
        Console.WriteLine("Peak value is: " + abc.peak());
        Console.WriteLine("before pop the value has been removed: " + abc.pop());
        Console.WriteLine("Peak value is: " + abc.peak());

        
    }

}


class Stack
{
    int index;/*
             * class member
             * /state
             * /fields
             * /attributes
             * /instance variable
             * /instance member*/
    int[] arr;
    public Stack(int stackSize)
    {
        index = -1;
        arr = new int[stackSize];
    }
    public void push(int value)
    {
        if (index == arr.Length - 1)
        {
            Console.WriteLine("Stack is full");
            return;
        }
        arr[++index] = value;

    }
    public int peak()
    {
        if (index == -1)
        {
            Console.WriteLine("stack is already empty");
            return -1;
        }
        return arr[index];

    }
    public int pop()
    {
        if (index == -1)
        {
            Console.WriteLine("stack is already empty");
            return -1;
        }
        return arr[index--];

    }
}