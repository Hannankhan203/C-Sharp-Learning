using System;

class StackDemo
{
    public static void Main(string[] args)
    {
      

        Queue abc1 = new Queue(5);// identifer
        abc1.enqueue(4);
        abc1.enqueue(5);
        abc1.enqueue(3);
        Console.WriteLine("Peak value is: " + abc1.peak());
        Console.WriteLine("before dequeue the value has been removed: " + abc1.dequeue());
        Console.WriteLine("Peak value is: " + abc1.peak());
        // state
        // behaviour

    }

}


class Queue
{
    int head;
    int tail;
    int[] arr;
    public Queue(int arraySize)
    {
        head = -1;
        tail = -1;
        arr = new int[arraySize];
    }
    public void enqueue(int value)
    {
        if (tail == arr.Length - 1)
        {
            Console.WriteLine("queue is full");
            return;
        }
        if (head == -1 && tail == -1)
        {
            head++; ;
            tail++;
            arr[tail] = value;
            return;
        }
        arr[++tail] = value;
    }
    public int peak()
    {
        if (tail == -1)
        {
            Console.WriteLine("queue is already empty");
            return -1;
        }
        return arr[head];

    }
    public int dequeue()
    {
        if (tail == -1)
        {
            Console.WriteLine("queue is already empty");
            return -1;
        }
        return arr[head++];
    }

}
