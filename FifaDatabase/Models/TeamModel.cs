using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifaDatabase.Models
{
    public class TeamModel
    {
        public int TeamID { get; set; }
        public string Nation { get; set; }

        public TeamModel(int teamid, string nation)
        {
            TeamID = teamid;
            Nation = nation;
        }
    }
}
