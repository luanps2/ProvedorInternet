using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvedorInternet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            double valor = 0;
            

            if (cboCidade.SelectedItem == "São Paulo" || cboCidade.SelectedItem == "Rio de Janeiro")
            {
                valor = 140;
                lblResultado.Text = valor.ToString("C2");

            }
            else if (cboCidade.SelectedItem == "Campo Grande")
            {
                valor = 135;
                lblResultado.Text = valor.ToString("C2");
            }
            else
            {
                valor = 120;
                lblResultado.Text = valor.ToString("C2");
            }

            if (rb10MB.Checked == true)
            {
                valor += 0;
                lblResultado.Text = valor.ToString("C2");
            }
            else if (rb30MB.Checked == true)
            {
                valor += 30;
                lblResultado.Text = valor.ToString("C2");
            }
            else if (rb60MB.Checked == true)
            {
                valor += 60;
                lblResultado.Text = valor.ToString("C2");
            }

            if (chkEmail.Checked == true)
            {
                valor += 10;
                lblResultado.Text = valor.ToString("C2");
            }

            if (chkHospedagem.Checked == true)
            {
                valor += 15;
                lblResultado.Text = valor.ToString("C2");
            }

           
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Luan da Costa oliveira Esposito" + "\r\n" + "RGM: 2294933-0");
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
