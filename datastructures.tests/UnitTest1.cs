using System;
using Xunit;

namespace datastructure.tests
{
    public class LinkedListTest
    {
        [Fact]
        public void Add_Valid_Object_Should_Get_Correct_List_Count()
        {
            //arrange
            MyDataStructure.LinkedList list = new MyDataStructure.LinkedList();

            //act
            list.AddLast("obj1");
            list.AddLast("obj2");

            //assert
            Assert.Equal(2, list.GetAllNodes().Count);

        }

        [Fact]
        public void Add_Fist_Object_Should_Change_Head()
        {
            //arrange
            MyDataStructure.LinkedList list = new MyDataStructure.LinkedList();

            //act
            list.AddLast("obj1");
            list.AddLast("obj2");

            list.AddFirst("obj3");

            //assert
            Assert.Equal(3, list.GetAllNodes().Count);

        }
    }
}
