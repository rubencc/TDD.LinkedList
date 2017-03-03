using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD.LinkedList;


namespace Unit.Tests
{
    [TestClass]
    public class LinkedListTests
    {

        #region Add Element

        [TestMethod]
        public void T1_Add_Element_Succeed()
        {
            //Arrange
            LinkedList<string> lst = new LinkedList<string>();
            lst.Add("primer elemento");

            //Act
            lst.Count().Should().Be(1);

            //Assert
            lst.Get().Should().Be("primer elemento");
        }

        [TestMethod]
        public void T2_Add_Element_Failed()
        {
            //Arrange
            LinkedList<string> lst = new LinkedList<string>();

            //Act
            lst.Add(null);

            //Assert
            lst.Count().Should().Be(0);
        }

        [TestMethod]
        public void T8_Add_TwoElements_Succeed()
        {
            //Arrange
            LinkedList<string> lst = new LinkedList<string>();
            lst.Add("primer elemento");
            lst.Add("segundo elemento");

            //Assert
            lst.Count().Should().Be(2);
            lst.Get().Should().Be("primer elemento");
            lst.Get().Should().Be("segundo elemento");
        }
        #endregion

        #region Contains Element

        [TestMethod]
        public void T3_Contains_Element_Succeed()
        {
            //Arrange
            LinkedList<string> lst = new LinkedList<string>();
            lst.Add("primer elemento");
            lst.Add("second elemento");

            //Act
            bool result = lst.Contains("second elemento");

            //Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void T17_Contains_Element_Failed()
        {
            //Arrange
            LinkedList<string> lst = new LinkedList<string>();
            lst.Add("first element");
            lst.Add("second element");

            //Act
            bool result = lst.Contains("not exists element");

            //Assert
            result.Should().BeFalse();
        }

        #endregion

        #region Remove Element

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
        #endregion

        #region Count

        [TestMethod]
        public void T5_Count_EmptyList_Succeed()
        {
            //Arrange
            LinkedList<string> lst = new LinkedList<string>();

            //Assert
            lst.Count().Should().Be(0);
        }


        [TestMethod]
        public void T6_Count_OneElementList_Succeed()
        {
            //Arrange
            LinkedList<string> lst = new LinkedList<string>();
            lst.Add("primer elemento");

            //Assert
            lst.Count().Should().Be(1);
        }
        #endregion

        #region Clear
        [TestMethod]
        public void T9_Clear_Succeed()
        {
            //Arrange
            LinkedList<string> lst = new LinkedList<string>();
            lst.Add("primer elemento");
            lst.Add("segundo elemento");

            //Act
            lst.Clear();

            //Assert
            lst.Count().Should().Be(0);
        }
        #endregion

        #region Get Index
        [TestMethod]
        public void T10_Get_Index_Succeed()
        {
            //Arrange
            LinkedList<string> lst = new LinkedList<string>();
            lst.Add("primer elemento");
            lst.Add("segundo elemento");

            //Act
            int index = lst.Index("segundo elemento");

            //Assert
            index.Should().Be(1);
        }

        [TestMethod]
        public void T11_Get_Index_Not_Found()
        {
            //Arrange
            LinkedList<string> lst = new LinkedList<string>();
            lst.Add("primer elemento");
            lst.Add("segundo elemento");

            //Act
            int index = lst.Index("tercer elemento");

            //Assert
            index.Should().Be(-1);
        }
        #endregion

        #region InsertAt
        [TestMethod]
        public void T12_InsertAt_Succeed()
        {
            //Arrange
            LinkedList<string> lst = new LinkedList<string>();
            lst.Add("primer elemento");
            lst.Add("segundo elemento");

            string elementToInsert = "Inserted element";

            //Act
            lst.InsertAt(1, elementToInsert);

            //Assert
            int returnedIndex = lst.Index(elementToInsert);
            returnedIndex.Should().Be(1);
        }

        [TestMethod]
        public void T13_InsertAt_Failed()
        {
            //Arrange
            LinkedList<string> lst = new LinkedList<string>();
            lst.Add("primer elemento");
            lst.Add("segundo elemento");

            string elementToInsert = "Inserted element";

            //Act
            lst.InsertAt(10, elementToInsert);
            int returnedIndex = lst.Index(elementToInsert);

            //Assert
            returnedIndex.Should().Be(-1);
        }
        #endregion

        #region Remove By Index
        [TestMethod]
        public void T14_Remove_By_Index()
        {
            //Arrange
            LinkedList<string> lst = new LinkedList<string>();
            lst.Add("primer elemento");
            lst.Add("segundo elemento");
            lst.Add("tercero elemento");
            lst.Add("cuarto elemento");

            //Act
            bool result = lst.RemoveByIndex(2);

            //Assert
            result.Should().Be(true);
        }

        [TestMethod]
        public void T15_Remove_By_Index_Failed()
        {
            //Arrange
            LinkedList<string> lst = new LinkedList<string>();
            lst.Add("primer elemento");
            lst.Add("segundo elemento");
            lst.Add("tercero elemento");
            lst.Add("cuarto elemento");

            //Act
            bool result = lst.RemoveByIndex(6);

            //Assert
            result.Should().Be(false);
        }
        #endregion

        #region Reverse
        [TestMethod]
        public void T16_Reverse_Succeed()
        {
            //Arrange
            LinkedList<string> lst = new LinkedList<string>();
            lst.Add("primer elemento");
            lst.Add("segundo elemento");
            lst.Add("tercero elemento");
            lst.Add("cuarto elemento");

            //Act
            lst.Reverse();

            //Assert
            lst.Get().Should().Be("cuarto elemento");
            lst.Get().Should().Be("tercero elemento");
            lst.Get().Should().Be("segundo elemento");
            lst.Get().Should().Be("primer elemento");
        }

        #endregion

        [TestMethod]
        public void T18_Change_Element_Position_Succeed()
        {
            //Arrange
            LinkedList<string> lst = new LinkedList<string>();
            lst.Add("primer elemento");
            lst.Add("cuarto elemento");
            lst.Add("tercero elemento");
            lst.Add("segundo elemento");

            //Act
            bool result = lst.ChangePosition(1,3);

            //Assert
            result.Should().Be(true);
        }
        

    }
}
