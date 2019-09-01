using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PVolume
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        { 
                double raio, altura;

                if ((double.TryParse(txtRaio.Text, out raio) &&
                     double.TryParse(txtAltura.Text, out altura)))
                {
                    if (raio <= 0 || altura <= 0)
                        MessageBox.Show("Os valores devem ser maiores que 0");
                    else
                    {
                        double Volume = (Math.PI * Math.Pow(raio, 2)) * altura;
                        txtVolume.Text = Volume.ToString("N2");
                    }
                }
                else
                    MessageBox.Show("Dados inválidos");

        }

        private void txtRaio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)13) // se enter
            {
                SendKeys.Send("{TAB}");
                e.Handled = true; // para remover aquele som
            }
        }

        private void txtAltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)13) // se enter
            {
                SendKeys.Send("{TAB}");
                e.Handled = true; // para remover aquele som
            }
        }

    }
}
