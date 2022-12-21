namespace LinkedListProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            Console.WriteLine("Adding Values in LinkedList");
            list.AddNote(56);
            list.AddNote(70);

            Console.WriteLine("Printing LinkedList");
            list.Display();


            list.Insert(2, 30);
            Console.WriteLine("Printing Updated LinkedList");
            list.Display();

            list.DeleteLast();
            Console.WriteLine("Printing Updated LinkedList");
            list.Display();
        }
    }
}