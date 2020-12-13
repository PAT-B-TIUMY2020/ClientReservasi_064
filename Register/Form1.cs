using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Register
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btsimpan_Click(object sender, EventArgs e)
        {
            string username = textBoxusername.Text;
            string pass = textBoxpass.Text;
            string kategori = comboBoxkat.Text;
            string a = Service.Register(username, pass, kategori);

            if(textBoxusername.Text==""||textBoxpass.Text==""||comboBoxkat.Text=="")
            {
                MessageBox.Show("Semua data wajib diisi");
            }
            else
            {
                MessageBox.Show(a);
                Refresh();
                Tampildata();
            }
        }

        private void btupdate_Click(object sender, EventArgs e)
        {
            string username = textBoxusername.Text;
            string pass = textBoxpass.Text;
            string kategori = comboBoxkat.Text;
            int id = Convert.ToInt32(textBoxusername.Text);
            string a = Service.Register(username, pass, kategori,id);
            if (textBoxusername.Text == "" || textBoxpass.Text == "" || comboBoxkat.Text == "")
            {
                MessageBox.Show("Semua data wajib diisi");
            }
            else
            {
                MessageBox.Show(a);
                Clear();
                Tampildata();
            }
        }

        private void bthapus_Click(object sender, EventArgs e)
        {
            string username = textBoxusername.Text;

            DialogResult dialogResult = MessageBox.Show("Apakah anda yakin menghapus data ini?", "Hapus data", MessageBoxButtons.YesNo);
            if (dialogResult = DialogResult.Yes)
            {
                string a = ContainerFilterService.DeleteRegister(username);
                MessageBox.Show(a);
                Clear();
                Tampildata();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        public void Clear()
        {
            textBoxpass.Clear();
            textBoxusername.Clear();
            comboBoxkat.SelectedItem = null;

            btsimpan.Enabled = true;
            btupdate.Enabled = false;
            bthapus.Enabled = false;

        }

        public void Tampildata()
        {
            var list = service.dataRegist();
            dtRegister.DataSource = list;
        }

        private void btclear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
