using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifaDatabase.Models
{
    public class ViewershipModel
    {
        public int? Viewership { get; set; }
        public string Team { get; set; }
        public string Stage { get; set; }

        public ViewershipModel(int? viewership, string team, string stage)
        {
            Viewership = viewership;
            Team = team;
            Stage = stage;
            if (Stage == null) Stage = "Every Stage";
        }
    }
}
