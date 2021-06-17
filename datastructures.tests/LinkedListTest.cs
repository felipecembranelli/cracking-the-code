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

        [Fact]
        public void Count_Should_Return_Number_of_elements()
        {
            //arrange
            MyDataStructure.LinkedList list = new MyDataStructure.LinkedList();

            //act
            list.AddLast("obj1");
            list.AddLast("obj2");
            list.AddFirst("obj3");

            //assert
            Assert.Equal(3, list.Count());

        }

        [Fact]
        public void Clear_Should_Return_Number_of_elements_zero()
        {
            //arrange
            MyDataStructure.LinkedList list = new MyDataStructure.LinkedList();

            //act
            list.AddLast("obj1");
            list.AddLast("obj2");
            list.AddFirst("obj3");

            list.Clear();

            //assert
            Assert.Equal(0, list.Count());

        }

        [Fact]
        public void Add_Object_Before_Should_Change_List_Elements_Order()
        {
            //arrange
            MyDataStructure.LinkedList list = new MyDataStructure.LinkedList();
            MyDataStructure.Node newNode = new MyDataStructure.Node {data = "obj4"};

            //act
            list.AddLast("obj1");
            list.AddLast("obj2");
            list.AddLast("obj3");
            
            list.AddBefore(newNode,"obj2");

            //assert
            Assert.Equal(4, list.Count());
            Assert.Equal(1, list.GetNodeIndexByValue("obj4"));

        }

        [Fact]
        public void Get_Node_Should_Return_Correct_Object()
        {
            //arrange
            MyDataStructure.LinkedList list = new MyDataStructure.LinkedList();
            MyDataStructure.Node newNode = new MyDataStructure.Node {data = "obj4"};

            //act
            list.AddLast("obj1");
            list.AddLast("obj2");
            list.AddFirst("obj3");
            
            MyDataStructure.Node n = list.GetNodeByValue("obj2");

            //assert
            Assert.Equal("obj2", n.data.ToString());

        }
    }
}