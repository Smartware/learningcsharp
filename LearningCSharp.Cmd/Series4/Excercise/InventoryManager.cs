using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Cmd.Series4.Excercise
{
    public class InventoryManager
    {
        public static IEnumerable<Inventory> FreshInventories()
        {
            List<Inventory> inventories = new List<Inventory>()
            {
                new Inventory()
                {
                    Name = "IPhone X",
                },

                new Inventory()
                {
                    Name = "Samsung S8",
                },

                 new Inventory()
                {
                    Name = "Surface Book 2",
                }
            };

            return inventories;

        }
        public static IEnumerable<Inventory> GetInventories()
        {
            List<Inventory> inventories = new List<Inventory>()
            {

                new Inventory()
                {
                    Id = 1,
                    Name = "Lenovo X1 Carbon",
                    Categories = new List<Category>{ GetCategories()[1] , GetCategories()[2] }
                },

                new Inventory()
                {
                    Id = 2,
                    Name = "Keyboard",
                    Categories = new List<Category>{ GetCategories()[0] }
                },

                 new Inventory()
                {
                    Id = 3,
                    Name = "VGA Converter",
                    Categories = new List<Category>{ GetCategories()[0] }
                }
            };

            return inventories;

        }

        public static List<Category> GetCategories()
        {
            Category[] categories = new Category[3]
            {
                new Category(){ Name = "Computer Accessorires"},
                 new Category(){ Name = "Laptop"},
                    new Category(){ Name = "Computer Gadget"},
            };

            return categories.ToList();
        }
    }
}
