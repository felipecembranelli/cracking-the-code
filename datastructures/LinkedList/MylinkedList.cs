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

    //     public LinkedListNode<T> AddAfter(LinkedListNode<T> node, T value);
    //     public LinkedListNode<T> AddBefore(LinkedListNode<T> node, T value);
    //     public void AddFirst(LinkedListNode<T> node);
    //     public LinkedListNode<T> AddLast(T value);
    //     public void Clear();
    //     public bool Contains(T value);
        
    }

    
}