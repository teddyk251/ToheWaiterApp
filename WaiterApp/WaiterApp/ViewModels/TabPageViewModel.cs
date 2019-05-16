using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using WaiterApp.Models;
using WaiterApp.Services;

namespace WaiterApp.ViewModels
{

    public class TabPageViewModel : INotifyPropertyChanged
    {
        private List<Tabpage> _tabpageslist;

        public List<Tabpage>TabPagesList
        {
            get { return _tabpageslist; }
            set
            {
                _tabpageslist = value;
                OnPropertyChanged();
            }
        }
        public TabPageViewModel()
        {
            var tabpageservices = new TabPageServices();
            TabPagesList = tabpageservices.GetTabPages();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
