using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace AirbnbsExe.model
{
    class Search : ObservableCollection<Search>
    { 

        public int id { get; set; }
        public String location { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public String time {
            get {
                    return CheckIn.ToString("MMM d, yyyy") + "  -> " +
	                     CheckOut.ToString("MMM d, yyyy");
            }
        }
    }
}
