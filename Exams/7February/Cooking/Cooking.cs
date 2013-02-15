using System;
using System.Collections.Generic;


class MeasurementUnit
{
    public decimal Quantity { get; set; }
    public string Measurement { get; set; }
    public decimal ReturnMeasurementInMilliliters(string m, decimal quantity)
    {
        switch (m)
        {
            case "liters":
            case "ls":
                quantity = quantity * 1000m;
                break;
            case "tablespoons":
            case "tbsps": quantity = 15m * quantity; break;

            case "teaspoons":
            case "tsps": quantity = 5m * quantity; break;

            case "fluid ounces":
            case "fl ozs": quantity = 30m * quantity; break;


            case "cups": quantity = 240m * quantity; break; //

            case "gallons":
            case "gals": quantity = 4m * 960m * quantity; break;

            case "pints":
            case "pts": quantity = 480m * quantity; break;

            case "quarts":
            case "qts": quantity = 960m * quantity; break;

        }
        return quantity;
    }
    public MeasurementUnit(decimal quantity, string measurement)
    {
        this.Quantity = ReturnMeasurementInMilliliters(measurement, quantity);
        this.Measurement = measurement;
    }
}

class Ingredient
{
    public string Product { get; set; }
    public MeasurementUnit MeasurementUnit { get; set; }

    public Ingredient(string product, MeasurementUnit measurement)
    {
        this.Product = product;
        this.MeasurementUnit = measurement;
    }

}

class Recipe
{
    public List<Ingredient> ingredients;
    public Recipe()
    {
        ingredients = new List<Ingredient>();
    }
    public void Add(Ingredient ingredient)
    {
        int index = ContainsIngredientAtIndex(ingredient);
        if (index != -1)
        {
            ingredients[index].MeasurementUnit.Quantity += ingredient.MeasurementUnit.Quantity;
        }
        else
        {
            ingredients.Add(ingredient);
        }
    }
    public void CompareRecipes(Recipe recipe)
    {
        for (int i = 0; i < ingredients.Count; i++)
        {
            decimal quantity = ingredients[i].MeasurementUnit.Quantity;
            for (int j = 0; j < recipe.ingredients.Count; j++)
            {
                if (string.Compare(ingredients[i].Product, recipe.ingredients[j].Product, true) == 0)
                {
                    quantity -= recipe.ingredients[j].MeasurementUnit.Quantity;
                }
            }
            quantity = ReturnMeasurementAsRecepie(ingredients[i].MeasurementUnit.Measurement, quantity);
            ingredients[i].MeasurementUnit.Quantity = quantity;
        }
    }
    static decimal ReturnMeasurementAsRecepie(string m, decimal quantity)
    {
        switch (m)
        {
            case "liters":
            case "ls":
                quantity = quantity/ 1000m;
                break;
            case "tablespoons":
            case "tbsps": quantity = quantity/ 15m; break;

            case "teaspoons":
            case "tsps": quantity = quantity / 5m; break;

            case "fluid ounces":
            case "fl ozs": quantity = quantity / 30m; break;


            case "cups": quantity =  quantity / 240m; break; //

            case "gallons":
            case "gals": quantity =  quantity / (4m * 960m ); break;

            case "pints":
            case "pts": quantity = quantity / 480m; break;

            case "quarts":
            case "qts": quantity = quantity / 960m; break;

        }
        return quantity;
    }
    public int ContainsIngredientAtIndex(Ingredient indgredient)
    {
        for (int i = 0; i < ingredients.Count; i++)
        {
            if (String.Compare(ingredients[i].Product, indgredient.Product, true) == 0)
            {
                return i;
            }
        }
        return -1;
    }
}

class Cooking
{
    static void Main(string[] args)
    {
        Recipe recipe = new Recipe();
        Recipe ingredients = new Recipe();
        int recipeIngredientsCount = int.Parse(Console.ReadLine());
        for (int i = 0; i < recipeIngredientsCount; i++)
        {
            string input = Console.ReadLine();
            string[] splitedRecipe = input.Split(':');
            MeasurementUnit measurement = new MeasurementUnit(decimal.Parse(splitedRecipe[0]), splitedRecipe[1]);
            Ingredient ingredient = new Ingredient(splitedRecipe[2], measurement);
            recipe.Add(ingredient);
        }
        int ingredientsCount = int.Parse(Console.ReadLine());
        for (int i = 0; i < ingredientsCount; i++)
        {
            string input = Console.ReadLine();
            string[] splitedRecipe = input.Split(':');
            MeasurementUnit measurement = new MeasurementUnit(decimal.Parse(splitedRecipe[0]), splitedRecipe[1]);
            Ingredient ingredient = new Ingredient(splitedRecipe[2], measurement);
            ingredients.Add(ingredient);
        }

        recipe.CompareRecipes(ingredients);
        foreach (Ingredient ingr in recipe.ingredients)
        {
            decimal quantity = ingr.MeasurementUnit.Quantity;
            if(quantity > 0.009m)
            {
                Console.WriteLine("{0:0.00}:{1}:{2}", quantity, ingr.MeasurementUnit.Measurement, ingr.Product);
            }
        }

    }
}