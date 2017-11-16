using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCalories
{
	class Program
	{
		static void Main(string[] args)
		{
			string inputLine = Console.ReadLine();

			while (inputLine != "END")
			{
				var tokens = inputLine.Split();
				try
				{
					switch (tokens[0])
					{
						case "Dough":
							var dough = new Dough(tokens[1], tokens[2], double.Parse(tokens[3]));
							Console.WriteLine($"{dough.GetCalories():F2}");
							break;
						case "Topping":
							var topping = new Topping(tokens[1], double.Parse(tokens[2]));
							Console.WriteLine($"{topping.GetCalories():F2}");
							break;
						case "Pizza":
							MakePizza(tokens);
							break;
					}
				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
					return;
				}
				inputLine = Console.ReadLine();
			}





		}

		private static void MakePizza(string[] tokens)
		{
			var pizza = new Pizza(tokens[1], int.Parse(tokens[2]));
			var doughInfo = Console.ReadLine().Split();
			var dough = new Dough(doughInfo[1], doughInfo[2], double.Parse(doughInfo[3]));
			pizza.Dough = dough;
			var numberOfToppings = int.Parse(tokens[2]);
			for (int i = 0; i < numberOfToppings; i++)
			{
				var toppingInfo = Console.ReadLine().Split();
				var topping = new Topping(toppingInfo[1], double.Parse(toppingInfo[2]));
				pizza.AddTopping(topping);
			}
			Console.WriteLine($"{pizza.Name} - {pizza.getCalories():F2} Calories.");
		}
	}
}
