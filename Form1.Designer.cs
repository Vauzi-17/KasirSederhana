namespace KasirSederhana
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtmakanan = new Label();
            txtminuman = new Label();
            cmbmakanan = new ComboBox();
            cmbminuman = new ComboBox();
            gbmakanminum = new GroupBox();
            nudminuman = new NumericUpDown();
            nudmakanan = new NumericUpDown();
            gbharga = new GroupBox();
            tbhargaminuman = new TextBox();
            tbhargamakanan = new TextBox();
            tbtotal = new TextBox();
            tbbayar = new TextBox();
            tbkembali = new TextBox();
            txttotal = new Label();
            txtbayar = new Label();
            txtkembali = new Label();
            btnsebelumnya = new Button();
            btnproses = new Button();
            btntutup = new Button();
            txtnamakasir = new Label();
            tbnamakasir = new TextBox();
            gbmakanminum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudminuman).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudmakanan).BeginInit();
            gbharga.SuspendLayout();
            SuspendLayout();
            // 
            // txtmakanan
            // 
            txtmakanan.AutoSize = true;
            txtmakanan.Location = new Point(17, 53);
            txtmakanan.Name = "txtmakanan";
            txtmakanan.Size = new Size(82, 15);
            txtmakanan.TabIndex = 1;
            txtmakanan.Text = "Pilih Makanan";
            txtmakanan.Click += txtmakanan_Click;
            // 
            // txtminuman
            // 
            txtminuman.AutoSize = true;
            txtminuman.Location = new Point(17, 131);
            txtminuman.Name = "txtminuman";
            txtminuman.Size = new Size(85, 15);
            txtminuman.TabIndex = 2;
            txtminuman.Text = "Pilih Minuman";
            txtminuman.Click += txtminuman_Click;
            // 
            // cmbmakanan
            // 
            cmbmakanan.FormattingEnabled = true;
            cmbmakanan.Items.AddRange(new object[] { "Nasi Goreng", "Nasi", "Lele Goreng", "Pecel Lele", "Ayam Goreng", "Bebek Goreng" });
            cmbmakanan.Location = new Point(105, 50);
            cmbmakanan.Name = "cmbmakanan";
            cmbmakanan.Size = new Size(121, 23);
            cmbmakanan.TabIndex = 3;
            cmbmakanan.SelectedIndexChanged += cmbmakanan_SelectedIndexChanged;
            // 
            // cmbminuman
            // 
            cmbminuman.FormattingEnabled = true;
            cmbminuman.Items.AddRange(new object[] { "Es Teh", "Susu", "Kopi", "Jeruk" });
            cmbminuman.Location = new Point(105, 128);
            cmbminuman.Name = "cmbminuman";
            cmbminuman.Size = new Size(121, 23);
            cmbminuman.TabIndex = 4;
            cmbminuman.SelectedIndexChanged += cmbminuman_SelectedIndexChanged;
            // 
            // gbmakanminum
            // 
            gbmakanminum.Controls.Add(nudminuman);
            gbmakanminum.Controls.Add(nudmakanan);
            gbmakanminum.Controls.Add(cmbminuman);
            gbmakanminum.Controls.Add(txtmakanan);
            gbmakanminum.Controls.Add(cmbmakanan);
            gbmakanminum.Controls.Add(txtminuman);
            gbmakanminum.Location = new Point(26, 25);
            gbmakanminum.Name = "gbmakanminum";
            gbmakanminum.Size = new Size(249, 222);
            gbmakanminum.TabIndex = 5;
            gbmakanminum.TabStop = false;
            gbmakanminum.Text = "Daftar Makanan dan Minuman";
            // 
            // nudminuman
            // 
            nudminuman.Location = new Point(105, 167);
            nudminuman.Name = "nudminuman";
            nudminuman.Size = new Size(120, 23);
            nudminuman.TabIndex = 17;
            nudminuman.ValueChanged += nudminuman_ValueChanged;
            // 
            // nudmakanan
            // 
            nudmakanan.Location = new Point(105, 90);
            nudmakanan.Name = "nudmakanan";
            nudmakanan.Size = new Size(120, 23);
            nudmakanan.TabIndex = 16;
            nudmakanan.ValueChanged += nudmakanan_ValueChanged;
            // 
            // gbharga
            // 
            gbharga.Controls.Add(tbhargaminuman);
            gbharga.Controls.Add(tbhargamakanan);
            gbharga.Location = new Point(352, 25);
            gbharga.Name = "gbharga";
            gbharga.Size = new Size(249, 151);
            gbharga.TabIndex = 6;
            gbharga.TabStop = false;
            gbharga.Text = "Total Harga";
            gbharga.Enter += gbharga_Enter;
            // 
            // tbhargaminuman
            // 
            tbhargaminuman.Location = new Point(23, 111);
            tbhargaminuman.Name = "tbhargaminuman";
            tbhargaminuman.Size = new Size(204, 23);
            tbhargaminuman.TabIndex = 1;
            tbhargaminuman.TextChanged += tbhargaminuman_TextChanged;
            // 
            // tbhargamakanan
            // 
            tbhargamakanan.Location = new Point(23, 45);
            tbhargamakanan.Name = "tbhargamakanan";
            tbhargamakanan.Size = new Size(204, 23);
            tbhargamakanan.TabIndex = 0;
            tbhargamakanan.TextChanged += tbhargamakanan_TextChanged;
            // 
            // tbtotal
            // 
            tbtotal.Location = new Point(375, 211);
            tbtotal.Name = "tbtotal";
            tbtotal.Size = new Size(204, 23);
            tbtotal.TabIndex = 7;
            tbtotal.TextChanged += tbtotal_TextChanged;
            // 
            // tbbayar
            // 
            tbbayar.Location = new Point(375, 250);
            tbbayar.Name = "tbbayar";
            tbbayar.Size = new Size(204, 23);
            tbbayar.TabIndex = 8;
            tbbayar.TextChanged += tbbayar_TextChanged;
            // 
            // tbkembali
            // 
            tbkembali.Location = new Point(375, 288);
            tbkembali.Name = "tbkembali";
            tbkembali.Size = new Size(204, 23);
            tbkembali.TabIndex = 9;
            tbkembali.TextChanged += tbkembali_TextChanged;
            // 
            // txttotal
            // 
            txttotal.AutoSize = true;
            txttotal.Location = new Point(331, 214);
            txttotal.Name = "txttotal";
            txttotal.Size = new Size(33, 15);
            txttotal.TabIndex = 10;
            txttotal.Text = "Total";
            txttotal.Click += txttotal_Click;
            // 
            // txtbayar
            // 
            txtbayar.AutoSize = true;
            txtbayar.Location = new Point(331, 253);
            txtbayar.Name = "txtbayar";
            txtbayar.Size = new Size(36, 15);
            txtbayar.TabIndex = 11;
            txtbayar.Text = "Bayar";
            txtbayar.Click += x;
            // 
            // txtkembali
            // 
            txtkembali.AutoSize = true;
            txtkembali.Location = new Point(319, 291);
            txtkembali.Name = "txtkembali";
            txtkembali.Size = new Size(50, 15);
            txtkembali.TabIndex = 12;
            txtkembali.Text = "Kembali";
            txtkembali.Click += txtkembali_Click;
            // 
            // btnsebelumnya
            // 
            btnsebelumnya.Location = new Point(112, 385);
            btnsebelumnya.Name = "btnsebelumnya";
            btnsebelumnya.Size = new Size(79, 23);
            btnsebelumnya.TabIndex = 13;
            btnsebelumnya.Text = "Keluar";
            btnsebelumnya.UseVisualStyleBackColor = true;
            btnsebelumnya.Click += btnsebelumnya_Click;
            // 
            // btnproses
            // 
            btnproses.Location = new Point(319, 385);
            btnproses.Name = "btnproses";
            btnproses.Size = new Size(75, 23);
            btnproses.TabIndex = 14;
            btnproses.Text = "Proses";
            btnproses.UseVisualStyleBackColor = true;
            btnproses.Click += btnproses_Click;
            // 
            // btntutup
            // 
            btntutup.Location = new Point(526, 385);
            btntutup.Name = "btntutup";
            btntutup.Size = new Size(75, 23);
            btntutup.TabIndex = 15;
            btntutup.Text = "Tutup";
            btntutup.UseVisualStyleBackColor = true;
            btntutup.Click += btntutup_Click;
            // 
            // txtnamakasir
            // 
            txtnamakasir.AutoSize = true;
            txtnamakasir.Location = new Point(297, 322);
            txtnamakasir.Name = "txtnamakasir";
            txtnamakasir.Size = new Size(67, 15);
            txtnamakasir.TabIndex = 16;
            txtnamakasir.Text = "Nama Kasir";
            // 
            // tbnamakasir
            // 
            tbnamakasir.Location = new Point(375, 319);
            tbnamakasir.Name = "tbnamakasir";
            tbnamakasir.Size = new Size(204, 23);
            tbnamakasir.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(tbnamakasir);
            Controls.Add(txtnamakasir);
            Controls.Add(btntutup);
            Controls.Add(btnproses);
            Controls.Add(btnsebelumnya);
            Controls.Add(txtkembali);
            Controls.Add(txtbayar);
            Controls.Add(txttotal);
            Controls.Add(tbkembali);
            Controls.Add(tbbayar);
            Controls.Add(tbtotal);
            Controls.Add(gbharga);
            Controls.Add(gbmakanminum);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            gbmakanminum.ResumeLayout(false);
            gbmakanminum.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudminuman).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudmakanan).EndInit();
            gbharga.ResumeLayout(false);
            gbharga.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtmakanan;
        private Label txtminuman;
        private ComboBox cmbmakanan;
        private ComboBox cmbminuman;
        private GroupBox gbmakanminum;
        private GroupBox gbharga;
        private TextBox tbhargaminuman;
        private TextBox tbhargamakanan;
        private TextBox tbtotal;
        private TextBox tbbayar;
        private TextBox tbkembali;
        private Label txttotal;
        private Label txtbayar;
        private Label txtkembali;
        private Button btnsebelumnya;
        private Button btnproses;
        private Button btntutup;
        private NumericUpDown nudminuman;
        private NumericUpDown nudmakanan;
        private Label txtnamakasir;
        private TextBox tbnamakasir;
    }
}
