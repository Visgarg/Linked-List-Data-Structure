using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListDataStructure
{
    class Node
    {
        //data is entered
        public int data;
        //saves the position of next node
        public Node next;
        /// <summary>
        /// constructor call of node class
        /// </summary>
        /// <param name="data"></param>
        public Node(int data)
        {
            this.data = data;

        }
    }
}
