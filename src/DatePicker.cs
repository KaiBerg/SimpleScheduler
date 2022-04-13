using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace SimpleSceduler
{
    public class DatePicker : INotifyPropertyChanged
    {
        private DateTime _selectedTime = DateTime.MinValue;
        public DateTime SelectedTime
        {
            get { return _selectedTime; }
            set
            {
                _selectedTime = value.AddDays(1 - (double)value.DayOfWeek);
                OnPropertyChanged();
                OnPropertyChanged("Month");
            }
        }

        public string Month
        {
            get { return SelectedTime.ToString("MMMM yyyy"); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
