using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListDataStructure
{
    class LinkedList
    {
        //Creating a node head, which will be pointing to the first element in linkedlist
        //head is filled with pointer of first value, when head is null.
        public Node head;
        /// <summary>
        /// Creating a linkedlist, where data is inserted at the right side of head.
        /// </summary>
        /// <param name="data"> data to be added in linked list</param>
        public void DataAtEnd(int data)
        {
            //Creating a object of node and adding data in node
            Node node = new Node(data);
            //passing the address of 1st position in linkedlist(stored in head) to temp
            //in starting, head will be null, so temp will be assigned with null
            //but after 1st element is inserted. head will point to 1st element to find out next vacant pointer.
            Node temp= head;
            //fills the first position in linkedlist, when head points to nothing.
            if(head==null)
            {
                head = node;
            }
            //when heads point to first element, node is find out, whose address is empty
            //so that, address of new node can be filled in next of last ode
            else
            {
                //get last node method is called to find out last node
                Node lastNode = GetLastNode(temp);
                lastNode.next = node;
            }
            Console.WriteLine("Element inserted in LinkedList:\t{0}", node.data);
        }
        /// <summary>
        /// finds out the last node to enter new node address in next of last node.
        /// </summary>
        /// <param name="temp"></param>
        /// <returns></returns>
        public Node GetLastNode(Node temp)
        {
            //if address in the temp node is not null, loop continues
            while(temp.next!=null)
            {
                //used as iterator
                //address of node is passed to same node to point to next node
                temp = temp.next;
            }
            //when temp.next ==null, means last element is reached, temp is returned
            return temp;
        }
        /// <summary>
        /// displays linkedlist
        /// </summary>
        public void DisplayLinkedList()
        {
            //assigns head to 1st node.
            //temp becomes first node of linkedlist
            Node temp = head;
            //if temp is null, then linkedlist is null
            if(temp==null)
            {
                Console.WriteLine("Empty LinkedList");
            }
            //if temp contains data, then loop is iterated and values are printed
            while(temp != null)
            {
                Console.WriteLine(temp.data);
                //points to next node after printing
                temp = temp.next;
            }
        }
        /// <summary>
        /// Data is inserted at left side of head
        /// </summary>
        /// <param name="data"></param>
        public void DataAtFront(int data)
        {
            //object is created for adding data in node class
            Node node = new Node(data);
            //head address is added in newly created node, hence the initial head is coming at last, and data is inserted at left
            node.next = head;
            //the node in which data is added, is assigned as a new head, so whenever new data comes, it is inserted in left of old node.
            head = node;
            Console.WriteLine("Element inserted in LinkedList:\t{0}", node.data);

        }
    }
}
