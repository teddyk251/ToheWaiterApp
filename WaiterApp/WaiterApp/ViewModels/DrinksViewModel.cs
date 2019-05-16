using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using WaiterApp.Models;
using WaiterApp.Services;

namespace WaiterApp.ViewModels
{
    public class DrinksViewModel : INotifyPropertyChanged
    {
        private List<Drinks> _drinkslist;

        public List<Drinks> DrinksList
        {
            get { return _drinkslist; }
            set
            {
                _drinkslist = value;
                OnPropertyChanged();
            }
        }

        public DrinksViewModel()
        {
            var drinksservices = new DrinksService();
            DrinksList = drinksservices.GetDrinks();
        }




        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }
}
