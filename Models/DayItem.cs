using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Calender.Models
{
    internal class DayItem
    {
        public string Date { get; set; }
        public List<string> Tasks { get; set; }

        public DayItem(string date, List<string> tasks)
        {
            Date = date;
            Tasks = tasks;
        }
    }
}
