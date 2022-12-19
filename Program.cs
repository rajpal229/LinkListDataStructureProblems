namespace LinkedListProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            Console.WriteLine("Adding Values in LinkedList");
            list.Addnote(70);
            list.Addnote(30);
            list.Addnote(56);
            Console.WriteLine("Printing LinkedList");
            list.Display();
        }
    }
}