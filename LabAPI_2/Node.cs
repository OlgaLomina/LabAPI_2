using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAPI_2
{
    public class Node
    {
        public int data;
        public Node next;

        public Node(int value)
        {
            next = null;
            data = value;
        }

        public Node()
        {
            next = null;
        }
    };
    
    public class MyLinkedList
    {
        //Node head;
        private Node head;
        private int length;
        
        /// Length of the list
        internal int Length { get { return length; } }

        public MyLinkedList()
        {
            head = null;
            length = 0;
        }

        //to right
        public void AddAtTail(int d)
        {
            Node newNode = new Node(d);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node current = head;
                while (current.next != null)
                    current = current.next;

                current.next = newNode;
            }
            length++;
        }

        //to left
        public Node AddAtHead(int d)
        {
            Node node = new Node();
            if (node.next == null)
            {
                node.data = d;
                node.next = head;
                head = node;
            }
            else
            {
                while (node.next != null)
                    node = node.next;

                    node.data = d;
                    node.next = null;
            }
            length++;
            return node;
        }


        public void printnodes()
        {
            Console.WriteLine("print   ");
            Node current = head;
            while (current.next != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
            Console.WriteLine(current.data);
            Console.WriteLine("   ");
            //Console.WriteLine("Length List = {0}", length);

        }



        /// <summary>
        /// Create your own definition of linkedlist first
        /// squish() takes your linked list and, wherever two or more consecutive items are
        /// equals(), it removes duplicate nodes so that only one consecutive copy
        /// remains.  Hence, no two consecutive items in this list are equals() upon
        /// completion of the procedure.
        /// 
        /// After squish() executes, the list may well be shorter than when squish()   
        /// began.  No extra items are added to make up for those removed. 
        /// For example, if the input list is [ 0 0 0 0 1 1 0 0 0 3 3 3 1 1 0 ], the  
        /// output list is [ 0 1 0 3 1 0 ].
        /// </summary>
        public void Squish(MyLinkedList list)
        {
            Node i, j;
            i = list.head;
            j = list.head;
            int len = 0;
            while (j.next != null)
            {
                j = j.next;
                if (i.data == j.data)
                {
                    while (i.data == j.data)
                    {
                        j = j.next;
                        len++;
                    }
                    //i.next = j.next;
                    i.next = j;
                    if (i.next != null)
                    {
                        i = i.next;
                    }                 
                 }
             }
        }


        /// <summary>
        /// Use your definition of linkedlist in this method
        /// twin() takes yourlinkedlist type and doubles its length by replacing each node
        /// with two consecutive nodes referencing the same item.  
        /// For example, if the input list is [ 3 7 4 2 2 ], the 
        /// output list is [ 3 3 7 7 4 4 2 2 2 2 ].    
        /// IMPORTANT:  Do not try to make new copies of the items themselves.
        /// Make new nodes but just copy the reference to the items
        /// </summary>
        public void Twin(MyLinkedList list)
        {
            Node i, j;
            i = list.head;
            j = list.head;
            while (j.next != null)
            {
                j = i.next;
                Node node = new Node();
                node.data = i.data;
                node.next = j;
                i.next = node;
                i = node.next;
                if (j.next == null)
                {
                    Node node1 = new Node();
                    node1.data = i.data;
                    node1.next = null;
                    i.next = node1;
                    i = node1;
                    j = node1;
                    
                }
            }
        }



    }
}