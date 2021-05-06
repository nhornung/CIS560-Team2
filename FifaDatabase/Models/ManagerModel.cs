using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifaDatabase.Models
{
    public class ManagerModel
    {
        public int ManagerID { get; set; }
        public string Name { get; set; }
        public string Nationality { get; set; }
        public ManagerModel(int managerid, string name, string nationality)
        {
            ManagerID = managerid;
            Name = name;
            Nationality = nationality;
        }

    }
}
