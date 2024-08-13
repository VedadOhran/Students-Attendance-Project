namespace FIT.WinForms.Forme
{
    partial class frmPrisustvo
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
            lblStudent = new Label();
            lblNastava = new Label();
            dgvPrisustvo = new DataGridView();
            btnDodaj = new Button();
            cmbStudent = new ComboBox();
            cmbNastava = new ComboBox();
            lblNaziv = new Label();
            lblKapacitet = new Label();
            grbGenerator = new GroupBox();
            btnGenerisi = new Button();
            tbInfo = new TextBox();
            tbBrojZapisa = new TextBox();
            lblInfo = new Label();
            lblBrojZapisa = new Label();
            btnExcel = new Button();
            Nastava = new DataGridViewTextBoxColumn();
            Student = new DataGridViewTextBoxColumn();
            Ukloni = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvPrisustvo).BeginInit();
            grbGenerator.SuspendLayout();
            SuspendLayout();
            // 
            // lblStudent
            // 
            lblStudent.AutoSize = true;
            lblStudent.Location = new Point(401, 115);
            lblStudent.Name = "lblStudent";
            lblStudent.Size = new Size(63, 20);
            lblStudent.TabIndex = 12;
            lblStudent.Text = "Student:";
            // 
            // lblNastava
            // 
            lblNastava.AutoSize = true;
            lblNastava.Location = new Point(33, 115);
            lblNastava.Name = "lblNastava";
            lblNastava.Size = new Size(65, 20);
            lblNastava.TabIndex = 13;
            lblNastava.Text = "Nastava:";
            // 
            // dgvPrisustvo
            // 
            dgvPrisustvo.AllowUserToAddRows = false;
            dgvPrisustvo.AllowUserToDeleteRows = false;
            dgvPrisustvo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrisustvo.Columns.AddRange(new DataGridViewColumn[] { Nastava, Student, Ukloni });
            dgvPrisustvo.Location = new Point(33, 203);
            dgvPrisustvo.Name = "dgvPrisustvo";
            dgvPrisustvo.ReadOnly = true;
            dgvPrisustvo.RowHeadersWidth = 51;
            dgvPrisustvo.RowTemplate.Height = 29;
            dgvPrisustvo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPrisustvo.Size = new Size(858, 206);
            dgvPrisustvo.TabIndex = 10;
            dgvPrisustvo.CellContentClick += dgvPrisustvo_CellContentClick;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(642, 152);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(94, 29);
            btnDodaj.TabIndex = 9;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // cmbStudent
            // 
            cmbStudent.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStudent.FormattingEnabled = true;
            cmbStudent.Items.AddRange(new object[] { "Ponedjeljak", "Utorak", "Srijeda", "Četvrtak", "Petak", "Subota", "Nedjelja" });
            cmbStudent.Location = new Point(401, 153);
            cmbStudent.Name = "cmbStudent";
            cmbStudent.Size = new Size(222, 28);
            cmbStudent.TabIndex = 7;
            // 
            // cmbNastava
            // 
            cmbNastava.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNastava.FormattingEnabled = true;
            cmbNastava.Location = new Point(33, 153);
            cmbNastava.Name = "cmbNastava";
            cmbNastava.Size = new Size(351, 28);
            cmbNastava.TabIndex = 8;
            // 
            // lblNaziv
            // 
            lblNaziv.AutoSize = true;
            lblNaziv.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNaziv.Location = new Point(33, 41);
            lblNaziv.Name = "lblNaziv";
            lblNaziv.Size = new Size(138, 41);
            lblNaziv.TabIndex = 5;
            lblNaziv.Text = "Učionica";
            // 
            // lblKapacitet
            // 
            lblKapacitet.AutoSize = true;
            lblKapacitet.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKapacitet.Location = new Point(616, 41);
            lblKapacitet.Name = "lblKapacitet";
            lblKapacitet.Size = new Size(151, 41);
            lblKapacitet.TabIndex = 5;
            lblKapacitet.Text = "Kapacitet";
            // 
            // grbGenerator
            // 
            grbGenerator.Controls.Add(btnGenerisi);
            grbGenerator.Controls.Add(tbInfo);
            grbGenerator.Controls.Add(tbBrojZapisa);
            grbGenerator.Controls.Add(lblInfo);
            grbGenerator.Controls.Add(lblBrojZapisa);
            grbGenerator.Location = new Point(36, 427);
            grbGenerator.Name = "grbGenerator";
            grbGenerator.Size = new Size(855, 213);
            grbGenerator.TabIndex = 14;
            grbGenerator.TabStop = false;
            grbGenerator.Text = "Generator";
            // 
            // btnGenerisi
            // 
            btnGenerisi.Location = new Point(268, 33);
            btnGenerisi.Name = "btnGenerisi";
            btnGenerisi.Size = new Size(94, 29);
            btnGenerisi.TabIndex = 2;
            btnGenerisi.Text = "Generiši";
            btnGenerisi.UseVisualStyleBackColor = true;
            btnGenerisi.Click += btnGenerisi_Click;
            // 
            // tbInfo
            // 
            tbInfo.Location = new Point(21, 93);
            tbInfo.Multiline = true;
            tbInfo.Name = "tbInfo";
            tbInfo.Size = new Size(585, 114);
            tbInfo.TabIndex = 1;
            // 
            // tbBrojZapisa
            // 
            tbBrojZapisa.Location = new Point(112, 33);
            tbBrojZapisa.Name = "tbBrojZapisa";
            tbBrojZapisa.Size = new Size(125, 27);
            tbBrojZapisa.TabIndex = 1;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(21, 70);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(38, 20);
            lblInfo.TabIndex = 0;
            lblInfo.Text = "Info:";
            // 
            // lblBrojZapisa
            // 
            lblBrojZapisa.AutoSize = true;
            lblBrojZapisa.Location = new Point(21, 33);
            lblBrojZapisa.Name = "lblBrojZapisa";
            lblBrojZapisa.Size = new Size(85, 20);
            lblBrojZapisa.TabIndex = 0;
            lblBrojZapisa.Text = "Broj zapisa:";
            // 
            // btnExcel
            // 
            btnExcel.Location = new Point(742, 152);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(149, 29);
            btnExcel.TabIndex = 15;
            btnExcel.Text = "Izvezi u excel";
            btnExcel.UseVisualStyleBackColor = true;
            btnExcel.Click += btnExcel_Click;
            // 
            // Nastava
            // 
            Nastava.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nastava.DataPropertyName = "Nastava";
            Nastava.HeaderText = "Nastava";
            Nastava.MinimumWidth = 6;
            Nastava.Name = "Nastava";
            Nastava.ReadOnly = true;
            // 
            // Student
            // 
            Student.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Student.DataPropertyName = "Student";
            Student.HeaderText = "Student";
            Student.MinimumWidth = 6;
            Student.Name = "Student";
            Student.ReadOnly = true;
            // 
            // Ukloni
            // 
            Ukloni.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Ukloni.HeaderText = "";
            Ukloni.MinimumWidth = 6;
            Ukloni.Name = "Ukloni";
            Ukloni.ReadOnly = true;
            Ukloni.Text = "Ukloni";
            Ukloni.UseColumnTextForButtonValue = true;
            // 
            // frmPrisustvo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 652);
            Controls.Add(btnExcel);
            Controls.Add(grbGenerator);
            Controls.Add(lblStudent);
            Controls.Add(lblNastava);
            Controls.Add(dgvPrisustvo);
            Controls.Add(btnDodaj);
            Controls.Add(cmbStudent);
            Controls.Add(cmbNastava);
            Controls.Add(lblKapacitet);
            Controls.Add(lblNaziv);
            Name = "frmPrisustvo";
            Text = "Evidencija nastave";
            Load += frmPrisustvo_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPrisustvo).EndInit();
            grbGenerator.ResumeLayout(false);
            grbGenerator.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblStudent;
        private Label lblNastava;
        private DataGridView dgvPrisustvo;
        private Button btnDodaj;
        private ComboBox cmbStudent;
        private ComboBox cmbNastava;
        private Label lblNaziv;
        private Label lblKapacitet;
        private GroupBox grbGenerator;
        private Button btnGenerisi;
        private TextBox tbInfo;
        private TextBox tbBrojZapisa;
        private Label lblInfo;
        private Label lblBrojZapisa;
        private Button btnExcel;
        private DataGridViewTextBoxColumn Nastava;
        private DataGridViewTextBoxColumn Student;
        private DataGridViewButtonColumn Ukloni;
    }
}