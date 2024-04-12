using System;

namespace RecipeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Haven Recipe App!");

            // Creating a recipe for Muffins
            Recipe cupcakesRecipe = new Recipe();
            cupcakesRecipe.SetDefaultMuffinsRecipe();

            bool exitRequested = false;

            while (!exitRequested)
            {
                Console.WriteLine("\nMENU:");
                Console.WriteLine("1. Enter a new recipe");
                Console.WriteLine("2. Display the current recipe");
                Console.WriteLine("3. Scale the recipe");
                Console.WriteLine("4. Reset quantities");
                Console.WriteLine("5. Clear all data");
                Console.WriteLine("6. Exit");

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        muffinsRecipe.EnterRecipeDetails();
                        break;
                    case "2":
                        muffinsRecipe.DisplayRecipe();
                        break;
                    case "3":
                        muffinsRecipe.ScaleRecipe();
                        break;
                    case "4":
                        muffinsRecipe.ResetQuantities();
                        break;
                    case "5":
                        muffinsRecipe.ClearData();
                        break;
                    case "6":
                        exitRequested = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice! Please enter a number between 1 and 6.");
                        break;
                }
            }
        }
    }
}

    