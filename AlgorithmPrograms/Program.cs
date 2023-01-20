namespace AlgorithmPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Algorithm Programs");

            int[] array = { 51, 12, 49, 26, 85, 153, 4 };
            BubbleSortMethod objSort = new BubbleSortMethod();

            Console.WriteLine("\nBefore sorting array elements are: ");
            objSort.Display(array);

            objSort.Sort(array);
            Console.WriteLine("\n\nAfter sorting array elements are: ");
            objSort.Display(array);

            Console.ReadLine();
        }
    }
}