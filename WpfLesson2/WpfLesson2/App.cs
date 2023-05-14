using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfCustomControlLibrary1;

namespace WpfLesson2
{
    internal class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            BasicListBoxWindow win = new();
            //CustomWindow win = new();
            win.ShowDialog();
        }
    }
}
