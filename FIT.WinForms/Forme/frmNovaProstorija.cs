using FIT.Data.IB220105;
using FIT.Data.Klase;
using FIT.Infrastructure;
using FIT.Infrastructure.Dto;
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

    public partial class frmNovaProstorija : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        private ProstorijaDto? prostorija;



        public frmNovaProstorija(ProstorijaDto? prostorija)
        {
            InitializeComponent();
            this.prostorija = prostorija;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            {
                if (prostorija == null)
                {
                    if (Validiraj())
                    {
                        var novaProstorija = new Prostorije()
                        {
                            Naziv = tbNaziv.Text,
                            Oznaka = tbOznaka.Text,
                            Kapacitet = int.Parse(tbKapacitet.Text),
                            Logo = Helpers.Ekstenzije.ToByteArray(pbLogo.Image)
                        };
                        db.Prostorije.Add(novaProstorija);
                        db.SaveChanges();
                        MessageBox.Show("Uspjesno dodana nova prostorija");
                        Close();
                    }
                }
                else
                {
                    prostorija.Prostorije.Naziv = tbNaziv.Text;
                    prostorija.Prostorije.Oznaka = tbOznaka.Text;
                    prostorija.Prostorije.Kapacitet = int.Parse(tbKapacitet.Text);
                    prostorija.Prostorije.Logo = Helpers.Ekstenzije.ToByteArray(pbLogo.Image);

                    db.Prostorije.Update(prostorija.Prostorije);
                    db.SaveChanges();
                    MessageBox.Show($"Uspjesno dodana nova izmjene za {prostorija.Prostorije.Naziv}");
                    Close();
                }
            }
        }

        private void UcitajPodatke()
        {
            if (prostorija != null)
            {
                pbLogo.Image = Helpers.Ekstenzije.ToImage(prostorija.Prostorije.Logo);
                tbNaziv.Text = prostorija.Prostorije.Naziv;
                tbOznaka.Text = prostorija.Prostorije.Oznaka;
                tbKapacitet.Text = prostorija.Prostorije.Kapacitet.ToString();
            }
        }

        private bool Validiraj()
        {
            return Helpers.Validator.ProvjeriUnos(tbKapacitet, errorProvider1, Kljucevi.ReqiredValue) &&
                Helpers.Validator.ProvjeriUnos(tbNaziv, errorProvider1, Kljucevi.ReqiredValue) &&
                Helpers.Validator.ProvjeriUnos(tbOznaka, errorProvider1, Kljucevi.ReqiredValue) &&
                Helpers.Validator.ProvjeriUnos(pbLogo, errorProvider1, Kljucevi.ReqiredValue);
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbLogo.Image = new Bitmap(ofd.FileName);
            }
        }

        private void frmNovaProstorija_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
        }
    }
}
