using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD.LinkedList;


namespace Unit.Tests
{
    [TestClass]
    public class LinkedListTests
    {
        [TestMethod]
        public void T1_Add_Element_Succeed()
        {
            LinkedList<string> lst = new LinkedList<string>();
            lst.Add("primer elemento");

            lst.Count().Should().Be(1);
            lst.Get().Should().Be("primer elemento");
        }

        [TestMethod]
        public void T2_Add_Element_Failed()
        {
            LinkedList<string> lst = new LinkedList<string>();
            lst.Add(null);

            lst.Count().Should().Be(0);
        }

        [TestMethod]
        public void T3_Contains_Element_Succeed()
        {
            LinkedList<string> lst = new LinkedList<string>();
            lst.Add("primer elemento");
            lst.Add("second elemento");

            bool result = lst.Contains("second element");

            result.Should().BeTrue();
        }

        [TestMethod]
        public void T4_Remove_Element_Succeed()
        {
            //Arrange
            LinkedList<string> lst = new LinkedList<string>();
            lst.Add("primer elemento");


            //Act

            lst.Remove("primer elemento");

            //Assert
            bool rtn = lst.Contains("primer elemento");

            rtn.Should().BeTrue();
        }

        [TestMethod]
        public void T5_Count_EmptyList_Succeed()
        {
            LinkedList<string> lst = new LinkedList<string>();
            
            lst.Count().Should().Be(0);
        }


        [TestMethod]
        public void T6_Count_OneElementList_Succeed()
        {
            LinkedList<string> lst = new LinkedList<string>();
            lst.Add("primer elemento");

            lst.Count().Should().Be(1);

        }


        [TestMethod]
        public void T7_Remove_Element_Failed()
        {
            //Arrange
            LinkedList<string> lst = new LinkedList<string>();
            lst.Add("not exist element");


            //Act

            lst.Remove("not exist element");
            bool rtn = lst.Contains("not exist element");

            //Assert

            rtn.Should().BeFalse();
        }
       

        [TestMethod]
        public void T8_Add_TwoElements_Succeed()
        {
            LinkedList<string> lst = new LinkedList<string>();
            lst.Add("primer elemento");
            lst.Add("segundo elemento");

            lst.Count().Should().Be(2);
            lst.Get().Should().Be("primer elemento");
            lst.Get().Should().Be("segundo elemento");
        }

        [TestMethod]
        public void T9_Clear_Succeed()
        {
            LinkedList<string> lst = new LinkedList<string>();
            lst.Add("primer elemento");
            lst.Add("segundo elemento");
            lst.Clear();

            lst.Count().Should().Be(0);
          
        }

        [TestMethod]
        public void T10_Get_Index_Succeed()
        {
            LinkedList<string> lst = new LinkedList<string>();
            lst.Add("primer elemento");
            lst.Add("segundo elemento");

            int index = lst.Index("segundo elemento");
            index.Should().Be(1);
        }

        [TestMethod]
        public void T11_Clear_Failed()
        {
            LinkedList<string> lst = new LinkedList<string>();
            lst.Add("primer elemento");
            lst.Add("segundo elemento");
            lst.Clear();

            lst.Count().Should().Be(2);

        }

        [TestMethod]
        public void T12_Get_Index_Not_Found()
        {
            LinkedList<string> lst = new LinkedList<string>();
            lst.Add("primer elemento");
            lst.Add("segundo elemento");

            int index = lst.Index("tercer elemento");
            index.Should().Be(-1);
        }

        [TestMethod]
        public void T13_InsertAt_Succeed()
        {
            LinkedList<string> lst = new LinkedList<string>();
            lst.Add("primer elemento");
            lst.Add("segundo elemento");

            string elementToInsert = "Inserted element";

            lst.InsertAt(1, elementToInsert);
            
            int returnedIndex = lst.Index(elementToInsert);

            returnedIndex.Should().Be(1);

        }

        [TestMethod]
        public void T14_Remove_By_Index()
        {
            LinkedList<string> lst = new LinkedList<string>();
            lst.Add("primer elemento");
            lst.Add("segundo elemento");
            lst.Add("tercero elemento");
            lst.Add("cuarto elemento");

            bool result = lst.RemoveByIndex(2);
            result.Should().Be(true);
        }

    }
}
