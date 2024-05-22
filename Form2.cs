using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nikmaaa3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void box_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            double bpminibus, bpbus, bpmobil, bptotalBiaya, bpUang, bpbiayaPajak, bpKembalian;
            double hargaminibus, hargabus, hargamobil, bptotalPembayaran;

            bpminibus = double.Parse(box.Text);
            bpbus = double.Parse(textBox5.Text);
            bpmobil = double.Parse(textBox4.Text);
            bpUang = double.Parse(textBox2.Text);

            hargaminibus = bpminibus * 1000000;
            hargabus = bpbus * 1500000;
            hargamobil = bpmobil * 500000;

            bptotalBiaya = hargaminibus + hargabus + hargamobil;
            bpbiayaPajak = bptotalBiaya * 0.1;

            bptotalPembayaran = bptotalBiaya + bpbiayaPajak;
            bpKembalian = bpUang - bptotalPembayaran;

            textBox7.Text =  "Rp." + bptotalBiaya.ToString("N");
            textBox6.Text = "Rp." + bptotalBiaya.ToString("N");
            textBox3.Text = "Rp." + bptotalPembayaran.ToString("N");
            textBox8.Text = "Rp." + bpKembalian.ToString("N");
        }
    }
}
