using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Queue
{
    public class Program
    {
        static void Main(string[] args)
        {
            Queue<int> myQueue = new Queue<int>(5);
            
            myQueue.Enqueue(1);
            myQueue.Enqueue(2);
            myQueue.Enqueue(3);

            Console.WriteLine("Первый элемент в очереди: " + myQueue.Peek());
            Console.WriteLine("Извлечен элемент: " + myQueue.Dequeue());

            myQueue.Enqueue(4);
            myQueue.Enqueue(5);
            myQueue.Enqueue(6);
            myQueue.Enqueue(7);

            bool containsTwo = myQueue.Contains(2);
            bool containsFive = myQueue.Contains(5);

            Console.WriteLine("Содержит 2: " + containsTwo);
            Console.WriteLine("Содержит 5: " + containsFive);

            int[] array = myQueue.ToArray();

            string st = myQueue.ToString();

            Console.WriteLine(st);

            while (!myQueue.IsEmpty)
            {
                Console.WriteLine("Извлечен элемент: " + myQueue.Dequeue());
            }
            Console.ReadLine();
        }
    }
}
