using FIT.Data.IB220105;
using FIT.Infrastructure;
using FIT.Infrastructure.Dto;
using Microsoft.EntityFrameworkCore;
using Microsoft.Reporting.WinForms;
using System.Data;

namespace FIT.WinForms.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        private ProstorijaDto? prostorija;
        public frmIzvjestaji(ProstorijaDto? prostorija)
        {
            InitializeComponent();
            this.prostorija = prostorija;
        }

        private void frmIzvjestaji_Load(object sender, EventArgs e)
        {
            var nastava = db.Nastava.Where(s => s.ProstorijeId == prostorija.Prostorije.Id).ToList();
            List<Prisustvo> prisustvo = new List<Prisustvo>();

            for(int i =0;i<nastava.Count;i++)
            {
                prisustvo.AddRange(db.Prisustvo.Include(s => s.Nastava)
                    .Include(s => s.Student).Include(s => s.Nastava.Predmeti)
                    .Where(s => s.Nastava.Id == nastava[i].Id).ToList());
            }


            var Tabela = new dsNastava.DataTable1DataTable();
            for (int i = 0; i < prisustvo.Count; i++)
            {
                var red = Tabela.NewDataTable1Row();
                var student = prisustvo[i];
                red.Rb = i.ToString();
                red.Predmet = student.Nastava.Predmeti.Naziv.ToString(); ;
                red.Vrijeme = student.Nastava.Vrijeme.ToString();
                red.BrojIndeksa = student.Student.Indeks.ToString();
                red.ImePrezime = student.Student.Ime.ToString();
                Tabela.Rows.Add(red);

            }
            var rpc = new ReportParameterCollection
            {
                new ReportParameter("rpProstorija", prostorija.Naziv.ToString()),
                new ReportParameter("rbBrojStudenata", prisustvo.Count.ToString())
        };

            var rds = new ReportDataSource();
            rds.Value = Tabela;
            rds.Name = "dsNastava";
            reportViewer1.LocalReport.DataSources.Add(rds);


            reportViewer1.LocalReport.SetParameters(rpc);
            reportViewer1.RefreshReport();
        }
    }
}
