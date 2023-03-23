using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace omagahhh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void taimer_Tick(object sender, EventArgs e)
        {
            lebel.Text = DateTime.Now.ToString("F");
            if (progress.Value < progress.Maximum)
            {
                progress.Value += 10;
            }
            else
            {
                progress.Value += 0;
            }
        }
        DataTable coba = new DataTable();
        private void Form1_Load(object sender, EventArgs e)
        {
            coba.Columns.Add("Nama");
            coba.Columns.Add("Tim");
            coba.Columns.Add("Stadion");
            bruh.DataSource = coba;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int cek = 0;
            foreach (DataGridViewRow dr in bruh.Rows)
            {
                if (dr.Cells[2].Value == textBox3.Text || dr.Cells[1].Value == textBox2.Text || dr.Cells[0].Value == textBox1.Text)
                {
                    cek++;
                }
            }
            if (cek == 0)
            {
                coba.Rows.Add(textBox1.Text,textBox2.Text, textBox3.Text);
                bruh.DataSource = coba;
            }
            else
            {
                MessageBox.Show("salah");
            }
        }
    }
}
