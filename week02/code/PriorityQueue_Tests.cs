using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: try adding multiple items with different priorities and dequeue all of them
    // Expected Result: items should be dequeued in order of their priority (highest first)
    // Defect(s) Found: 
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        var items = new (string name, int priority)[]
        {
            ("task1", 1), ("task2", 3), ("task3", 2), ("task4", 5), ("task5", 4)
        };
        foreach (var (name, priority) in items)
        {
            priorityQueue.Enqueue(name, priority);
        }

        var dequeuedItems = new List<string>();
        while (priorityQueue.Count > 0)
        {
            dequeuedItems.Add(priorityQueue.Dequeue());
        }

        var expectedOrder = new List<string> { "task4", "task5", "task2", "task3", "task1" };
        CollectionAssert.AreEqual(expectedOrder, dequeuedItems);
    }

    [TestMethod]
    // Scenario: try adding multiple items with the same priority and dequeue all of them
    // Expected Result: items should be dequeued in the order they were added
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        var items = new (string name, int priority)[]
        {
            ("task1", 1), ("task2", 1), ("task3", 1)
        };
        foreach (var (name, priority) in items)
        {
            priorityQueue.Enqueue(name, priority);
        }
        Console.WriteLine(priorityQueue.ToString());
        Console.WriteLine(priorityQueue.Count);
        var dequeuedItems = new List<string>();
        while (priorityQueue.Count > 0)
        {
            dequeuedItems.Add(priorityQueue.Dequeue());
        }

        var expectedOrder = new List<string> { "task1", "task2", "task3" };
        CollectionAssert.AreEqual(expectedOrder, dequeuedItems);
    }

    // Add more test cases as needed below.
}