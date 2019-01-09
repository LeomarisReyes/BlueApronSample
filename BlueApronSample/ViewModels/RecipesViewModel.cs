using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Input;
using BlueApronSample.Models;
using Prism.Commands;
using Prism.Navigation;
using Xamarin.Forms;

namespace BlueApronSample.ViewModels
{
    public class RecipesViewModel : INotifyPropertyChanged
    {
        INavigationService _navigationService; 
        public ObservableCollection<Recipes> Recipes { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
      
        public DelegateCommand<Recipes> OnItemTappedCommand { get; set; }
      
        public RecipesViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService; 
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

            OnItemTappedCommand = new DelegateCommand<Recipes>(async(Recipes recipes) =>
            {  
                await _navigationService.NavigateAsync(NavigationConstants.MenuDetail);
            });
 
        }
    }
}
