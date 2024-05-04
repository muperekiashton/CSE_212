using System;
using System.Collections.Generic;

public class PriorityQueue<T>
{
    private readonly List<(T item, int priority)> items;

    public PriorityQueue()
    {
        items = new List<(T item, int priority)>();
    }

    public void Enqueue(T item, int priority)
    {
        items.Add((item, priority));
    }

    public T Dequeue()
    {
        if (items.Count == 0)
        {
            throw new InvalidOperationException("Queue is empty.");
        }

        int highestPriorityIndex = 0;
        for (int i = 1; i < items.Count; i++)
        {
            if (items[i].priority > items[highestPriorityIndex].priority)
            {
                highestPriorityIndex = i;
            }
            else if (items[i].priority == items[highestPriorityIndex].priority)
            {
                // If priorities are equal, choose the item that was enqueued first
                if (i < highestPriorityIndex)
                {
                    highestPriorityIndex = i;
                }
            }
        }

        T dequeuedItem = items[highestPriorityIndex].item;
        items.RemoveAt(highestPriorityIndex);
        return dequeuedItem;
    }
}

partial class Program
{
    static void Main()
    {
        Console.WriteLine("\n=========== PROBLEM 1 TESTS ===========");
        TakingTurns.Test();

        Console.WriteLine("\n=========== PROBLEM 2 TESTS ===========");
        PriorityQueueTest();
    }

    static void PriorityQueueTest()
    {
        // Create an instance of PriorityQueue<int>
        PriorityQueue<int> priorityQueue = new PriorityQueue<int>();

        // Enqueue items with priorities
        priorityQueue.Enqueue(10, 1);
        priorityQueue.Enqueue(20, 2);
        priorityQueue.Enqueue(30, 2);

        // Dequeue items
        int item1 = priorityQueue.Dequeue(); // Returns 20
        int item2 = priorityQueue.Dequeue(); // Returns 30

        Console.WriteLine(item1); // Output: 20
        Console.WriteLine(item2); // Output: 30
    }
}