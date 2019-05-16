using WaiterApp.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using WaiterApp.Services;

namespace WaiterApp.ViewModels
{
    public class TableViewModel : INotifyPropertyChanged
    {
        private List<Tables> _tablesList;

        public List<Tables> TablesList
        {
            get { return _tablesList; }
            set
            {
                _tablesList = value;
                OnPropertyChanged();
            }
        }

        public TableViewModel()
        {
            var tableservices = new TableServices();
            TablesList = tableservices.GetTables();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }




}
