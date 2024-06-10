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
    public partial class Form2 : Form
    {

        Tugas1Entities entities = new Tugas1Entities();
        Tugas1Entities1 entities1 = new Tugas1Entities1();

        public Form2()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("Username dan Password tidak boleh kosong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var user = entities.users.FirstOrDefault(u => u.username == textBox4.Text && u.password == textBox5.Text);
                if (user != null)
                {
                    new Form4().Show();
                    this.Hide();
                }
                else
                {
                    textBox4.Text = "";
                    textBox5.Text = "";
                    MessageBox.Show("Username dan Password Salah!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form3().Show();
            this.Hide();
        }
    }
}
