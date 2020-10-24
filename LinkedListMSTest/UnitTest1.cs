using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedListDataStructure;

namespace LinkedListMSTest
{
    [TestClass]
    public class UnitTest1
    {
        LinkedList linkedList = new LinkedList();
        /// <summary>
        /// test initialize method runs every time, test is run
        /// </summary>
        [TestInitialize]
        public void InitializingLinkedList()
        {
            linkedList.DataAtFrontInLinkedList(56);
            linkedList.DataAtFrontInLinkedList(30);
            linkedList.DataAtFrontInLinkedList(70);
        }
        /// <summary>
        /// tests for searching element method in linkedlist
        /// </summary>
        /// <param name="a"> a is element to be checked</param>
        /// <param name="b"> b is expected index</param>
        [TestMethod]
        [DataRow(30,2)]
        [DataRow(21,0)]
        public void SearchingElementInLinkedList(int a, int b)
        {
            //add
            int actual= linkedList.SearchingList(a);
            int expected =b;
            //assert
            Assert.AreEqual(actual, expected);

        }
        /// <summary>
        /// checking for insertion of element
        /// </summary>
        /// <param name="a">a is the data to be inserted</param>
        /// <param name="b">b is the element already in linkedlist after which data is to be inserted</param>
        [TestMethod]
        [DataRow(16,70)]
        public void InsertElementInLinkedList(int a,int b)
        {
            //values should be in same order, as program class, as while checking for inserting element
            linkedList.InsertingElementWithDataInLinkedList(a, b);
            int expected  = linkedList.SearchingList(a);
            int positionForSearchData = linkedList.SearchingList(b);
            int actual = positionForSearchData + 1;
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// checking for deleting the element from the linked list
        /// </summary>
        /// <param name="a"></param>
        [TestMethod]
        [DataRow(70)]
        public void DeletingSpecificElementFromList(int a)
        {
            linkedList.DeleteSpecificElementFromList(a);
            int expected = 0;
            int actual = linkedList.SearchingList(70);
            Assert.AreEqual(expected, actual);
        }
    }
}
