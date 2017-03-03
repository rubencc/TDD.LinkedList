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

    }
}
