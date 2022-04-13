using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSceduler
{
    public class DatePicker
    {
        private DateTime _selectedTime = DateTime.MinValue;
        public DateTime SelectedTime
        {
            get { return _selectedTime; }
            set
            {
                _selectedTime = value.AddDays(1 - (double)value.DayOfWeek);
            }
        }

        public string Month
        {
            get { return SelectedTime.ToString("MMMM yyyy"); }
        }
    }
}
