namespace ToDoList.Models
{
    public class Item
    {
        public string Description { get; set; }  //getter
        private static List<Item> _instances = new List<Item> { };

        public static List<Item> GetAll()
        {
            return _instances;
        }

        public Item(string description) //constructor with string agrument
        {
            Description = description;
            _instances.Add(this); //this refers to the object being actively created
        }

        public static void ClearAll() //resets data (helps to clear data between each test)
        {
            _instances.Clear();
        }
    }
}