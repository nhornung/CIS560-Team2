using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifaDatabase.Models
{
    
    public class TournamentModel
    {
        public int Tournament { get; set; }
        public string Country { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public TournamentModel(int tournament, string country, DateTime startdate, DateTime enddate)
        {
            Tournament = tournament;
            Country = country;
            StartDate = startdate.ToShortDateString();
            EndDate = enddate.ToShortDateString();
        }
    }
}
