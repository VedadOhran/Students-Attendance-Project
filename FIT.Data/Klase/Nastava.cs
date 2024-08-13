using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.IB220105
{
    public class Nastava
    {
        public int Id { get; set; }
        public Prostorije Prostorije { get; set; }
        public int ProstorijeId { get; set; }
        public Predmeti Predmeti { get; set; }
        public int PredmetiId { get; set; }
        public string Vrijeme { get; set; }
        public string Dan { get; set; }
        public string Oznaka { get; set; }

        public override string ToString()
        {
            return Oznaka;
        }
    }
}
