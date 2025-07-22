using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Create a queue with the following people and turns: Maria (7), Joao (1), Gilberto (8)
    // It should add to same order they were added: [Maria, Joao, Gilberto], but removed first Gilberto since his Priority is the highst.
    // Expected Result: They should be removed in this order : [Gilberto, Maria, Joao].
    // Defect(s) Found: When adding with same priority number it would remove incorrectly because in the Dequeu method it compares >= instead of > and it also would not get the last item bc it was _queue.Count -1. I removed it.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        // Assert.Fail("Implement the test case and then remove this.");

        priorityQueue.Enqueue("Maria", 7);
        priorityQueue.Enqueue("Joao", 1);
        priorityQueue.Enqueue("Gilberto", 8);

        Assert.AreEqual("Gilberto", priorityQueue.Dequeue());
        Assert.AreEqual("Maria", priorityQueue.Dequeue());
        Assert.AreEqual("Joao", priorityQueue.Dequeue());



    }

    [TestMethod]
    // Scenario: It will be added ["Maria",1; "Pedro", 4; "Luisa", 2] and it will test whether they are added in the proper order.
    // Expected Result: [Maria (Pri:1), Pedro (Pri:4), Luisa (Pri:2)].
    // Defect(s) Found: None
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        // Assert.Fail("Implement the test case and then remove this.");
        priorityQueue.Enqueue("Maria", 1);
        priorityQueue.Enqueue("Pedro", 4);
        priorityQueue.Enqueue("Luisa", 2);

        var test = "[Maria (Pri:1), Pedro (Pri:4), Luisa (Pri:2)]";
        Assert.AreEqual(priorityQueue.ToString(), test);

    }



    [TestMethod]
    // Scenario: Create a queue with the following people and turns: Maria (1), Joao (1), Gilberto (1)
    // It should add to same order they were added: [Maria, Joao, Gilberto].
    // Expected Result: Dequeu order should be : [Maria, Joao, Gilberto], it should remove the person closest to index = 0 with same priority .
    // Defect(s) Found: When adding with same priority number it would remove incorrectly because it would take the last item instead of the first with same priority - it also would not get the last item bc it was _queue.Count -1. I removed it. 
    public void TestPriorityQueue_3()
    {

        var priorityQueue = new PriorityQueue();
        // Assert.Fail("Implement the test case and then remove this.");

        priorityQueue.Enqueue("Maria", 1);
        priorityQueue.Enqueue("Joao", 1);
        priorityQueue.Enqueue("Gilberto", 1);

        Assert.AreEqual("Maria", priorityQueue.Dequeue());
        Assert.AreEqual("Joao", priorityQueue.Dequeue());
        Assert.AreEqual("Gilberto", priorityQueue.Dequeue());


    }
    
     [TestMethod]
    // Scenario: It won't be added anything to the list, to see whether it will throw the error.
    // Expected Result: "The queue is empty.".
    // Defect(s) Found: None
    public void TestPriorityQueue_4()
    {
        var priorityQueue = new PriorityQueue();
        // Assert.Fail("Implement the test case and then remove this.");
        // priorityQueue.Dequeue();
        
        var exception = Assert.ThrowsException<InvalidOperationException>(() =>
        {
            priorityQueue.Dequeue();
        });
        Assert.AreEqual("The queue is empty.", exception.Message);
    }
}
