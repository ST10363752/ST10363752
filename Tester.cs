class RecipeTester
{
    static void Main(string[] args)
    {
        // Create a Recipe object and test its methods
        Recipe recipe = new Recipe();
        recipe.SetDefaultMuffinsRecipe();
        recipe.EnterRecipeDetails();
        recipe.DisplayRecipe();
        recipe.ScaleRecipe();
        recipe.ResetQuantities();
        recipe.DisplayRecipe();
        recipe.ClearData();
    }
}

