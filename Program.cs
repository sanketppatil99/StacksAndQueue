namespace StackAndQueue
{
    class Program
    {
        public static void Main(string[] args)
        {
            LinkedListQueue queue = new LinkedListQueue();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);

            queue.Display();
            queue.Dequeu();
            Console.WriteLine("After Dequeue");
            queue.Display();

        }
    }
}
