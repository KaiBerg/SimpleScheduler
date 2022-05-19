using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSceduler.ViewModel
{
    public class MainViewModel : Notify
    {

        private DateTime _selectedTime = DateTime.Now;
        public DateTime SelectedTime
        {
            get { return _selectedTime; }
            set
            {
                _selectedTime = value;
                OnPropertyChanged(nameof(SelectedTime));
            }
        }
    }
}
