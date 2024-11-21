namespace Zad
{
    internal class Program
    {

        static LinkedList<string> list = new LinkedList<string>() { };
        static void Main(string[] args)
        {
            int answer = 0;
            do
            {
                Console.WriteLine("Input each number in front of a command for that command");
                Console.WriteLine(" 1.Add new product to the end of the list" +
                    "\n 2.Delete the product at the start of the list" +
                    "\n 3.Print all products" +
                    "\n 4.Search for a product" +
                    "\n 5.Replace all products with the same name" +
                    "\n 6.End");
                try
                {
                    answer = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Invalid input");
                    continue;
                }
                switch (answer)
                {
                    case 1:
                        Console.Write("Name of product: ");
                        string input = Console.ReadLine();
                        list.AddLast(input);
                        Console.WriteLine("Added successfully");
                        break;
                    case 2:
                        Console.WriteLine($"Deleting {list.First.Value}");
                        list.RemoveFirst();
                        Console.WriteLine("Deleted successfully");
                        break;
                    case 3:
                        PrintList();
                        break;
                    case 4:
                        Console.Write("Product you want to search for: ");
                        input = Console.ReadLine();
                        Search(input);
                        break;
                    case 5:
                        Console.Write("Product you want to replace: ");
                        string search = Console.ReadLine();
                        Console.Write("New product: ");
                        string replace = Console.ReadLine();
                        Replace(search, replace);
                        break;
                    case 6:
                        return;
                    default:
                        Console.WriteLine("Invalid input, must be 1-6");
                        break;
                }
                Console.WriteLine("========");
            } while (true);
        }
        static void Replace(string old, string newWord)
        {
            while (list.Contains(old))
            {
                LinkedListNode<string> node = list.Find(old);
                node.Value = newWord;
            }
        }
        static void PrintList()
        {
            int counter = 0;
            foreach (string item in list)
            {
                counter++;
                Console.WriteLine($"{counter}. {item}");
            }
        }
        static void Search(string product)
        {
            int counter = 0;
            foreach(string item in list)
            {
                counter++;
                if(string.Compare(product, item, true) == 0)
                {
                    Console.WriteLine($"{product} found at {counter}");
                }
            }
        }
    }
}
