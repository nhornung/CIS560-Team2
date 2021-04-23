using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifaDatabase.Models
{
    class NetworkModel
    {
        public int NetworkID { get; set; }
        public int GameID { get; set; }
        public int Channel { get; set; }
        public string NetworkName { get; set; }
        public int Viewers { get; set; }
    }
}
