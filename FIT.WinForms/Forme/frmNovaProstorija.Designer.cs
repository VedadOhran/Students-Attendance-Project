namespace FIT.WinForms.Forme
{
    partial class frmNovaProstorija
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
            components = new System.ComponentModel.Container();
            pbLogo = new PictureBox();
            tbNaziv = new TextBox();
            tbOznaka = new TextBox();
            tbKapacitet = new TextBox();
            btnSave = new Button();
            lblNaziv = new Label();
            lblKapacitet = new Label();
            lblOznaka = new Label();
            lblLogo = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // pbLogo
            // 
            pbLogo.BorderStyle = BorderStyle.FixedSingle;
            pbLogo.Location = new Point(12, 83);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(195, 215);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            pbLogo.Click += pbLogo_Click;
            // 
            // tbNaziv
            // 
            tbNaziv.Location = new Point(248, 83);
            tbNaziv.Name = "tbNaziv";
            tbNaziv.Size = new Size(334, 27);
            tbNaziv.TabIndex = 1;
            // 
            // tbOznaka
            // 
            tbOznaka.Location = new Point(248, 186);
            tbOznaka.Name = "tbOznaka";
            tbOznaka.Size = new Size(174, 27);
            tbOznaka.TabIndex = 1;
            // 
            // tbKapacitet
            // 
            tbKapacitet.Location = new Point(457, 186);
            tbKapacitet.Name = "tbKapacitet";
            tbKapacitet.Size = new Size(125, 27);
            tbKapacitet.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(488, 269);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 2;
            btnSave.Text = "Sačuvaj";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lblNaziv
            // 
            lblNaziv.AutoSize = true;
            lblNaziv.Location = new Point(248, 49);
            lblNaziv.Name = "lblNaziv";
            lblNaziv.Size = new Size(49, 20);
            lblNaziv.TabIndex = 3;
            lblNaziv.Text = "Naziv:";
            // 
            // lblKapacitet
            // 
            lblKapacitet.AutoSize = true;
            lblKapacitet.Location = new Point(457, 154);
            lblKapacitet.Name = "lblKapacitet";
            lblKapacitet.Size = new Size(75, 20);
            lblKapacitet.TabIndex = 3;
            lblKapacitet.Text = "Kapacitet:";
            // 
            // lblOznaka
            // 
            lblOznaka.AutoSize = true;
            lblOznaka.Location = new Point(248, 154);
            lblOznaka.Name = "lblOznaka";
            lblOznaka.Size = new Size(61, 20);
            lblOznaka.TabIndex = 3;
            lblOznaka.Text = "Oznaka:";
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Location = new Point(12, 49);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(46, 20);
            lblLogo.TabIndex = 3;
            lblLogo.Text = "Logo:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmNovaProstorija
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 371);
            Controls.Add(lblLogo);
            Controls.Add(lblOznaka);
            Controls.Add(lblKapacitet);
            Controls.Add(lblNaziv);
            Controls.Add(btnSave);
            Controls.Add(tbKapacitet);
            Controls.Add(tbOznaka);
            Controls.Add(tbNaziv);
            Controls.Add(pbLogo);
            Name = "frmNovaProstorija";
            Text = "Podaci o prostoriji";
            Load += frmNovaProstorija_Load;
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbLogo;
        private TextBox tbNaziv;
        private TextBox tbOznaka;
        private TextBox tbKapacitet;
        private Button btnSave;
        private Label lblNaziv;
        private Label lblKapacitet;
        private Label lblOznaka;
        private Label lblLogo;
        private ErrorProvider errorProvider1;
    }
}