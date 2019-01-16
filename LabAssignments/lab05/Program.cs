using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QueryApp
{
	class Product
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public int CategoryID { get; set; }
		public decimal Price { get; set; }

		public override string ToString( )
		{
			return Name;
		}
	}

	class Category
	{
		public int ID { get; set; }
		public string Name { get; set; }
	}

	class Program
	{
		public static IEnumerable<int> GetNumbers()
		{
			int[] arrNumbers = { 10, 7, 4, 8, 3, 2, 11, 27, 55, 12, 10, 23 };
			return arrNumbers;
		}
        
		public static IEnumerable<Product> GetProducts()
		{
			List<Product> products = new List<Product>()
            {
                new Product { Name = "Milk", Price = 90, CategoryID = 4, ID = 1 } ,
                new Product { Name = "Cheese", Price = 130, CategoryID = 4, ID = 2 },
                new Product { Name = "Butter", Price = 110, CategoryID = 4, ID = 3 },
                new Product { Name = "Apple juice", Price = 230, CategoryID = 1, ID = 4 },
                new Product { Name = "Grape juice", Price = 240, CategoryID = 1, ID = 5 },
                new Product { Name = "Beetroot juice", Price = 300, CategoryID = 1, ID = 6 },
                new Product { Name = "Carrot juice", Price = 190, CategoryID = 1, ID = 7 },
                new Product { Name = "Ginger ale", Price = 990, CategoryID = 1, ID = 8 },
                new Product { Name = "Oregano", Price = 500, CategoryID = 2, ID = 9 },
                new Product { Name = "Salt", Price = 550, CategoryID = 2, ID = 10 },
                new Product { Name = "Pepper", Price = 490, CategoryID = 2, ID = 11 },
                new Product { Name = "Carrots", Price = 300, CategoryID = 3, ID = 12 },
                new Product { Name = "Spinach", Price = 250, CategoryID = 3, ID = 13 },
                new Product { Name = "Onion", Price = 200, CategoryID = 3, ID = 14 },
                new Product { Name = "Garlic", Price = 150, CategoryID = 3, ID = 15 },
                new Product { Name = "Tomatoes", Price = 100, CategoryID = 3, ID = 16 }
            };
			return products;
		}

        public static IEnumerable<Category> GetCategories()
        {
            List<Category> categories = new List<Category>()
            {
                new Category { ID = 1, Name = "Beverages" },
                new Category { ID = 2, Name = "Condiments" },
                new Category { ID = 3, Name = "Vegetables" },
                new Category { ID = 4, Name = "Dairy products" }
            };
			return categories;
		}

		static void Main( string[] args )
		{
			// a)
			var min = GetNumbers().Min();
			Console.WriteLine(min);

			// b)
			var averageOfOdd = Convert.ToInt32(GetNumbers().Where(x => x %2 !=0).Average());
			Console.WriteLine(averageOfOdd);

			// c)
			var products = GetProducts();
			var lowestPrice = (from l in products orderby l.Price ascending select l).First();
			Console.WriteLine(lowestPrice);

			// d)
			var highestPrice = (from h in products where h.Price <= 120 
													orderby h.Price descending select h).First();
			Console.WriteLine(highestPrice);

			// e)
			var bevStartWithG = (from b in GetProducts()
													join c in GetCategories() on b.CategoryID equals c.ID
													where c.Name.ToLower() == "beverages"
													where b.Name.First() == 'G'
													orderby b.Name ascending
													select b).ToList();
			foreach(var beverage in bevStartWithG) {
				Console.Write( beverage + ", ");
			}
		}
	}
}
