using System.Collections.Generic;
using System.Linq;

namespace MyDataStructure
{
    public class Node
    {
        public object data { get; set; }
        public Node next { get; set; }

    }

    public class LinkedList
    {
        private Node head;

        public List<object> GetAllNodes()
        {
            Node current = head;
            var list = new List<object>();

            while (current != null)
            {
                list.Add(current);
                current = current.next;
            }

            return list;
        }

        public void AddLast(object data) 
        {
            var node = new Node {
                data = data,
            };

            if (head == null) {
                head = node;
                head.next = null;
            }
            else 
            {
                var current = head;

                while (current.next != null)
                {
                    current = current.next;
                }

                current.next = node;
            }
        }


        public void AddFirst(object data) 
        {
            var node = new Node {
                data = data,
            };

            if (head == null) {
                head = node;
                head.next = null;
            }
            else 
            {
                var current = node;

                current.next = head;
                head = node;
            }
        }

        public void AddBefore(Node node, object data) 
        {
            Node current = head;
            Node previous = null;

            while (current != null)
            {
                if (current.data.Equals(data)) 
                {
                    previous.next = node;
                    node.next = current;

                    return;
                }
                else 
                {
                    previous = current;
                    current = current.next;
                }
            }
        }

        public Node GetNodeByValue(object data) 
        {
            Node current = head;
            Node selectedNode = null;

            while (current != null)
            {
                object currentData = current.data;

                if (currentData.Equals(data)) 
                {
                    selectedNode = current;
                }

                current = current.next;
            }

            return selectedNode;
        }

        public int GetNodeIndexByValue(object data) 
        {
            Node current = head;
            int index = 0;

            while (current != null)
            {
                object currentData = current.data;

                if (!currentData.Equals(data)) 
                {
                    current = current.next;
                    index++;
                }
            }

            return index;
        }

        public void Clear() 
        {
            head = null;
        }
        public int Count() 
        {
            Node current = head;
            int count = 0;

            while (current != null)
            {
                current = current.next;
                count++;

            }

            return count;
        }

    //     public LinkedListNode<T> AddAfter(LinkedListNode<T> node, T value);
    //     public LinkedListNode<T> AddBefore(LinkedListNode<T> node, T value);
    //     public bool Contains(T value);

    //     public void Clear();
    //     public void AddFirst(LinkedListNode<T> node);
    //     public LinkedListNode<T> AddLast(T value);
        
    }

    
}