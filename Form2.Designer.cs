namespace KasirSederhana
{
    partial class Form2
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
            txtusername = new Label();
            txtpassword = new Label();
            tbusername = new TextBox();
            tbpassword = new TextBox();
            btnmasuk = new Button();
            title = new Label();
            subtitle = new Label();
            btnkeluar = new Button();
            SuspendLayout();
            // 
            // txtusername
            // 
            txtusername.AutoSize = true;
            txtusername.Location = new Point(146, 82);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(60, 15);
            txtusername.TabIndex = 0;
            txtusername.Text = "Username";
            txtusername.Click += txtusername_Click;
            // 
            // txtpassword
            // 
            txtpassword.AutoSize = true;
            txtpassword.Location = new Point(146, 130);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(57, 15);
            txtpassword.TabIndex = 1;
            txtpassword.Text = "Password";
            txtpassword.Click += txtpassword_Click;
            // 
            // tbusername
            // 
            tbusername.Location = new Point(221, 79);
            tbusername.Name = "tbusername";
            tbusername.Size = new Size(203, 23);
            tbusername.TabIndex = 2;
            tbusername.TextChanged += tbusername_TextChanged;
            // 
            // tbpassword
            // 
            tbpassword.Location = new Point(221, 127);
            tbpassword.Name = "tbpassword";
            tbpassword.Size = new Size(203, 23);
            tbpassword.TabIndex = 3;
            tbpassword.TextChanged += tbpassword_TextChanged;
            // 
            // btnmasuk
            // 
            btnmasuk.Location = new Point(194, 180);
            btnmasuk.Name = "btnmasuk";
            btnmasuk.Size = new Size(75, 23);
            btnmasuk.TabIndex = 4;
            btnmasuk.Text = "Masuk";
            btnmasuk.UseVisualStyleBackColor = true;
            btnmasuk.Click += btnmasuk_Click;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title.Location = new Point(221, 9);
            title.Name = "title";
            title.Size = new Size(91, 21);
            title.TabIndex = 5;
            title.Text = "Kasir Ajaib";
            title.Click += title_Click;
            // 
            // subtitle
            // 
            subtitle.AutoSize = true;
            subtitle.Location = new Point(100, 43);
            subtitle.Name = "subtitle";
            subtitle.Size = new Size(354, 15);
            subtitle.TabIndex = 6;
            subtitle.Text = "Sebelum masuk kamu wajib memasukan username dan password";
            subtitle.Click += subtitle_Click;
            // 
            // btnkeluar
            // 
            btnkeluar.Location = new Point(295, 180);
            btnkeluar.Name = "btnkeluar";
            btnkeluar.Size = new Size(75, 23);
            btnkeluar.TabIndex = 7;
            btnkeluar.Text = "Keluar";
            btnkeluar.UseVisualStyleBackColor = true;
            btnkeluar.Click += btnkeluar_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 266);
            Controls.Add(btnkeluar);
            Controls.Add(subtitle);
            Controls.Add(title);
            Controls.Add(btnmasuk);
            Controls.Add(tbpassword);
            Controls.Add(tbusername);
            Controls.Add(txtpassword);
            Controls.Add(txtusername);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtusername;
        private Label txtpassword;
        private TextBox tbusername;
        private TextBox tbpassword;
        private Button btnmasuk;
        private Label title;
        private Label subtitle;
        private Button btnkeluar;
    }
}