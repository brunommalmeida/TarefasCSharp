using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViaCEP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCEP_Click(object sender, EventArgs e)
        {
            
            try
            {
                HttpClient client = new HttpClient();

                var respostaCEP = client.GetAsync("https://viacep.com.br/ws/" + mbxCEP.Text + "/json").Result;

                string conteudo = respostaCEP.Content.ReadAsStringAsync().Result;

                var retorno = JsonConvert.DeserializeObject<Rootobject>(conteudo);

                //MessageBox.Show(retorno.ToString());

                mbxCEP.Text = retorno.cep;
                txtLogradouro.Text = retorno.logradouro;
                txtComplemento.Text = retorno.complemento;
                txtBairro.Text = retorno.bairro;
                txtLocalidade.Text = retorno.localidade;
                txtUF.Text = retorno.uf;
                txtUnidade.Text = retorno.unidade;
                txtIBGE.Text = retorno.ibge;
                txtGIA.Text = retorno.gia;
            }

            catch (Exception a)
            {
                MessageBox.Show("Erro: " + a.Message);
            }

        }

        private void limparTextBoxes(Control.ControlCollection controles)
        {
            //Faz um laço para todos os controles passados no parâmetro
            foreach (Control ctrl in controles)
            {
                //Se o contorle for um TextBox...
                if (ctrl is TextBox)
                {
                    ((TextBox)(ctrl)).Text = String.Empty;

                }
                //Se o contorle for um MaskedBox...
                if (ctrl is MaskedTextBox)
                {
                    ((MaskedTextBox)(ctrl)).Text = String.Empty;

                }
            }
        }
        private void rbtnLimpar_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtnLimpar.Checked)
            {
                limparTextBoxes(this.Controls);
               
            }
            rbtnLimpar.Checked = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnCEP;
        }
    }

    public class Rootobject
    {
        public string cep { get; set; }
        public string logradouro { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string localidade { get; set; }
        public string uf { get; set; }
        public string unidade { get; set; }
        public string ibge { get; set; }
        public string gia { get; set; }
    }

}
