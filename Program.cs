namespace StackAndQueue
{
    class Program
    {
        public static void Main(string[] args)
        {
            LinkedListStack linkedListStack = new LinkedListStack();

            linkedListStack.push(70);
            linkedListStack.push(30);
            linkedListStack.push(56);
            linkedListStack.Display();
            linkedListStack.Peek();
            linkedListStack.Pop();
            linkedListStack.IsEmpty();
        }
    }
}
