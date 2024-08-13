using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.IB220105
{
    public class Prisustvo
    {
        public int Id { get; set; }
        public Nastava Nastava { get; set; }
        public int NastavaId { get; set; }
        public Student Student { get; set; }
        public int StudentId { get; set; }
    }
}
