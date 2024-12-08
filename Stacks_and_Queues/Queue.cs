using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_and_Queues
{
    internal class Queue
    {
        private int[] elements;
        private int front;
        private int rear;
        private int maxSize;
        private int count;


        public Queue(int size)
        {
            maxSize = size;
            elements = new int[maxSize];
            front = 0;
            rear = -1;
            count = 0;
        }

        public void Enqueue(int value)
        {
            if(IsFull())
            {
                MessageBox.Show("Queue overflow");
                return;
            }
            rear = (rear + 1) % maxSize;
            elements[rear] = value;
            count++;
        }

        public int Dequeue() 
        {
            if (IsEmpty())
            {
                MessageBox.Show("Queue is empty");
                return -1; 
            }

            int value = elements[front];
            front = (front + 1) % maxSize;
            count--;
            return value;
        }

        public int Peek()
        {
            if (IsEmpty())
            {
                MessageBox.Show("Queue is Empty");
                return -1;
            }

            return elements[front];
        }


        public int Rear()
        {
            if (IsEmpty())
            {
                MessageBox.Show("Queue is empty");
                return -1; 
            }
            return elements[rear];
        }

        public bool IsFull()
        {
            return count == maxSize;
        }

        public bool IsEmpty()
        {

            if (count == 0)
                return true;
            else
                return false;

        }


        public int Size()
        {
            return count;
        }



        public void DisplayQueue()
        {
            if (IsEmpty())
            {
                MessageBox.Show("Queue is empty.");
                return;
            }

            string queueContents = ""; // Variable para almacenar los elementos.
            int index = front;

            for (int i = 0; i < count; i++)
            {
                queueContents += elements[index]; // Concatenar el elemento actual.
                if (i < count - 1)
                {
                    queueContents += ", "; // Agregar una coma y espacio entre elementos.
                }
                index = (index + 1) % maxSize; // Movimiento circular.
            }

            MessageBox.Show("Queue contents: " + queueContents); // Mostrar el contenido de la cola.
        }

    }
}
