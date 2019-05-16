using WaiterApp.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using WaiterApp.Services;

namespace WaiterApp.ViewModels
{
    public class MainDishViewModel : INotifyPropertyChanged
    {
        private List<MainDish> _maindishlist;

        public List<MainDish> MainDishList
        {
            get { return _maindishlist; }
            set
            {
                _maindishlist = value;
                OnPropertyChanged();
            }
        }
        public MainDishViewModel()
        {
            var maindishservices = new MainDishServices();
            MainDishList = maindishservices.GetMainDish();
        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}