using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfCustomControlLibrary1.Local.ViewModels
{
    public class MainContentViewModel : INotifyPropertyChanged
    {
        public MainContentViewModel()
        {
            Items = GetItems();
            CurrentItem = Items[1];
       }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        // ListBox -> ItemsSource
        public List<CompanyModel> Items { get; set; }

        // ListBox -> SelectedItem
        private CompanyModel _currentItem;
        public CompanyModel CurrentItem
        {
            get { return _currentItem; }
            set
            {
                if (_currentItem != value)
                {
                    _currentItem = value;
                    OnPropertyChanged(nameof(CurrentItem));
                }
            }
        }

        private List<CompanyModel> GetItems()
        {
            List<CompanyModel> source = new();
            source.Add(new() { Id = "MSFT", Name = "Microsoft" });
            source.Add(new() { Id = "APPL", Name = "Apple" });
            source.Add(new() { Id = "GOOGL", Name = "Google" });
            return source;
        }
    }
}
