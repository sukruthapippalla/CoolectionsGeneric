namespace CoolectionsGeneric
{
    public class Program
    {
        public static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddLast(100);
            list.AddLast(12);
            list.AddLast(3);
            list.AddLast(42);
            list.AddLast(51);
            LinkedList<int> reversedList = new LinkedList<int>();
            for (LinkedListNode<int> node = list.Last; node != null; node = node.Previous)
            {
                reversedList.AddLast(node.Value);
            }
            //foreach(var item in reversedList)
            //{
            //    Console.WriteLine(item);
            //}

            LinkedList<int> sortedList2 = new LinkedList<int>(list.OrderDescending());
            //foreach(var i in sortedList2)
            //{
            //    Console.WriteLine(i);
            //}
            LinkedList<int> ints = new LinkedList<int>();
            ints.AddLast(1);
            ints.AddLast(200);
            ints.AddLast(23);
            ints.AddLast(40);
            ints.AddLast(15);
            ints.AddLast(6);
            ints.AddLast(74);
            ints.AddLast(8);

            LinkedList<int> sortedList1 = new LinkedList<int>(ints.OrderByDescending(x => x));

            foreach(var i in sortedList2)
            {
                sortedList1.AddLast(i);
            }
            //Console.WriteLine("Merged List***********");
            foreach(var i in sortedList1)
            {
                Console.WriteLine(i);
            }

            //int c = sortedList1.Count;
            int c = ints.Count;
            //Console.WriteLine(c);
            if(c % 2 == 0)
            {
                //Console.WriteLine("no middle element");
            }
            else
            {
                c = c / 2;
                int a = c+ 1;
                //Console.WriteLine(a);
            }

            Queue<int> Queue1= new Queue<int>(list);
            foreach(var i in Queue1)
            {
                Console.WriteLine(i);
            }

            Tuple<string, string> tuple = new Tuple<string, string>("Name","Anu");
            Dictionary<string,string> dict = new Dictionary<string,string>();
            dict.Add(tuple.Item1, tuple.Item2);

            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(5);

            HashSet<int> noDuplicates = new HashSet<int>(numbers);
            foreach(var i in noDuplicates)
            {
                Console.WriteLine(i);
            }

            Swap<int>(numbers, 2, 4);
            Console.WriteLine("***************");
            foreach(var i in numbers)
            {
                Console.WriteLine(i);
            }

            //PriorityQueue<string,int> priorityQueue = new PriorityQueue<string,int>();
            //priorityQueue.Enqueue("Anu", 1);
            //priorityQueue.Enqueue("Nivi", 2);
            //priorityQueue.Enqueue("deeku", 3);

            //Console.WriteLine(priorityQueue.Dequeue());

            SortedDictionary<string, int> sdict = new SortedDictionary<string, int>();
            sdict.Add("Anu", 1);
            sdict.Add("Nivi", 2);
            sdict.Add("Deeku", 3);

            PriorityQueue<string, int> priorityQueue = new PriorityQueue<string, int>();

            foreach(var i in sdict)
            {
                priorityQueue.Enqueue(i.Key, i.Value);
            }

            priorityQueue.Dequeue();
            Console.WriteLine(priorityQueue.Dequeue());

            Dictionary<Tuple<int>,string> tkdict = new Dictionary<Tuple<int>,string>();
            Tuple<int> t1 = new Tuple<int>(1);
            Tuple<int> t2 = new Tuple<int>(2);

            tkdict.Add(t1, "Anu");
            tkdict.Add(t2, "Nivi");


        }
        public static void Swap<T>(List<T> list, int toGetSwapped, int toSwap)
        {
            T temp = list[toGetSwapped];
            list[toGetSwapped] = list[toSwap];
            list[toSwap] = temp;
        }
    }
}
