using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas1
{
    public partial class Form5 : Form
    {

        Tugas1Entities entities = new Tugas1Entities();
        Tugas1Entities1 entities1 = new Tugas1Entities1();

        public Form5()
        {
            InitializeComponent();
        }

        void validasi()
        {
            if(textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "")
            {
                MessageBox.Show("Nama, Username dan Password tidak boleh kosong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var siswa = new siswa();
                siswa.nama = textBox6.Text;
                siswa.username = textBox7.Text;
                siswa.password = textBox8.Text;

                entities.siswas.Add(siswa);
                entities.SaveChanges();
                MessageBox.Show("Siswa berhasil ditambahkan");

                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            validasi();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form4().Show();
            this.Hide();
        }
    }
}
