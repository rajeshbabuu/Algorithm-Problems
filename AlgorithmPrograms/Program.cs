namespace AlgorithmPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Algorithm Programs");

            string[] names = { "OOPS", "Array", "Dictionary", "Generics", "Delegates", "LinkedList", "Stack", "Queue", "HashTable", "Events", "Regular Expressions" };
            InsertionSortMethod objInsertion = new InsertionSortMethod();

            Console.WriteLine("\nBefore sorting array elements are: ");
            objInsertion.Display(names);

            objInsertion.Sort(names);
            Console.WriteLine("\n\nAfter sorting array elements are: ");
            objInsertion.Display(names);

            Console.ReadLine();
        }
    }
}