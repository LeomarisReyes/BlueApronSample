using System;
using System.Collections.ObjectModel;
using BlueApronSample.Models;

namespace BlueApronSample.ViewModels
{
    public class RecipesViewModel
    {
        public ObservableCollection<Recipes> Recipes { get; set; }
        public string no { get; set; } = "Recipes";
        public RecipesViewModel()
        {
            Recipes = new ObservableCollection<Recipes>
            {
                new  Recipes
                {
                    Name        = "Cheesy Pesto Chicken Calzones",
                    Description = "With Tomato Sauce & Marinated Zucchini",
                    Picture     = "Recipes"
                },
                new  Recipes
                {
                    Name        = "Monterey Jack Cheseeburgues",
                    Description = "Topped with Poblano & Tomato Salsa",
                    Picture     = "Recipes2"
                },
                new  Recipes
                {
                    Name        = "Roast Pork & Vegetables",
                    Description = "Wuth Brasil Pesto & Marinated Tomatoes",
                    Picture     = "Recipes3"
                },
                new  Recipes
                {
                    Name        = "Cheesy Pesto Chicken Calzones",
                    Description = "With Tomato Sauce & Marinated Zucchini",
                    Picture     = "Recipes"
                },
                new  Recipes
                {
                    Name        = "Monterey Jack Cheseeburgues",
                    Description = "Topped with Poblano & Tomato Salsa",
                    Picture     = "Recipes2"
                },
                new  Recipes
                {
                    Name        = "Roast Pork & Vegetables",
                    Description = "Wuth Brasil Pesto & Marinated Tomatoes",
                    Picture     = "Recipes3"
                }
            };
        }
    }
}
