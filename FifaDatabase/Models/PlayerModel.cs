using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifaDatabase.Models
{
    public class PlayerModel
    {
        public int? PlayerId { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string Position { get; set; }
        public int? Height { get; set; }
        public int? Weight { get; set; }


        public PlayerModel(int? playerid, string name, DateTime age, string position, int? height, int? weight)
        {
            PlayerId = playerid;
            Name = name;
            Age = age.ToShortDateString();
            Position = position;
            Height = height;
            Weight = weight;
        }
    }
}
