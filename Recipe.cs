class Recipe
{
    private string[] ingredients;
    private double[] quantities;
    private string[] units;
    private string[] steps;

    public Recipe()
    {
        // arrays
        ingredients = new string[0];
        quantities = new double[0];
        units = new string[0];
        steps = new string[0];
    }

    public void SetDefaultMuffinsRecipe()
    {
        //  Cupcakes Recipe
        ingredients = new string[] { "Flour", "Baking powder", "Salt", "butter", "Sugar", "Eggs", "Vanilla", "Milk" };
        quantities = new double[] { 2, 1 / 2, 1 / 4, 1 / 2, 1, 2, 1, 1 / 2 };
        units = new string[] { "cups", "teaspoon", "teaspoon", "cup", "cup", "teaspoon", "cup" };
        steps = new string[]
        {
                "1. Preheat your oven to 350F (180C) and line a muffin tin with cupcake liner.",
                "2. In a medium bowl, whisk together the flour, baking powder, and salt. Set aside.",
                "3. In a large bowl, cream together the butter and sugar until light and fluffy. Add in the eggs, one at a time, mixing well after each addition. Stir in the vanilla extract.",
                "4. Gradually add the dry ingredients to the wet ingredients, alternating with the milk, until everything is well combined.",
                "5. Fill each muffin pan about 2/3 full with the batter.",
                "6. Bake in the preheated oven for 18-20 minutes, or until a toothpick inserted into the center comes out clean.",
                "7. Allow the muffins to cool completely before frosting.",
                "8. Serve."
        };
    }

    public void EnterRecipeDetails()
    {
        Console.Write("\nEnter the number of ingredients: ");
        int numIngredients = int.Parse(Console.ReadLine());

        ingredients = new string[numIngredients];
        quantities = new double[numIngredients];
        units = new string[numIngredients];

        for (int i = 0; i < numIngredients; i++)
        {
            Console.Write($"Enter ingredient {i + 1} name: ");
            ingredients[i] = Console.ReadLine();

            Console.Write($"Enter quantity for {ingredients[i]}: ");
            quantities[i] = double.Parse(Console.ReadLine());

            Console.Write($"Enter unit for {ingredients[i]}: ");
            units[i] = Console.ReadLine();
        }

        Console.Write("\nEnter the number of steps: ");
        int numSteps = int.Parse(Console.ReadLine());

        steps = new string[numSteps];
        for (int i = 0; i < numSteps; i++)
        {
            Console.Write($"Enter step {i + 1} description: ");
            steps[i] = Console.ReadLine();
        }

        Console.WriteLine("\nRecipe entered successfully!");
    }

    public void DisplayRecipe()
    {
        Console.WriteLine("\nRECIPE:");
        for (int i = 0; i < ingredients.Length; i++)
        {
            Console.WriteLine($"{quantities[i]} {units[i]} of {ingredients[i]}");
        }

        Console.WriteLine("\nSTEPS:");
        for (int i = 0; i < steps.Length; i++)
        {
            Console.WriteLine(steps[i]);
        }
    }

    public void ScaleRecipe()
    {
        Console.Write("\nEnter scaling factor (0.5, 2, or 3): ");
        double factor = double.Parse(Console.ReadLine());

        for (int i = 0; i < quantities.Length; i++)
        {
            quantities[i] *= factor;
        }

        Console.WriteLine("Recipe scaled successfully!");
    }

    public void ResetQuantities()
    {
        SetDefaultMuffinsRecipe();
        Console.WriteLine("Quantities reset to original values.");
    }

    public void ClearData()
    {
        ingredients = new string[0];
        quantities = new double[0];
        units = new string[0];
        steps = new string[0];
        Console.WriteLine("All data cleared.");
      }
    }
 



