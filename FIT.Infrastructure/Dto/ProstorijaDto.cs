using FIT.Data.IB220105;
using FIT.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FIT.Infrastructure.Dto
{

    public class ProstorijaDto
    {
        DLWMSDbContext db = new DLWMSDbContext();
        public Prostorije Prostorije { get; set; }
        public byte[] Logo => Prostorije.Logo;
        public string Naziv => Prostorije.Naziv;
        public string Oznaka => Prostorije.Oznaka;
        public int Kapacitet => Prostorije.Kapacitet;
        public int BrojPredmeta => IzracunajBrojPredmeta();

        private int IzracunajBrojPredmeta()
        {
            return db.Nastava.Include(p => p.Predmeti).Where(s => s.ProstorijeId == Prostorije.Id).Count();

        }
    }

 }

