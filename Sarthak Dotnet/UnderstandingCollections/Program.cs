using System.Collections;

namespace UnderstandingCollections
{
    class MainCLass
    {
        static void UsingArrayList()
        {
            ArrayList al = new ArrayList(5);
            al.Add(12);
            al.Add("Sarthak");
            al.Add(new object());
            al.Add("Nayan");
            al.Add(23);
            al.Add("Sarthak");
            al.Add("nayan");
            al.Add("Sarthak");
            al.Add(new MainCLass());
            al.Add(new Queue());
            al.RemoveAt(3);
            al.Remove("Sarthak");
            al.RemoveAt(3);

            foreach(object o in al)
            {
                Console.WriteLine(o);
            }
            Console.WriteLine("\nCapacity : "+al.Capacity);
            Console.WriteLine("Count : " + al.Count);
        }

        public static void UsingGenericList()
        {
            List<int> intList = new List<int>();
            intList.Add(10);
            intList.Add(20);
            intList.Add(5);
            intList.Add(30);
            intList.Sort();

            foreach(int i in intList)
            {
                Console.WriteLine(i);
            }
        }

        static void usingHashTable()
        {
            Hashtable h = new Hashtable();
            h.Add(1, "Sarthak");
            h.Add(3, "Nayan");
            h.Add(2, "Naina");
            h.Add(6, "Vinu");
            h.Add(4, "Omkar");
            h.Add(5, "Rudra");

            foreach(object o in h.Values)
            {
                Console.WriteLine(o);
            }

            Console.WriteLine("-----------------");

            foreach(int i in h.Keys)
            {
                Console.WriteLine(h[i]);
            }
        }

        public static void UsingHashSet()
        {
            string[] arr1 = { "Table", "Chair", "Pen", "Clip", "Table" };
            HashSet<string> h = new HashSet<string>(arr1);  // Hash set elimintaes duplicates values.

            foreach(string s in h)
            {
                Console.WriteLine(s);
            }
        }

        public static void UsingStack()
        {
            Stack h = new Stack();

            // Push elements
            h.Push(1);
            h.Push(20);
            h.Push(5);
            h.Push(6);

            Console.WriteLine("Stack elements after pushing:");

            foreach (var item in h)
            {
                Console.WriteLine(item);
            }

            // Pop removes top element
            Console.WriteLine("\nElement removed using Pop(): " + h.Pop());

            Console.WriteLine("\nStack after Pop:");

            foreach (var item in h)
            {
                Console.WriteLine(item);
            }

            // Peek (see top element without removing)
            Console.WriteLine("\nTop element using Peek(): " + h.Peek());
            Console.WriteLine("Count = " + h.Count);
        }

        public static void UsingQueue()
        {
            Queue q = new Queue();

            // Add elements (Enqueue)
            q.Enqueue(10);
            q.Enqueue(20);
            q.Enqueue(30);
            q.Enqueue(40);

            Console.WriteLine("Queue elements after Enqueue:");

            foreach (var item in q)
            {
                Console.WriteLine(item);
            }

            // Remove first element
            Console.WriteLine("\nRemoved element using Dequeue(): " + q.Dequeue());

            Console.WriteLine("\nQueue after Dequeue:");

            foreach (var item in q)
            {
                Console.WriteLine(item);
            }

            // View first element without removing
            Console.WriteLine("\nFront element using Peek(): " + q.Peek());

            Console.WriteLine("Total elements in queue: " + q.Count);
        }
        public static void Main()
        {
            //UsingArrayList();
            //UsingGenericList();
            //UsingHashSet();
            //usingHashTable();
            //UsingStack();
            UsingQueue();
        }
    }
}