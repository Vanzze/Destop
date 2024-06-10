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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            new Form5().Show();
            this.Hide();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            new Form6().Show(); 
            this.Hide();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            new Form7().Show();
            this.Hide();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            new Form5().Show();
            this.Hide();
        }
    }
}
