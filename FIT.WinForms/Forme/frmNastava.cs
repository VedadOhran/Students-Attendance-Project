using FIT.Data.IB220105;
using FIT.Infrastructure;
using FIT.Infrastructure.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIT.WinForms.Forme
{
    public partial class frmNastava : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        private ProstorijaDto? prostorija;

        public frmNastava(ProstorijaDto? prostorija)
        {
            InitializeComponent();
            this.prostorija = prostorija;
            dgvNastava.AutoGenerateColumns = false;
        }

        private void frmNastava_Load(object sender, EventArgs e)
        {
            lblNaziv.Text = prostorija.Naziv;
            UcitajPodatke();
            UcitajNastavu();
        }

        private void UcitajPodatke()
        {
            cmbPredmeti.DisplayMember = "Naziv";
            cmbPredmeti.ValueMember = "Id";
            cmbPredmeti.DataSource = db.Predmeti.ToList();

            cmbPredmeti.SelectedIndex = 0;
            cmbDan.SelectedIndex = 0;
            cmbVrijeme.SelectedIndex = 0;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            var predmet = cmbPredmeti.SelectedItem as Predmeti;
            var dan = cmbDan.SelectedItem.ToString();
            var vrijeme = cmbVrijeme.SelectedItem.ToString();
            var lista = dgvNastava.DataSource as List<Nastava>;
            if (lista != null)
            {
                for (int i = 0; i < lista.Count; i++)
                {
                    var trenutno = lista[i];
                    if (vrijeme == trenutno.Vrijeme && dan == trenutno.Dan)
                    {
                        MessageBox.Show("Nastava u ovom vremenu je već zakazana");
                        return;
                    }
                }
            }

            {
                var novaNastava = new Nastava()
                {
                    ProstorijeId = prostorija.Prostorije.Id,
                    Predmeti = predmet,
                    Dan = dan,
                    Vrijeme = vrijeme,
                    Oznaka = $"{predmet}, {dan}, {vrijeme}",
                };
                db.Nastava.Add(novaNastava);
                db.SaveChanges();

                UcitajNastavu();
            }
        }

        private void UcitajNastavu()
        {
            var lista = db.Nastava.Where(s => s.ProstorijeId == prostorija.Prostorije.Id).ToList();
            dgvNastava.DataSource = null;
            dgvNastava.DataSource = lista;
        }

        private void dgvNastava_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                var trenutnaNastava = dgvNastava.SelectedRows[0].DataBoundItem as Nastava;
                var imaPrisustva = db.Prisustvo.Any(s => s.NastavaId == trenutnaNastava.Id);
                if (imaPrisustva)
                {
                    if (MessageBox.Show("Za ovu nastavu postoje zabilježena prisustva studenata. Želite li ih obrisati?", "Upozorenje", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        var prisustvoZaBrisanje = db.Prisustvo.Where(s => s.NastavaId == trenutnaNastava.Id);
                        db.Prisustvo.RemoveRange(prisustvoZaBrisanje);
                    }
                    else
                    {
                        return;
                    }
                }
                db.Nastava.Remove(trenutnaNastava);
                db.SaveChanges();
                MessageBox.Show($"Nastava {trenutnaNastava} za prostoriju {prostorija.Naziv} uklonjena");
                UcitajNastavu();
            }
        }
    }
}
