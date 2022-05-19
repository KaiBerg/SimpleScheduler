using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using SimpleSceduler.ViewModel;

namespace SimpleSceduler.View
{
    /// <summary>
    /// Interaction logic for Scheduler.xaml
    /// </summary>
    public partial class Scheduler : UserControl
    {
        MainViewModel vm;

        public Scheduler()
        {
            vm = new();
            InitializeComponent();
            this.DataContext = vm;
        }

        private void dpPickedDate_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dpPickedDate.SelectedDate != null)
            {
                vm.SelectedTime = dpPickedDate.SelectedDate.Value;
            }
        }
    }
}
