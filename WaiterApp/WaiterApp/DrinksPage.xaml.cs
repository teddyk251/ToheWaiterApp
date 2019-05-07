using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaiterApp.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WaiterApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DrinksPage : ContentPage
	{
		public DrinksPage ()
		{
			InitializeComponent ();
            DrinksList.ItemsSource = new List<ListItems>
            {
                new ListItems { Name = "Soft Drinks",
                    Category = "Drinks" ,
                    ImageUrl = "cold_drink.png" },

                new ListItems { Name = "Juices",
                    Category = "Drinks" ,
                    ImageUrl = "juice2.jpg" },

                new ListItems { Name = "Alcoholic Beverages",
                    Category = "Drinks" ,
                    ImageUrl = "alcoholic_beverage2.png" },


            };
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            
        }
    }
}