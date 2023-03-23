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
            bool cek = false;
            foreach (DataRow dr in coba.Rows)
            {
                if (dr[2].ToString() == textBox3.Text && dr[1].ToString() == textBox2.Text && dr[0].ToString() == textBox1.Text)
                {
                    cek=true;
                }
            }
            if (cek == false)
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
