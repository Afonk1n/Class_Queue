using System;
using System.Reflection.Emit;
using static System.Collections.Specialized.BitVector32;

namespace Class_Queue
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter queue length");

            try
            {
                int length = Convert.ToInt32(Console.ReadLine());
                Queue<int> testQueue = new Queue<int>(length);
                int action = 0;
                while (action != 8) {
                    Console.WriteLine("Choose an action:\n1.Add item to queue Enqueue\n2.Remove an element from the beginning of the queue Dequeue\n3.Return an element from the beginning of the queue Peek\n4.Check if an element is in the queue Contains\n5.Convert queue to array ToArray\n6.Convert queue to string ToString\n7.Clears the queue\n8.Exit");
                    action = Convert.ToInt32(Console.ReadLine());
                    switch (action)
                    {
                        case 1:
                            {
                                Console.WriteLine("Enter element to be added to the queue");
                                int element = Convert.ToInt32(Console.ReadLine());
                                testQueue.Enqueue(element);
                                break;
                            }
                        case 2:
                            {
                                Console.WriteLine("Removed element: " + testQueue.Dequeue());
                                break;
                            }
                        case 3:
                            {
                                Console.WriteLine("First element in queue: " + testQueue.Peek());
                                break;
                            }
                        case 4:
                            {
                                Console.WriteLine("Enter an item to check if it is in the queue");
                                int element = Convert.ToInt32(Console.ReadLine());
                                bool containsElement = testQueue.Contains(element);
                                Console.WriteLine("Does the element contain: " + containsElement);
                                break;
                            }
                        case 5:
                            {
                                int[] toArray = testQueue.ToArray();
                                string str = string.Join(", ", toArray);
                                Console.WriteLine("Array: " + str);
                                break;
                            }
                        case 6:
                            {
                                string str = testQueue.ToString();
                                Console.WriteLine("String: " + str);
                                break;
                            }
                        case 7:
                            {
                                testQueue.Clear();
                                Console.WriteLine("Queue cleared");
                                break;
                            }
                        case 8:
                            {
                                break;
                            }
                        default:
                            {
                                break;
                            }
                    }
                }
            } catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                
            }

            /*Queue<int> myQueue = new Queue<int>(5);
            
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
            }*/
            Console.ReadLine();
        }
    }
}
