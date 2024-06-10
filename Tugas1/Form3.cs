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
    public partial class Form3 : Form
    {

        Tugas1Entities entities = new Tugas1Entities();
        Tugas1Entities1 entities1 = new Tugas1Entities1();

        public Form3()
        {
            InitializeComponent();
        }

        void validasi()
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Nama, Username dan Password tidak boleh kosong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var user = new user();
                user.nama = textBox1.Text;
                user.username = textBox2.Text;
                user.password = textBox3.Text;

                entities.users.Add(user);
                entities.SaveChanges();
                MessageBox.Show("Berhasil Register");

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            validasi();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }
    }
}
