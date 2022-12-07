using System;
using ToDoList.Models;  //allows us to use Item instances without creating new Item instances

namespace ToDoList
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("What would you like to do to your list? \nAdd\nView\nRemove\n");
            string userAnswer = Console.ReadLine(); //grab answer from user
            if (userAnswer.ToLower() == "add")
            {
                Console.WriteLine("\nWhat would you like to add to the list?\n");
                string addItem = Console.ReadLine();
                Item newItem = new Item(addItem); //add item to item list
                Console.WriteLine("\n" +addItem + " has been added to your list.\n");
            }
            else if (userAnswer.ToLower() == "view")
            {
                Console.WriteLine("\nYour list:");
                List<Item> result = Item.GetAll(); //creates a list called result and sets it to all of the items within the items list (inside Item.cs)
                int index = 1;
                foreach (Item thisItem in result)  //loops through each element in list
                {
                    Console.WriteLine(index + ". " + thisItem.Description);
                    index++;
                }
                Console.WriteLine("");
            }
            else if (userAnswer.ToLower() == "remove")
            {
                Console.WriteLine("\nYour list:");
                List<Item> result = Item.GetAll(); //creates a list called result and sets it to all of the items within the items list (inside Item.cs)
                int index = 1;
                foreach (Item thisItem in result)  //loops through each element in list
                {
                    Console.WriteLine(index + ". " + thisItem.Description);
                    index++;
                }
                Console.WriteLine("\nWhich number would you like to remove?\n");
                int removeItem = int.Parse(Console.ReadLine()) - 1; //grabs item to remove from user
                Item.Remove(removeItem);  //remove item from list
                
            }
                Main();
        }
    }
}