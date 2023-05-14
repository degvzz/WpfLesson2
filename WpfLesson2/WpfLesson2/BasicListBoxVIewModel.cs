using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Animation;

namespace WpfLesson2
{
    public class BasicListBoxVIewModel : INotifyPropertyChanged
    {
        public BasicListBoxVIewModel() 
        {
            Items = GetItems();
            CurrentItem = Items[0];

            ButtonClickCommand = new RelayCommand<object>(ButtonClick);
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

        // To notify for View
        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ICommand ButtonClickCommand { get; init; }
        private void ButtonClick(object obj)
        {
            MessageBox.Show(CurrentItem.Name);
        }

        private List<CompanyModel> GetItems()
        {
            List<CompanyModel> source = new();
            source.Add(new CompanyModel() { Id = "MSFT", Name = "Microsoft" });
            source.Add(new CompanyModel() { Id = "APPL", Name = "Apple" });
            return source;
        }
    }
}
