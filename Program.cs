namespace LinkedListProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            Console.WriteLine("Adding Values in LinkedList");
            list.AddReverse(56);
            list.AddReverse(30);
            list.AddReverse(70);

            Console.WriteLine("Printing LinkedList");
            list.Display();
        }
    }
}