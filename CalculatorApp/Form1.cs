using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double nilaia, nilaib, hasil;

            if (operasi.SelectedIndex == -1)
            {
                MessageBox.Show("Operasi Belum Dipilih");
            }
            else if (operasi.SelectedIndex == 0)
            {
                nilaia = Double.Parse(angka1.Text);
                nilaib = Double.Parse(angka2.Text);
                hasil = nilaia + nilaib;
                hasilteks.Text = hasil.ToString();
            }
            else if (operasi.SelectedIndex == 1)
            {
                nilaia = Double.Parse(angka1.Text);
                nilaib = Double.Parse(angka2.Text);
                hasil = nilaia - nilaib;
                hasilteks.Text = hasil.ToString();
            }
            else if (operasi.SelectedIndex == 2)
            {
                nilaia = Double.Parse(angka1.Text);
                nilaib = Double.Parse(angka2.Text);
                hasil = nilaia * nilaib;
                hasilteks.Text = hasil.ToString();
            }
            else if (operasi.SelectedIndex == 3)
            {
                nilaia = Double.Parse(angka1.Text);
                nilaib = Double.Parse(angka2.Text);
                hasil = nilaia / nilaib;
                hasilteks.Text = hasil.ToString();
            }
        }
    }
}
