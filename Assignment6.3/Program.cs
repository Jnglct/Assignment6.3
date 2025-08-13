namespace Assignment6._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListQueue queue = new ListQueue();
            queue.Enqueue(1, reason.LowBalance);
            queue.Enqueue(2, reason.HighBalance);
            queue.Enqueue(3, reason.FraudAlert);
            queue.Enqueue(4, reason.Other);
            queue.Display();
            Console.WriteLine("Ticket: " + queue.Dequeue() + " procced to the desk");
            Console.WriteLine("Ticket: " + queue.Dequeue() + " procced to the desk");
            queue.Enqueue(5, reason.LowBalance);
            queue.Enqueue(6, reason.HighBalance);
            queue.Display();
        }
    }
}
