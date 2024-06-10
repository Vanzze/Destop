using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas1
{
    public partial class Form6 : Form
    {

        Tugas1Entities entities = new Tugas1Entities();

        public Form6()
        {
            InitializeComponent();
        }

        int ids;

        void searchData()
        {
            var searchResults = entities.siswas.Where(u => u.nama.Contains(textBox13.Text)).ToList();
            dataGridView1.DataSource = searchResults;
        }

        void btnDeleteEdit()
        {
            var btnDelete = new DataGridViewButtonColumn();
            btnDelete.Text = "Delete";
            btnDelete.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btnDelete);

            var btnEdit = new DataGridViewButtonColumn();
            btnEdit.Text = "Edit";
            btnEdit.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btnEdit);

        }

        void menampilkanData()
        {
            var siswa = entities.siswas.Select(u => u);
            //var user = from u in entities.siswas 
                       //select u;
            
            dataGridView1.DataSource = siswa.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var cellValue = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            var rowDipilih = dataGridView1.Rows[e.RowIndex];

            if(cellValue != null && cellValue.ToString() == "Delete")
            {
                var dialog = MessageBox.Show("Apakah anda yakin untuk menghapus data ini?", "Konfirmasi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if(dialog == DialogResult.OK)
                {
                    int userId = Convert.ToInt32(rowDipilih.Cells["id"].Value);
                    var siswa = entities.siswas.FirstOrDefault(u => u.id == userId);
                    entities.siswas.Remove(siswa);
                    entities.SaveChanges();
                    MessageBox.Show(rowDipilih.Cells["username"].Value + "Berhasil Dihapus");
                    menampilkanData();
                }

            }else if (cellValue != null && cellValue.ToString() == "Delete")
            {
                var nama = rowDipilih.Cells["nama"].Value.ToString();
                var username = rowDipilih.Cells["username"].Value.ToString();
                var id = rowDipilih.Cells["id"].Value.ToString();
                var password = rowDipilih.Cells["password"].Value.ToString();
                textBox9.Text = username;
                textBox10.Text = nama;
                textBox11.Text = password;
                textBox12.Text = id;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form4().Show();
            this.Hide();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            menampilkanData();
            btnDeleteEdit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var siswaId = Convert.ToInt32(textBox12.Text);
            var siswa = entities.siswas.FirstOrDefault();

            if (siswa != null) 
            {
                siswa.nama = textBox10.Text;
                entities.SaveChanges();

                siswa.username = textBox9.Text;
                entities.SaveChanges();

                siswa.password = textBox11.Text;
                entities.SaveChanges();

                int userId = Convert.ToInt32(textBox12.Text);
                entities.SaveChanges();

                menampilkanData();
                MessageBox.Show(siswa.username + "Berhasil Diupdate");
            }
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            searchData();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            
        }
    }
}
