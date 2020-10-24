using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace LinkedListDataStructure
{
    class LinkedList
    {
        //Creating a node head, which will be pointing to the first element in linkedlist
        //head is filled with pointer of first value, when head is null.
        public Node head;
        /// <summary>
        /// sorted linked list
        /// </summary>
        /// <param name="data"> data to be added in sorted linked list</param>
        public void SortedLinkedList(int data)
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
            else
            {
                //defining counter of elements
                int index = 0;
                //checking the current elements for position in linkedlist according to sorting
                while(temp!=null)
                {
                    //counter increases to find out position until if condition find out list value which is greater than data
                    index += 1;
                   if(data<temp.data)
                    {
                        //defining data to iterate over again
                        Node tempNode = head;
                        Node previous= null;
                        //if index is 1, means there was only 1 element with value greater than data
                        if (index == 1)
                        {
                            node.next = head;
                            head = node;
                            break;
                        }
                        //for loop is run according to index, to get previous and next nodes to insert the values
                        else
                        { 
                            for (int i = 1; i < index; i++)
                            {
                                previous = tempNode;
                                tempNode = tempNode.next;
                            }
                            node.next = tempNode;
                            previous.next = node;
                            break;
                        }
                    }
                   //address is assigned again to temp to iterate over and find out for other nodes
                    temp = temp.next;
                }
                //finds out total no of elements in the list
                int totalInList=1;
                Node countNode = head;
                //count node remains at last node
                while(countNode.next!=null)
                {
                    totalInList++;
                    countNode = countNode.next;
                }
                //if total in list is equal to counter defined before, it means, all the values are smaller than data
                //hence data will be added at last in list
                //as countnode occupied last node, it's address is assigned the node.
                if(index==totalInList)
                {
                    countNode.next = node;
                }


            }
            Console.WriteLine("Element inserted in LinkedList:\t{0}", node.data);
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
            Console.WriteLine("LINKEDLIST");
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
        /// finds out the last node to enter new node address in next of last node.
        /// </summary>
        /// <param name="temp"></param>
        /// <returns></returns>
        public Node GetLastNodeInLinkedList(Node temp)
        {
            //if address in the temp node is not null, loop continues
            while (temp.next != null)
            {
                //used as iterator
                //address of node is passed to same node to point to next node
                temp = temp.next;
            }
            //when temp.next ==null, means last element is reached, temp is returned
            return temp;
        }

        /// <summary>
        /// Data is inserted at left side of head
        /// </summary>
        /// <param name="data"></param>
        public void DataAtFrontInLinkedList(int data)
        {
            //object is created for adding data in node class
            Node node = new Node(data);
            //head address is added in newly created node, hence the initial head is coming at last, and data is inserted at left
            node.next = head;
            //the node in which data is added, is assigned as a new head, so whenever new data comes, it is inserted in left of old node.
            head = node;
            Console.WriteLine("Element inserted in LinkedList:\t{0}", node.data);

        }

        public void AppendingDataInLinkedList(int data)
        {
            //Creating a object of node and adding data in node
            Node node = new Node(data);
            //passing the address of 1st position in linkedlist(stored in head) to temp
            //in starting, head will be null, so temp will be assigned with null
            //but after 1st element is inserted. head will point to 1st element to find out next vacant pointer.
            Node temp = head;
            //fills the first position in linkedlist, when head points to nothing.
            if (head == null)
            {
                head = node;
            }
            //when heads point to first element, node is find out, whose address is empty
            //so that, address of new node can be filled in next of last ode
            else
            {
                //get last node method is called to find out last node
                Node lastNode = GetLastNodeInLinkedList(temp);
                lastNode.next = node;
            }
            Console.WriteLine("Element inserted in LinkedList:\t{0}", node.data);
        }

        /// <summary>
        /// Inserting data in linked list
        /// </summary>
        /// <param name="position"></param>
        /// <param name="data"></param>
        public void InsertingDataInLinkedList(int position, int data)
        {
            //if position is less than 1, then linkedlist is empty
            if(position <1)
            {
                Console.WriteLine("Invalid Position");
            }
            //creating object
            Node node = new Node(data);
            //if position is 1, adding directly using head
            if (position == 1)
            {
                node.next = head;
                head = node;
            }
            //else creating object previous to hold the node of previous position, after new node is added. 
            //temp will be object after the node, after creation of node in list.
            else
            {
                Node temp = head;
                Node previous = null;
                for (int i = 1; i < position; i++)
                {
                    previous = temp;
                    temp = temp.next;
                }
                previous.next = node;
                node.next = temp;
            }
            Console.WriteLine("Element inserted in list:\t{0}", node.data);
        }
        /// <summary>
        /// deleting element from the linkedlist
        /// </summary>
        public void DeleteFirstElementInLinkedList()
        {
            //temp contains 1st node
            Node temp = head;
            Console.WriteLine("Element to be removed :\t{0}", temp.data);
            //address of 2nd node is passed to head
            //head will point to 2nd node directly
            //node 1 will automatically be abandoned.
            head = temp.next;

        }
        /// <summary>
        /// deleting last element from the list
        /// </summary>
        public void DeleteLastElementInLinkedList()
        {
            Node temp = head;
            //finds the positon of the 2nd last element, as after that, next and next will give address as null
            while(temp.next.next !=null)
            {
                temp = temp.next;
            }
            //last element node helps in printing last element
            Node lastelement = temp.next;
            Console.WriteLine("Deleting last element:\t{0}", lastelement.data);
            //address in the temp node(2nd last element) is set to null, hence last node is abandoned.
            temp.next = null; 

        }/// <summary>
        /// Searching the positon of node element in linked list
        /// </summary>
        /// <param name="searchdata"></param>
        /// <returns></returns>
        public int SearchingList(int searchdata)
        {
            //index to find out position
            int index = 0;
            //1st node is assigned to temmp
            Node temp = head;
            //when head is null, empty list is displayed
            if(head==null)
            {
                Console.WriteLine("Empty Linked List");
                return 0;
            }
            //loop is run, until last elementis reached
            while(temp!=null)
            {
                index += 1;
                //matches the data in the node with the given data.
                if(temp.data== searchdata)
                {
                    //returns the index  where the node data is present.
                    return index;
                }
                //moving the pointer of the node to next node.
                temp = temp.next;
            }
            return 0;
        }
        /// <summary>
        /// inserts the element in the linked list after given data position
        /// </summary>
        /// <param name="data"></param>
        /// <param name="searchData"></param>
        public void InsertingElementWithDataInLinkedList(int data, int searchData)
        {
            Node node = new Node(data);
            Console.WriteLine("\ninserting element after the given data");
            //finds the position of the given data
            int positionForGivenData = SearchingList(searchData);
            if(positionForGivenData==0)
            {

                Console.WriteLine("Given value do not exist in the linkedlist:\t{0}",searchData);
            }
            else if (positionForGivenData == 1)
            {
                node.next = head;
                head = node;
                Console.WriteLine("\nElement inserted in list:\t{0}", node.data);
            }
            //fills the data at next position in the same way as inserting element at any position method.
            else
            {
                Node temp = head;
                Node previous = null; 
                for(int i=1;i<=positionForGivenData;i++)
                {
                    previous = temp;
                    temp = temp.next;
                }
                previous.next = node;
                node.next = temp;
                Console.WriteLine("Element inserted in list:\t{0}", node.data);
            }
        }
        /// <summary>
        /// deleting specific element from the linked list
        /// </summary>
        /// <param name="data"></param>
        public void DeleteSpecificElementFromList(int data)
        {
            //finds the position of the given data
            int positionForGivenData = SearchingList(data);
            Node temp = head;
            if (positionForGivenData == 0)
            {

                Console.WriteLine("Given value do not exist in the linkedlist:\t{0}", data);
            }
            //deleting 1st element
            else if (positionForGivenData == 1)
            {
                head = temp.next;
            }
            else
            {
                //defining node to store the data of current node,when the temp node will  be addressed to next node whose address is saved
                Node previous = null;
                //finding out the element position, after which node is to be deleted, so that address can be changed
                for(int i=1;i<positionForGivenData;i++)
                {
                    previous = temp;
                    temp = temp.next;
                }
                Console.WriteLine("\nDeleting Specific element from the list:\t{0}",temp.data);
                //saving the address of next node(after the one getting deleted) in the previous node(to the one which is getting deleted)
                //hence abandoning the specific node
                previous.next = temp.next;
            }
        }
    }
}
