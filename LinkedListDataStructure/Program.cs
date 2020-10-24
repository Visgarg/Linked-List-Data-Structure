using System;

namespace LinkedListDataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Linked List Data Structure!");
            //Creating object of linked list
            LinkedList linkedList = new LinkedList();
            //adding data
            linkedList.DataAtEnd(56);
            linkedList.DataAtEnd(30);
            linkedList.DataAtEnd(70);
            //displaying linkedlist
            linkedList.DisplayLinkedList();

        }
    }
}
