using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifaDatabase.Models
{
    public class DoTraitsMatterModel
    {
        public string Age { get; set; }
        public int? Height { get; set; }
        public int? Weight { get; set; }

        public DoTraitsMatterModel(DateTime age, int? height, int? weight)
        {
            Age = age.ToShortDateString();
            Height = height;
            Weight = weight;
        }
    }
}
