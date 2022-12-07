using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoList.Models;
using System;


namespace ToDoList.Tests
{
    [TestClass]
    public class ItemTests : IDisposable //needed for clearing all data (along with .ClearAll())
    {
      public void Dispose() //resets data between tests
      {
        Item.ClearAll();
      }
 
        [TestMethod]
        public void ItemConstructor_CreatesInstanceOfItem_Item()
        {
            Item newItem = new Item("test");  //creates a new item instance from ToDoList.Models namespaced
            Assert.AreEqual(typeof(Item), newItem.GetType()); //typeof(item) is getting the type of the Item class GetType returns the item type
        }

        [TestMethod]
        public void GetDescription_ReturnsDescription_String()
        {
            string description = "Walk the dog."; //arrange
            Item newItem = new Item(description); //arrange
            string result = newItem.Description;  //act
            Assert.AreEqual(description, result);
        }

        [TestMethod]
        public void SetDescription_SetDescription_String()
        {
            string description = "Walk the dog.";
            Item newItem = new Item(description);
            string updatedDescription = "Do the dishes."; //string to update description
            newItem.Description = updatedDescription; //set updated description on item constructor
            string result = newItem.Description;    //
            Assert.AreEqual(updatedDescription, result);
        }

        [TestMethod]
        public void GetAll_ReturnsEmptyList_ItemList()
        {
            List<Item> newList = new List<Item> { };  //empty list for holding items
            List<Item> result = Item.GetAll();  //assign result to the return of the item list
//----------------------------------------------------------------------------------------------------
            foreach (Item thisItem in result)
            {
              Console.WriteLine("Output from empty list GetAll test: " + thisItem.Description);
            }
//----------------------------------------------------------------------------------------------------
            CollectionAssert.AreEqual(newList, result); //checks that GetAll() returns a list
        }

        [TestMethod]
        public void GetAll_ReturnsItems_ItemList()
        {
          string description01 = "Walk the dog";
          string description02 = "Wash the dishes";
          Item newItem1 = new Item(description01);  //add description to Item list
          Item newItem2 = new Item(description02);  //add description to Item list
          List<Item> newList = new List<Item> { newItem1, newItem2 }; //creates a local list to compare with above item list

          List<Item> result = Item.GetAll();  //returns the item list from Item.cs
//----------------------------------------------------------------------------------------------------
          foreach (Item thisItem in result)
          {
            Console.WriteLine("Output from second GetAll test: " + thisItem.Description);
          }
//----------------------------------------------------------------------------------------------------
          CollectionAssert.AreEqual(newList, result); //checks that local item list is the same as the return list from Item.cs
        }
    }
}