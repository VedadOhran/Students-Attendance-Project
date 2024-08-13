namespace FIT.WinForms.Forme
{
    partial class frmNastava
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
            lblNaziv = new Label();
            cmbPredmeti = new ComboBox();
            cmbDan = new ComboBox();
            cmbVrijeme = new ComboBox();
            btnDodaj = new Button();
            dgvNastava = new DataGridView();
            lblPredmet = new Label();
            lblDan = new Label();
            lblVrijeme = new Label();
            Predmet = new DataGridViewTextBoxColumn();
            Dan = new DataGridViewTextBoxColumn();
            Vrijeme = new DataGridViewTextBoxColumn();
            Ukloni = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvNastava).BeginInit();
            SuspendLayout();
            // 
            // lblNaziv
            // 
            lblNaziv.AutoSize = true;
            lblNaziv.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNaziv.Location = new Point(27, 23);
            lblNaziv.Name = "lblNaziv";
            lblNaziv.Size = new Size(138, 41);
            lblNaziv.TabIndex = 0;
            lblNaziv.Text = "Učionica";
            // 
            // cmbPredmeti
            // 
            cmbPredmeti.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPredmeti.FormattingEnabled = true;
            cmbPredmeti.Location = new Point(27, 135);
            cmbPredmeti.Name = "cmbPredmeti";
            cmbPredmeti.Size = new Size(227, 28);
            cmbPredmeti.TabIndex = 1;
            // 
            // cmbDan
            // 
            cmbDan.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDan.FormattingEnabled = true;
            cmbDan.Items.AddRange(new object[] { "Ponedjeljak", "Utorak", "Srijeda", "Četvrtak", "Petak", "Subota", "Nedjelja" });
            cmbDan.Location = new Point(281, 135);
            cmbDan.Name = "cmbDan";
            cmbDan.Size = new Size(151, 28);
            cmbDan.TabIndex = 1;
            // 
            // cmbVrijeme
            // 
            cmbVrijeme.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVrijeme.FormattingEnabled = true;
            cmbVrijeme.Items.AddRange(new object[] { "08-10", "10-12", "12-14" });
            cmbVrijeme.Location = new Point(456, 135);
            cmbVrijeme.Name = "cmbVrijeme";
            cmbVrijeme.Size = new Size(151, 28);
            cmbVrijeme.TabIndex = 1;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(667, 135);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(94, 29);
            btnDodaj.TabIndex = 2;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // dgvNastava
            // 
            dgvNastava.AllowUserToAddRows = false;
            dgvNastava.AllowUserToDeleteRows = false;
            dgvNastava.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNastava.Columns.AddRange(new DataGridViewColumn[] { Predmet, Dan, Vrijeme, Ukloni });
            dgvNastava.Location = new Point(27, 185);
            dgvNastava.Name = "dgvNastava";
            dgvNastava.ReadOnly = true;
            dgvNastava.RowHeadersWidth = 51;
            dgvNastava.RowTemplate.Height = 29;
            dgvNastava.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNastava.Size = new Size(734, 206);
            dgvNastava.TabIndex = 3;
            dgvNastava.CellContentClick += dgvNastava_CellContentClick;
            // 
            // lblPredmet
            // 
            lblPredmet.AutoSize = true;
            lblPredmet.Location = new Point(27, 97);
            lblPredmet.Name = "lblPredmet";
            lblPredmet.Size = new Size(68, 20);
            lblPredmet.TabIndex = 4;
            lblPredmet.Text = "Predmet:";
            // 
            // lblDan
            // 
            lblDan.AutoSize = true;
            lblDan.Location = new Point(281, 97);
            lblDan.Name = "lblDan";
            lblDan.Size = new Size(39, 20);
            lblDan.TabIndex = 4;
            lblDan.Text = "Dan:";
            // 
            // lblVrijeme
            // 
            lblVrijeme.AutoSize = true;
            lblVrijeme.Location = new Point(456, 97);
            lblVrijeme.Name = "lblVrijeme";
            lblVrijeme.Size = new Size(62, 20);
            lblVrijeme.TabIndex = 4;
            lblVrijeme.Text = "Vrijeme:";
            // 
            // Predmet
            // 
            Predmet.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Predmet.DataPropertyName = "Predmeti";
            Predmet.HeaderText = "Predmet";
            Predmet.MinimumWidth = 6;
            Predmet.Name = "Predmet";
            Predmet.ReadOnly = true;
            // 
            // Dan
            // 
            Dan.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Dan.DataPropertyName = "Dan";
            Dan.HeaderText = "Dan";
            Dan.MinimumWidth = 6;
            Dan.Name = "Dan";
            Dan.ReadOnly = true;
            // 
            // Vrijeme
            // 
            Vrijeme.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Vrijeme.DataPropertyName = "Vrijeme";
            Vrijeme.HeaderText = "Vrijeme";
            Vrijeme.MinimumWidth = 6;
            Vrijeme.Name = "Vrijeme";
            Vrijeme.ReadOnly = true;
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
            // frmNastava
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblVrijeme);
            Controls.Add(lblDan);
            Controls.Add(lblPredmet);
            Controls.Add(dgvNastava);
            Controls.Add(btnDodaj);
            Controls.Add(cmbVrijeme);
            Controls.Add(cmbDan);
            Controls.Add(cmbPredmeti);
            Controls.Add(lblNaziv);
            Name = "frmNastava";
            Text = "Nastava";
            Load += frmNastava_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNastava).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNaziv;
        private ComboBox cmbPredmeti;
        private ComboBox cmbDan;
        private ComboBox cmbVrijeme;
        private Button btnDodaj;
        private DataGridView dgvNastava;
        private Label lblPredmet;
        private Label lblDan;
        private Label lblVrijeme;
        private DataGridViewTextBoxColumn Predmet;
        private DataGridViewTextBoxColumn Dan;
        private DataGridViewTextBoxColumn Vrijeme;
        private DataGridViewButtonColumn Ukloni;
    }
}