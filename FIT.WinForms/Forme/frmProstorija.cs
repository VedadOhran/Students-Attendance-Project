using FIT.Data.IB220105;
using FIT.Infrastructure;
using FIT.Infrastructure.Dto;
using FIT.WinForms.Izvjestaji;
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
    public partial class frmProstorija : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        List<ProstorijaDto> prostorijaDto = new List<ProstorijaDto>();

        public frmProstorija()
        {
            InitializeComponent();
            dgvProstorije.AutoGenerateColumns = false;
        }

        private void frmProstorija_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
                prostorijaDto.Clear();
                dgvProstorije.DataSource = null;
                
                var lista = db.Prostorije.ToList();
          
                foreach (var prostorija in lista)
                {
                    prostorijaDto.Add(new ProstorijaDto() { Prostorije = prostorija });
                }
                
                dgvProstorije.DataSource = prostorijaDto;          
        }

        private  void btnNovaProstorija_Click(object sender, EventArgs e)
        {
            var novaProstorija = new frmNovaProstorija(null);
            novaProstorija.ShowDialog();          
                
            UcitajPodatke();
        }

        private void dgvProstorije_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                var prostorija = dgvProstorije.SelectedRows[0].DataBoundItem as ProstorijaDto;
                var novaNastava = new frmNastava(prostorija);
                novaNastava.ShowDialog();
                UcitajPodatke();
               
            }
            else if (e.ColumnIndex == 6)
            {
                var prisustvo = dgvProstorije.SelectedRows[0].DataBoundItem as ProstorijaDto;
                var novaNastava = new frmPrisustvo(prisustvo);
                if(prisustvo.BrojPredmeta == 0)
                {
                    MessageBox.Show("Potrebno je dodati nastavu za izabranu prostoriju");
                    return;
                }
                novaNastava.ShowDialog();
                UcitajPodatke();
            }
            else if(e.ColumnIndex == 7)
            {
                var prostorija = dgvProstorije.SelectedRows[0].DataBoundItem as ProstorijaDto;
                var novaProstorija = new frmNovaProstorija(prostorija);
                novaProstorija.ShowDialog();
                UcitajPodatke();
            }
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            var prostorija = dgvProstorije.SelectedRows[0].DataBoundItem as ProstorijaDto;
            var noviIzvjestaj = new frmIzvjestaji(prostorija);
            noviIzvjestaj.ShowDialog();
        }
    }
}
