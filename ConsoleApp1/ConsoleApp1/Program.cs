namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> myQueue = new Queue<int>();

            for (int i = 1; i <= 10; i++)
            {
                myQueue.Enqueue(i);
            }

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Current queque: {myQueue.Dequeue()}");
                Console.ReadKey();
                Console.Clear();
            }




        }
    }
}