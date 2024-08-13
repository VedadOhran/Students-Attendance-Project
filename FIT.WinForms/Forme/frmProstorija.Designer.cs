namespace FIT.WinForms.Forme
{
    partial class frmProstorija
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnNovaProstorija = new Button();
            btnPrintaj = new Button();
            dgvProstorije = new DataGridView();
            Logo = new DataGridViewImageColumn();
            Naziv = new DataGridViewTextBoxColumn();
            Oznaka = new DataGridViewTextBoxColumn();
            Kapacitet = new DataGridViewTextBoxColumn();
            BrojPredmeta = new DataGridViewTextBoxColumn();
            Nastava = new DataGridViewButtonColumn();
            Prisustvo = new DataGridViewButtonColumn();
            Uredi = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvProstorije).BeginInit();
            SuspendLayout();
            // 
            // btnNovaProstorija
            // 
            btnNovaProstorija.Location = new Point(715, 12);
            btnNovaProstorija.Name = "btnNovaProstorija";
            btnNovaProstorija.Size = new Size(139, 39);
            btnNovaProstorija.TabIndex = 0;
            btnNovaProstorija.Text = "Nova prostorija";
            btnNovaProstorija.UseVisualStyleBackColor = true;
            btnNovaProstorija.Click += btnNovaProstorija_Click;
            // 
            // btnPrintaj
            // 
            btnPrintaj.Location = new Point(715, 371);
            btnPrintaj.Name = "btnPrintaj";
            btnPrintaj.Size = new Size(139, 37);
            btnPrintaj.TabIndex = 0;
            btnPrintaj.Text = "Printaj";
            btnPrintaj.UseVisualStyleBackColor = true;
            btnPrintaj.Click += btnPrintaj_Click;
            // 
            // dgvProstorije
            // 
            dgvProstorije.AllowUserToAddRows = false;
            dgvProstorije.AllowUserToDeleteRows = false;
            dgvProstorije.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProstorije.Columns.AddRange(new DataGridViewColumn[] { Logo, Naziv, Oznaka, Kapacitet, BrojPredmeta, Nastava, Prisustvo, Uredi });
            dgvProstorije.Location = new Point(12, 73);
            dgvProstorije.Name = "dgvProstorije";
            dgvProstorije.ReadOnly = true;
            dgvProstorije.RowHeadersWidth = 51;
            dgvProstorije.RowTemplate.Height = 29;
            dgvProstorije.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProstorije.Size = new Size(842, 271);
            dgvProstorije.TabIndex = 1;
            dgvProstorije.CellContentClick += dgvProstorije_CellContentClick;
            // 
            // Logo
            // 
            Logo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Logo.DataPropertyName = "Logo";
            Logo.HeaderText = "Logo";
            Logo.ImageLayout = DataGridViewImageCellLayout.Stretch;
            Logo.MinimumWidth = 6;
            Logo.Name = "Logo";
            Logo.ReadOnly = true;
            // 
            // Naziv
            // 
            Naziv.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Naziv.DataPropertyName = "Naziv";
            Naziv.HeaderText = "Naziv";
            Naziv.MinimumWidth = 6;
            Naziv.Name = "Naziv";
            Naziv.ReadOnly = true;
            // 
            // Oznaka
            // 
            Oznaka.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Oznaka.DataPropertyName = "Oznaka";
            Oznaka.HeaderText = "Oznaka";
            Oznaka.MinimumWidth = 6;
            Oznaka.Name = "Oznaka";
            Oznaka.ReadOnly = true;
            // 
            // Kapacitet
            // 
            Kapacitet.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Kapacitet.DataPropertyName = "Kapacitet";
            Kapacitet.HeaderText = "Kapacitet";
            Kapacitet.MinimumWidth = 6;
            Kapacitet.Name = "Kapacitet";
            Kapacitet.ReadOnly = true;
            // 
            // BrojPredmeta
            // 
            BrojPredmeta.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            BrojPredmeta.DataPropertyName = "BrojPredmeta";
            BrojPredmeta.HeaderText = "Broj predmeta";
            BrojPredmeta.MinimumWidth = 6;
            BrojPredmeta.Name = "BrojPredmeta";
            BrojPredmeta.ReadOnly = true;
            // 
            // Nastava
            // 
            Nastava.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nastava.HeaderText = "";
            Nastava.MinimumWidth = 6;
            Nastava.Name = "Nastava";
            Nastava.ReadOnly = true;
            Nastava.Text = "Nastava";
            Nastava.UseColumnTextForButtonValue = true;
            // 
            // Prisustvo
            // 
            Prisustvo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Prisustvo.HeaderText = "";
            Prisustvo.MinimumWidth = 6;
            Prisustvo.Name = "Prisustvo";
            Prisustvo.ReadOnly = true;
            Prisustvo.Text = "Prisustvo";
            Prisustvo.UseColumnTextForButtonValue = true;
            // 
            // Uredi
            // 
            Uredi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Uredi.HeaderText = "";
            Uredi.MinimumWidth = 6;
            Uredi.Name = "Uredi";
            Uredi.ReadOnly = true;
            Uredi.Text = "Uredi";
            Uredi.UseColumnTextForButtonValue = true;
            // 
            // frmProstorija
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(873, 420);
            Controls.Add(dgvProstorije);
            Controls.Add(btnPrintaj);
            Controls.Add(btnNovaProstorija);
            Name = "frmProstorija";
            Text = "Prostorije";
            Load += frmProstorija_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProstorije).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnNovaProstorija;
        private Button btnPrintaj;
        private DataGridView dgvProstorije;
        private DataGridViewImageColumn Logo;
        private DataGridViewTextBoxColumn Naziv;
        private DataGridViewTextBoxColumn Oznaka;
        private DataGridViewTextBoxColumn Kapacitet;
        private DataGridViewTextBoxColumn BrojPredmeta;
        private DataGridViewButtonColumn Nastava;
        private DataGridViewButtonColumn Prisustvo;
        private DataGridViewButtonColumn Uredi;
    }
}