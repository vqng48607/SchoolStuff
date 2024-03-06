using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ADT
{
    public class LinkedList
    {
        private class Node
        {
            public object Data { get; set; }
            public Node Next { get; set; }

            public override string ToString()
            {
                return Data.ToString();
            }

            public Node(object data, Node next) 
            { 
                this.Data = data;
                this.Next = next;
            }

        }

        private Node head;

        private int count;

        public int Count
        {
            get { return count; }
        }

        public void InsertAt(int index, object o)
        {
            index = count;
            Node current = head;
            int i = 0;

            
                if (index == 0)
                {
                    head = new Node(o, head);
                }
                else

                {
                    while (i < index - 1)
                    {
                        current.Next = new Node(0, current.Next);
                        i++;
                    }
                }
            
            count++;
        }

        public void DeleteAt(int index)
        {
            
        }

        public object ItemAt(int index)
        {
            //Node node = new Node(0, node.Next);
            return 0;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
