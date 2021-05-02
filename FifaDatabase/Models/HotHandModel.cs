using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifaDatabase.Models
{
    public class HotHandModel
    {
        public string Name { get; set; }
        public int Goals { get; set; }

        public HotHandModel(string name, int goals)
        {
            Name = name;
            Goals = goals;
        }
    }
}
