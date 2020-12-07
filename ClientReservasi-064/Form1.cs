using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceReservasi;

using System.Windows.Forms;

namespace ClientReservasi_064
{
    public partial class Form1 : Form
    {
        ServiceReference1.Service1Client service = new ServiceReference1.Service1Client();
        public Form1()
        {
            InitializeComponent();
        }

        private void btSimpan_Click(object sender, EventArgs e)
        {
            string IDPemesanan = textBoxID.Text;
            string NamaCustomer = textBoxnama.Text;
            string NoTelepon = textBoxNotlf.Text;
            int JumlahPemesanan = int.Parse(textBoxjumlah.Text);
            string IDLokasi = textBoxIDLokasi.Text;

            var a = Service.pemesanan(IDPemesanan, NamaCustomer, NoTelepon, JumlahPemesanan, IDLokasi);
            MessageBox.Show(a);
            Tampildata();
            Clear();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            string IDPemesanan = textBoxID.Text;
            string NamaCustomer = textBoxnama.Text;
            string NoTelepon = textBoxNotlf.Text;

            var a = service.editPemesanan(IDPemesanan, NamaCustomer, NoTelepon);
            MessageBox.Show(a);
            Tampildata();
            Clear();
        }

        private void btHapus_Click(object sender, EventArgs e)
        {
            string IDPemesanan = textBoxID.Text;

            var a = service.deletepemesanan(IDPemesanan);
            MessageBox.Show(a);
            Tampildata();
            Clear();
        }

        public void Clear()
        {
            textBoxID.Clear();
            textBoxnama.Clear();
            textBoxNotlf.Clear();
            textBoxjumlah.Clear();
            textBoxIDLokasi.Clear();

            textBoxjumlah.Enabled = true;
            textBoxIDLokasi.Enabled = true;

            btSimpan.Enabled = true;
            btUpdate.Enabled = false;
            btHapus.Enabled = false;

            textBoxID.Enabled = true;
        }

        private void Tampildata()
        {
            var List = service.Pemesanan1();
            dtPemesanan.DataSource = List;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dtPemesanan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxID.Text = Convert.ToString(dtPemesanan.Rows[e.RowIndex].Cells[0].Value);
            textBoxnama.Text = Convert.ToString(dtPemesanan.Rows[e.RowIndex].Cells[1].Value);
            textBoxNotlf.Text = Convert.ToString(dtPemesanan.Rows[e.RowIndex].Cells[2].Value);
            textBoxjumlah.Text = Convert.ToString(dtPemesanan.Rows[e.RowIndex].Cells[3].Value);
            textBoxIDLokasi.Text = Convert.ToString(dtPemesanan.Rows[e.RowIndex].Cells[4].Value);

            textBoxjumlah.Enabled = false;
            textBoxIDLokasi.Enabled = false;

            btUpdate.Enabled = true;
            btHapus.Enabled = true;

            btSimpan.Enabled = false;
            textBoxID.Enabled = false;
        }

        /* public Form1()
        {
            InitializeComponent();

            Tampildata();
            btUpdate.Enabled = false;
            btHapus.Enabled = false;
        } */

    }
}
