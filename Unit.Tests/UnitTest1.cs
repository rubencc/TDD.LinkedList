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
        public void T5_Count_EmptyList_Succeed()
        {
            LinkedList<string> lst = new LinkedList<string>();
            
            lst.Count().Should().Be(0);
        }

        [TestMethod]
        public void T3_Search_Element_Suceed()
        {
            LinkedList<string> lst = new LinkedList<string>();
            lst.Add("primer elemento");
            lst.Add("second elemento");

            string result = lst.Search("second element");

            result.ToString().Should().Be("second element");
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
            string rtn = lst.Search("primer elemento");

            lst.Should().BeNull(rtn);
        }

        [TestMethod]
        public void T4_Remove_Element_Failed()
        {
            //Arrange
            LinkedList<string> lst = new LinkedList<string>();
            lst.Add("not exist element");


            //Act

            lst.Remove("not exist element");
            string rtn = lst.Search("not exist element");

            //Assert

            lst.Should().NotBeNull(rtn);
        }

    }
}
