namespace KasirSederhana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Total() //mendeklarasikan variable global
        {
            int total, hrgmakan = 0, hrgminum = 0;
            //tryparse untuk mengubah nilai dari string ke int
            int.TryParse(tbhargamakanan.Text, out hrgmakan);
            int.TryParse(tbhargaminuman.Text, out hrgminum);
            //program membaca int / nominal
            total = hrgmakan + hrgminum;
            //convert to string = mengembalikan nilai dari 
            tbtotal.Text = Convert.ToString(total);
            //tbtotal = text box menampilkan total
        }

        private void gbharga_Enter(object sender, EventArgs e)
        {

        }

        int hargaMakananDasar = 0;
        int hargaMinumanDasar = 0;

        private void cmbmakanan_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbmakanan.SelectedIndex)
            {
                case 0: 
                    hargaMakananDasar = 12000; 
                    break;
                case 1: 
                    hargaMakananDasar = 13000;
                    break;
                case 2: 
                    hargaMakananDasar = 14000; 
                    break;
                case 3: 
                    hargaMakananDasar = 14000; 
                    break;
                case 4: 
                    hargaMakananDasar = 14000; 
                    break;
                case 5: 
                    hargaMakananDasar = 14000; 
                    break;
            }

            tbhargamakanan.Text = hargaMakananDasar.ToString();
            nudmakanan.Value = 1;

            Total();
        }

        private void cmbminuman_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbminuman.SelectedIndex)
            {
                case 0: 
                    hargaMinumanDasar = 4000;
                    break;
                case 1: 
                    hargaMinumanDasar = 5000; 
                    break;
                case 2: 
                    hargaMinumanDasar = 6000; 
                    break;
                case 3: 
                    hargaMinumanDasar = 7000; 
                    break;
            }

            // tampilkan harga awal (qty = 1)
            tbhargaminuman.Text = hargaMinumanDasar.ToString();
            nudminuman.Value = 1;

            Total();
        }

        private void btntutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnproses_Click(object sender, EventArgs e)
        {
            // Ambil data dari kontrol (semua string)
            string makanan = cmbmakanan.Text;         // nama makanan
            string jumlahMakanan = nudmakanan.Text;   // jumlah makanan
            string subMakanan = tbhargamakanan.Text;      // subtotal makanan

            string minuman = cmbminuman.Text;         // nama minuman
            string jumlahMinuman = nudminuman.Text;   // jumlah minuman
            string subMinuman = tbhargaminuman.Text;      // subtotal minuman

            string total = tbtotal.Text;           // total semua
            string bayar = tbbayar.Text;           // uang bayar
            string kembali = tbkembali.Text;         // uang kembali

            string pesan =
                "=== Struk Pesanan ===\n\n" +
                "Makanan   : " + makanan + " x " + jumlahMakanan + " = Rp" + subMakanan + "\n" +
                "Minuman   : " + minuman + " x " + jumlahMinuman + " = Rp" + subMinuman + "\n\n" +
                "Total     : Rp" + total + "\n" +
                "Bayar     : Rp" + bayar + "\n" +
                "Kembali   : Rp" + kembali;

            // Tampilkan MessageBox
            MessageBox.Show(pesan, "Struk Pembelian", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnsebelumnya_Click(object sender, EventArgs e)
        {
            Form form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void tbtotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbbayar_TextChanged(object sender, EventArgs e)
        {
            if (tbbayar.Text == "" || tbbayar.Text == "")
            {
                tbbayar.Text = "0";
            }
            else
            {
                int a = Convert.ToInt32(tbbayar.Text);
                int b = Convert.ToInt32(tbtotal.Text);
                int kembali = 0;
                kembali = a - b;     
                tbkembali.Text = kembali.ToString();
            }

        }

        private void tbkembali_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbhargamakanan_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbhargaminuman_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmakanan_Click(object sender, EventArgs e)
        {

        }

        private void txtminuman_Click(object sender, EventArgs e)
        {

        }

        private void txttotal_Click(object sender, EventArgs e)
        {

        }

        private void txtkembali_Click(object sender, EventArgs e)
        {

        }

        private void x(object sender, EventArgs e)
        {

        }

        private void nudmakanan_ValueChanged(object sender, EventArgs e)
        {
            tbhargamakanan.Text = (hargaMakananDasar * (int)nudmakanan.Value).ToString();
            Total();
        }

        private void nudminuman_ValueChanged(object sender, EventArgs e)
        {
            tbhargaminuman.Text = (hargaMinumanDasar * (int)nudminuman.Value).ToString();
            Total();
        }
    }
}
