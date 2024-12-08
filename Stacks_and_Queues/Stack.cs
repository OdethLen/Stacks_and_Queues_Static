using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_and_Queues
{

    internal class Stack
    {
        private int[] elements;
        private int top;
        private int maxSize;

        public Stack(int size) 
        {
            maxSize = size;
            elements = new int[maxSize];
            top = -1;
        }

        public void Push(int value)
        {
            if (IsFull())
            {
                MessageBox.Show("Stack is full.");
            }
            elements[++top] = value; // Incrementamos el índice y asignamos el valor
        }


        public int Pop()
        {
            if (IsEmpty())
            {
                MessageBox.Show("Stack is empty");
                return -1;
            }
            return elements[top--]; 
        }

        public int Top()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty");
            }
            return elements[top];
        }

        public bool IsEmpty()
        {
            return top == -1;
        }

        public bool IsFull()
        {
            return top == maxSize - 1;
        }

        public string GetElements()
        {
            if (IsEmpty())
            {
                return "Stack is empty.";
            }

            string stackContent = "Stack contents: \n";
            for (int i = top; i >= 0; i--)
            {
                stackContent += elements[i] + ",";
            }
           
           
             MessageBox.Show(stackContent);
            return"";
        }

        public int GetSize()
        {
            return top + 1;
        }





    }
}
