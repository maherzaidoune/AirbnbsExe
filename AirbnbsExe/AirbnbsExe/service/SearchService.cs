using AirbnbsExe.model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace AirbnbsExe.service
{
    class SearchService
    {
        List<Search> searchList = new List<Search>{
                new Search{id = 1,location = "Sousse",CheckIn = new DateTime(2017,9, 8),CheckOut= new DateTime(2017, 9, 14)},
                new Search{id = 3,location = "Sousse",CheckIn = new DateTime(2017, 11,1),CheckOut= new DateTime(2017,11, 7)},
                new Search{id = 5,location = "tunis",CheckIn = new DateTime(2017, 12, 28),CheckOut= new DateTime(2018, 1, 3)},
                new Search{id = 5,location = "sfax",CheckIn = new DateTime(2017, 12, 28),CheckOut= new DateTime(2018, 1, 3)},
                new Search{id = 5,location = "beja",CheckIn = new DateTime(2017, 12, 28),CheckOut= new DateTime(2018, 1, 3)},
                new Search{id = 5,location = "djerba",CheckIn = new DateTime(2017, 12, 28),CheckOut= new DateTime(2018, 1, 3)}
            };

        public IEnumerable<Search> GetSearch(String filter = null)
        {
            
            if (String.IsNullOrWhiteSpace(filter))
                return searchList;
            return (searchList.Where(s => (s.location.StartsWith(filter))));
        }

        public void deleteSearch(int sid)
        {
            searchList.Remove(searchList.Single(r => r.id == sid));
        }
    }
}
