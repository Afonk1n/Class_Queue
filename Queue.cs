using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Queue
{
    public class Queue<T>
    {

        private T[] data; //Массив, который используется для хранения элементов очереди.
        private int front; //Индекс первого элемента в очереди.
        private int rear; //Индекс последнего элемента в очереди.
        private int capacity; //Максимальная вместимость (максимальное количество элементов), которое может хранить очередь.
        private int size; //Текущий размер очереди, то есть количество элементов, находящихся в ней.

        public Queue(int capacity)
        {
            this.capacity = capacity;
            this.data = new T[capacity];
            this.front = 0;
            this.rear = -1;
            this.size = 0;
        }

        public int Count
        {
            get { return size; }
        }

        public bool IsEmpty
        {
            get { return size == 0; }
        }

        public bool IsFull
        {
            get { return size == capacity; }
        }
        //Добавляет объект в конец коллекции Queue<T>.
        public void Enqueue(T item)
        {
            if (IsFull)
            {
                Console.WriteLine("Очередь переполнена. Невозможно добавить элемент: " + item);
                return;
            }

            rear = (rear + 1) % capacity;
            data[rear] = item;
            size++;
        }
        //Удаляет объект из начала очереди Queue<T> и возвращает его.
        public T Dequeue()
        {
            if (IsEmpty)
            {
                Console.WriteLine("Очередь пуста. Невозможно извлечь элемент.");
                return default(T);
            }

            T item = data[front];
            front = (front + 1) % capacity;
            size--;
            return item;
        }
        //Возвращает объект, находящийся в начале очереди Queue<T>, но не удаляет его.
        public T Peek()
        {
            if (IsEmpty)
            {
                Console.WriteLine("Очередь пуста. Невозможно получить элемент.");
                return default(T);
            }

            return data[front];
        }
        //Определяет, входит ли элемент в коллекцию Queue<T>.
        public bool Contains(T item)
        {
            for (int i = 0; i < size; i++)
            {
                int index = (front + i) % capacity;
                if (EqualityComparer<T>.Default.Equals(data[index], item))
                {
                    return true;
                }
            }

            return false;
        }
        //Копирует элементы Queue<T> в новый массив.
        public T[] ToArray()
        {
            T[] result = new T[size];

            for (int i = 0; i < size; i++)
            {
                int index = (front + i) % capacity;
                result[i] = data[index];
            }

            return result;
        }
        //Возвращает строку, представляющую текущий объект.
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Queue: [");
            for (int i = 0; i < size; i++)
            {
                sb.Append(data[(front + i) % capacity]);
                if (i < size - 1)
                    sb.Append(", ");
            }
            sb.Append("]");
            return sb.ToString();
        }
        //Удаляет все объекты из Queue<T>.
        public void Clear()
        {
            front = 0;
            rear = -1;
            size = 0;
        }
    }
}
