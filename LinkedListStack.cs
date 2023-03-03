using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    public class LinkedListStack
    {
        private Node top;
        public LinkedListStack()
        {
            this.top = null;
        }

        public void Push(int data)
        {
            Node top;
            Node newNode = new Node(data);
            if (this.top == null)
            {
                newNode.next = null;
            }
            else
            {
                newNode.next = this.top;
            }
            this.top = newNode;
            Console.WriteLine("{0} pushed to stack", data);
        }

        public void Display()
        {
            Console.WriteLine("Item in the stack");
            Node temp = this.top;
            if (temp == null)
            {
                Console.WriteLine("Linked list is empty");
                return;
            }
            while (temp != null)
            {

                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
