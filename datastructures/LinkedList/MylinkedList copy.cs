// using System.Collections.Generic;
// using System.Linq;

// namespace MyDataStructure
// {
//     public class MyListNode<T>
//     {
//         public T val { get; set; }
//         public MyListNode<T> next { get; set; }

//         public MyListNode(T val, MyListNode<T> next=null) 
//         {
//             this.val = val;
//             this.next = next;
//         }
//     }

//     public class MyLinkedList<T>
//     {
//         public MyLinkedList(IEnumerable<T> collection) 
//         {
//             for (int i = 0; i < collection.Count(); i++)
//             {
//                 var obj = collection.Select(i => i).Single();

//                 var node = new MyListNode<T>(obj, null);

//             }
//         }

//     //     public LinkedListNode<T> AddAfter(LinkedListNode<T> node, T value);
//     //     public LinkedListNode<T> AddBefore(LinkedListNode<T> node, T value);
//     //     public void AddFirst(LinkedListNode<T> node);
//     //     public LinkedListNode<T> AddLast(T value);
//     //     public void Clear();
//     //     public bool Contains(T value);
        
//     }

    
// }