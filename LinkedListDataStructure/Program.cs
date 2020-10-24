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
            //sortedLinkedList
            Console.WriteLine("Sorted Linked List");
            linkedList.SortedLinkedList(56);
            linkedList.SortedLinkedList(30);
            linkedList.SortedLinkedList(70);
            linkedList.SortedLinkedList(4);
            linkedList.SortedLinkedList(100);
            linkedList.SortedLinkedList(34);
            linkedList.SortedLinkedList(44);
             linkedList.DisplayLinkedList();
            Console.WriteLine("****************************************************");
            /*//adding data in front of linkedlist
            Console.WriteLine("LinkedList");
            linkedList.DataAtFrontInLinkedList(70);
            linkedList.DataAtFrontInLinkedList(30);
            linkedList.DataAtFrontInLinkedList(56);
            displaying linkedlist
            linkedList.DisplayLinkedList();*/
            Console.WriteLine("****************************************************");
            //inserting element in linkedlist specifying position and data
            /* linkedList.InsertingDataInLinkedList(4, 45);
             linkedList.DisplayLinkedList();*/
            //deleting 1st element from list
            //linkedList.DeleteFirstElementInLinkedList();
            //linkedList.DisplayLinkedList();
            //deleting last element
            //linkedList.DeleteLastElementInLinkedList();
            //linkedList.DisplayLinkedList();
            //searching data in the list
            //linkedList.SearchingList(56);
            int searchdata = 30;
            int index= linkedList.SearchingList(searchdata);
            Console.WriteLine("\nSearching for element in linked list");
            if (index == 0)
                Console.WriteLine($"{searchdata} is not in the list");
            else
                Console.WriteLine($"{searchdata} is present in the list at {index} position.");
            //inserting element in list using data of previous element
          /*  linkedList.InsertingElementWithData(16, 45);
            linkedList.DisplayLinkedList();*/
            //deleting specific element from the list
            linkedList.DeleteSpecificElementFromList(30);
            linkedList.DisplayLinkedList();

        }
    }
}
