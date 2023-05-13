using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfLesson2
{
    /// <summary>
    /// BasicListBoxWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class BasicListBoxWindow : Window, INotifyPropertyChanged
    {
        public BasicListBoxWindow()
        {
            InitializeComponent();

            Items = GetItems();
            CurrentItem = Items[0];
            DataContext = this;
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

        private List<CompanyModel> GetItems()
        {
            List<CompanyModel> source = new();
            source.Add(new CompanyModel() { Id = "MSFT", Name = "Microsoft" });
            source.Add(new CompanyModel() { Id = "APPL", Name = "Apple" });
            return source;
        }
    }
}
