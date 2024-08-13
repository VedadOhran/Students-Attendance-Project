using FIT.Data.IB220105;
using FIT.Infrastructure.Dto;
using FIT.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using Microsoft.EntityFrameworkCore;


namespace FIT.WinForms.Forme
{
    public partial class frmPrisustvo : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        private ProstorijaDto? prostorija;

        public frmPrisustvo(ProstorijaDto? prostorija)
        {
            InitializeComponent();
            this.prostorija = prostorija;
            dgvPrisustvo.AutoGenerateColumns = false;
        }

        private void frmPrisustvo_Load(object sender, EventArgs e)
        {
            lblNaziv.Text = prostorija.Naziv;
            UcitajPodatke();
            UcitajPrisustvo();
        }
        private void UcitajPodatke()
        {
            cmbNastava.DisplayMember = "Oznaka";
            cmbNastava.ValueMember = "Id";
            cmbNastava.DataSource = db.Nastava.Where(s => s.ProstorijeId == prostorija.Prostorije.Id).ToList();

            cmbStudent.DataSource = db.Studenti.ToList();
            cmbStudent.ValueMember = "Id";
            cmbStudent.DisplayMember = "Ime";

            cmbStudent.SelectedIndex = 0;
            cmbNastava.SelectedIndex = 0;
        }
        private void UcitajPrisustvo()
        {           
            var prisustvo = db.Prisustvo
             .Include(s => s.Nastava)
             .Include(s => s.Student)
             .Where(s => s.Nastava.ProstorijeId == prostorija.Prostorije.Id)
             .ToList();

             dgvPrisustvo.DataSource = null;
             dgvPrisustvo.DataSource = prisustvo;
             lblKapacitet.Text = $"{prisustvo.Count.ToString()}/{prostorija.Prostorije.Kapacitet.ToString()}";
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            var nastava = cmbNastava.SelectedItem as Nastava;
            var student = cmbStudent.SelectedItem as Student;

            if (db.Prisustvo.Where(s => s.NastavaId == nastava.Id && s.StudentId == student.Id).Any())
            {
                MessageBox.Show($"Student {student.Ime} je već dodan za {nastava.Oznaka} nastavu");
                return;
            }
            var novoPrisustvo = new Prisustvo()
            {
                Nastava = nastava,
                Student = student
            };
            if (dgvPrisustvo.RowCount > prostorija.Prostorije.Kapacitet)
            {
                MessageBox.Show("Prostorija je popunjena");
                return;
            }
            db.Prisustvo.Add(novoPrisustvo);
            db.SaveChanges();
            UcitajPrisustvo();
        }

        private async void btnGenerisi_Click(object sender, EventArgs e)
        {
            int brojZapisa = int.Parse(tbBrojZapisa.Text);
            var nastava = cmbNastava.SelectedItem as Nastava;
            var student = cmbStudent.SelectedItem as Student;
            var text = "";

            await Task.Run(async () =>
            {
                for (int i = 0; i < brojZapisa; i++)
                {
                    var novoPrisustvo = new Prisustvo()
                    {
                        Nastava = nastava,
                        Student = student
                    };
                    db.Prisustvo.Add(novoPrisustvo);
                    await Task.Delay(300);
                    db.SaveChanges();
                    text += $"{DateTime.UtcNow.ToShortTimeString()} -> {student.Indeks} {student.Ime} {student.Prezime} za  {nastava.Oznaka} {Environment.NewLine}";
                }
            });
            Action ac = () => { tbInfo.Text = (text); };
            BeginInvoke(ac);

            MessageBox.Show("Uspješno dodano");
            UcitajPrisustvo();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            // Kopiraj podatke iz DataGridView-a u clipboard
            dgvPrisustvo.SelectAll();
            DataObject podaciZaKopiranje = dgvPrisustvo.GetClipboardContent();

            if (podaciZaKopiranje != null)
            {
                Clipboard.SetDataObject(podaciZaKopiranje);
            }

            // Kreiranje nove Excel datoteke i copy paste podataka
            Microsoft.Office.Interop.Excel.Application excelAplikacija = new Microsoft.Office.Interop.Excel.Application();
            excelAplikacija.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook excelRadnaKnjiga;
            Microsoft.Office.Interop.Excel.Worksheet excelRadniList;

            object nedostajućiPodaci = System.Reflection.Missing.Value;
            excelRadnaKnjiga = excelAplikacija.Workbooks.Add(nedostajućiPodaci);
            excelRadniList = (Microsoft.Office.Interop.Excel.Worksheet)excelRadnaKnjiga.Worksheets.get_Item(1);

            Microsoft.Office.Interop.Excel.Range excelOpseg = (Microsoft.Office.Interop.Excel.Range)excelRadniList.Cells[1, 1];
            excelOpseg.Select();
            excelRadniList.PasteSpecial(excelOpseg, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);

            MessageBox.Show("Podaci su uspješno izvezeni u Excel.");
        }

        private void dgvPrisustvo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 2)
            {
                var trenutnoPrisustvo = dgvPrisustvo.SelectedRows[0].DataBoundItem as Prisustvo;
                db.Prisustvo.Remove(trenutnoPrisustvo);
                db.SaveChanges();
                MessageBox.Show($"Prisustvo za studenta {trenutnoPrisustvo.Student.Ime} uklonjeno");
                UcitajPrisustvo();              
            }
          }
        }
    }



