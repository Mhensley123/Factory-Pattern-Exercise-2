using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    class SQL_Data_Access : IDataAccess
    {

        public static List<Product> Products = new List<Product>()
        {
            new Product (){ Name ="books", Price = 20},
            new Product (){ Name = "ground coffee", Price = 10},
            new Product (){ Name="board game", Price = 25},
            new Product (){ Name="bakery items", Price = 5},

        };
        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from SQL Data Access.");

            return Products;
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data from SQL Data Access");
        }
    }
}
