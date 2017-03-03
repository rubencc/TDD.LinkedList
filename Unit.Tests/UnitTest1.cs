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
            lst.Add("primer elemento");

            lst.Count().Should().Be(0);
        }

        [TestMethod]
        public void T3_Search_Element_Suceed()
        {
            LinkedList<string> lst = new LinkedList<string>();
            lst.Add("primer elemento");
            lst.Add("second elemento");

            <T> result = new <T>();
            result = lst.Search("second element");

            result.ToString().Should().Be("second element");
        }

    }
}
