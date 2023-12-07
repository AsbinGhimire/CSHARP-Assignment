namespace EXercise6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> myStack = new Stack<int>(5);

            // Perform various push and pop operations
            myStack.Push(5);
            myStack.Push(10);
            myStack.Push(15);

            Console.WriteLine("Remaining items in the stack after pushes:");
            while (!myStack.IsEmpty())
            {
                Console.WriteLine(myStack.Pop());
            }
        }
    }
}