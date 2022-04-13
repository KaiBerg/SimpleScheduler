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

namespace SimpleSceduler
{
    /// <summary>
    /// Interaction logic for Scheduler.xaml
    /// </summary>
    public partial class Scheduler : UserControl
    {
        ViewModel vm;

        public Scheduler()
        {
            vm = new();
            InitializeComponent();
            this.DataContext = vm;
            vm.DatePicker.SelectedTime = DateTime.Now;
        }
    }
}
