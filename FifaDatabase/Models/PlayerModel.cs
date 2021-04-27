using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifaDatabase.Models
{
    public class PlayerModel
    {
        public int PlayerId { get; set; }
        public string Name { get; set; }
        public DateTimeOffset Age { get; set; }
        public string Position { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }


        public PlayerModel(int playerid, string name, DateTimeOffset age, string position, int height, int weight)
        {
            PlayerId = playerid;
            Name = name;
            Age = age;
            Position = position;
            Height = height;
            Weight = weight;
        }
    }
}
