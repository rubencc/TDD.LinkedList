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
        public void Get_Count_without_elements()
        {
            LinkedList<string> list = new LinkedList<string>();

            list.Count.Should().Be(0);
        }

        [TestMethod]
        public void Add_element()
        {
            LinkedList<string> list = new LinkedList<string>();

            list.Add("dato");

            list.Count.Should().Be(1);

            list.Get().Should().Be("dato");
        }

        [TestMethod]
        public void Add_two_element()
        {
            LinkedList<string> list = new LinkedList<string>();

            list.Add("dato 1");
            list.Add("dato 2");

            list.Count.Should().Be(2, "El numero de elementos no es correcto");

            list.Get().Should().Be("dato 1");
            list.Get().Should().Be("dato 2");
        }

        [TestMethod]
        public void Add_three_element()
        {
            LinkedList<string> list = new LinkedList<string>();

            list.Add("dato 1");
            list.Add("dato 2");
            list.Add("dato 3");

            list.Count.Should().Be(3, "El numero de elementos no es correcto");

            list.Get().Should().Be("dato 1");
            list.Get().Should().Be("dato 2");
            list.Get().Should().Be("dato 3");
        }

        [TestMethod]
        public void Add_four_element()
        {
            LinkedList<string> list = new LinkedList<string>();

            list.Add("dato 1");
            list.Add("dato 2");
            list.Add("dato 3");
            list.Add("dato 4");

            list.Count.Should().Be(4, "El numero de elementos no es correcto");

            list.Get().Should().Be("dato 1");
            list.Get().Should().Be("dato 2");
            list.Get().Should().Be("dato 3");
            list.Get().Should().Be("dato 4");
        }

        [TestMethod]
        public void Remove_by_data()
        {
            LinkedList<string> list = new LinkedList<string>();

            list.Add("dato 1");
            list.Add("dato 2");

            list.Remove("dato 1");

            list.Get().Should().Be("dato 2");
        }

        [TestMethod]
        public void Remove_second_data()
        {
            LinkedList<string> list = new LinkedList<string>();

            list.Add("dato 1");
            list.Add("dato 2");
            list.Add("dato 3");
            list.Add("dato 4");

            list.Remove("dato 2");

            list.Count.Should().Be(3, "El numero de elementos no es correcto");

            list.Get().Should().Be("dato 1");
            list.Get().Should().Be("dato 3");
            list.Get().Should().Be("dato 4");
        }

        [TestMethod]
        public void Find_data_in_head()
        {
            LinkedList<string> list = new LinkedList<string>();

            list.Add("dato 1");

            list.Find("dato 1").Should().BeTrue();
        }

        [TestMethod]
        public void Find_data()
        {
            LinkedList<string> list = new LinkedList<string>();

            list.Add("dato 1");
            list.Add("dato 2");
            list.Add("da");
            list.Add("dat 1");
            list.Add("1");

            list.Find("da").Should().BeTrue();
        }

        [TestMethod]
        public void Not_Find_data_in()
        {
            LinkedList<string> list = new LinkedList<string>();

            list.Add("dato 1");

            list.Find("dato").Should().BeFalse();
        }

        [TestMethod]
        public void FindIndex_data_in_index_0()
        {
            LinkedList<string> list = new LinkedList<string>();

            list.Add("dato 1");
            list.Add("dato 2");
            list.Add("da");
            list.Add("dat 1");
            list.Add("1");

            list.FindIndex("dato 1").Should().Be(0);
        }

        [TestMethod]
        public void FindIndex_data_in_index_1()
        {
            LinkedList<string> list = new LinkedList<string>();

            list.Add("dato 1");
            list.Add("dato 2");
            list.Add("da");
            list.Add("dat 1");
            list.Add("1");

            list.FindIndex("dato 2").Should().Be(1);
        }

        [TestMethod]
        public void FindIndex_data_in_index_5()
        {
            LinkedList<string> list = new LinkedList<string>();

            list.Add("dato 1");
            list.Add("dato 2");
            list.Add("da");
            list.Add("dat 1");
            list.Add("1");

            list.FindIndex("1").Should().Be(4);
        }

        [TestMethod]
        public void FindIndex_data_in_index()
        {
            LinkedList<string> list = new LinkedList<string>();

            list.Add("dato 1");
            list.Add("dato 2");
            list.Add("da");
            list.Add("dat 1");
            list.Add("1");

            list.FindIndex("2").Should().Be(-1);
        }

        [TestMethod]
        public void Clear_list()
        {
            LinkedList<string> list = new LinkedList<string>();

            list.Add("dato 1");
            list.Add("dato 2");
            list.Add("da");
            list.Add("dat 1");
            list.Add("1");

            list.Clear();

            list.Count.Should().Be(0);
        }

        [TestMethod]
        public void Print_empty_list()
        {
            LinkedList<string> list = new LinkedList<string>();


            list.ToString().Should().Be(String.Empty);
        }

        [TestMethod]
        public void Print_list_tow_elements()
        {
            LinkedList<string> list = new LinkedList<string>();

            list.Add("dato 1");
            list.Add("dato 2");

            list.ToString().Should().Be("dato 1, dato 2");
        }
    }
}
