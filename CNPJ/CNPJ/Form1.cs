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


namespace CNPJ
{
    public partial class Form1 : Form
    {
        string matriz1 = "", matriz2 = "", matriz3 = "";
        public Form1()
        {
            InitializeComponent();

        }
        private void btnApi_Click(object sender, EventArgs e)
        {
            string conteudo = "";

            try
            {
                HttpClient client = new HttpClient();
                var resposta = client.GetAsync("https://www.receitaws.com.br/v1/cnpj/" + mtxtCNPJ.Text).Result;

                 conteudo = resposta.Content.ReadAsStringAsync().Result;

                var retorno = JsonConvert.DeserializeObject<Rootobject>(conteudo);



                foreach (Atividade_Principal atividade in retorno.atividade_principal)
                {
                    rtxtAtividadePrincipal.Text = "text: " + atividade.text + "\n"
                        + "code: " + atividade.code;

                    matriz1 += "\ntext: " + atividade.text + "\n"
                        + "code: " + atividade.code + "\n";
                }

                txtDataSituacao.Text = retorno.Data_situacao;
                txtNome.Text = retorno.Nome;
                txtUF.Text = retorno.Uf;
                txtTelefone.Text = retorno.Telefone;

                foreach (Atividades_Secundarias atividadeSec in retorno.atividades_secundarias)
                {
                    rtxtAtividadeSecundaria.Text = "text: " + atividadeSec.text + "\n"
                        + "code: " + atividadeSec.code;
                    matriz2 += "\ntext: " + atividadeSec.text + "\n"
                        + "code: " + atividadeSec.code + "\n";
                }

                foreach (Qsa quadSocio in retorno.qsa)
                {
                    rtxtQsa.Text = "text: " + quadSocio.qual + "\n"
                        + "code: " + quadSocio.nome;

                    matriz3 += rtxtQsa.Text = "\ntext: " + quadSocio.qual + "\n"
                        + "code: " + quadSocio.nome + "\n";
                }

                txtSituacao.Text = retorno.Situacao;
                txtBairro.Text = retorno.Bairro;
                txtLogradouro.Text = retorno.Logradouro;
                txtNumero.Text = retorno.Numero;
                txtCep.Text = retorno.Cep;
                txtMunicipio.Text = retorno.Municipio;
                txtPorte.Text = retorno.Porte;
                txtAbertura.Text = retorno.Abertura;
                txtNaturezaJuridica.Text = retorno.Natureza_juridica;
                txtFantasia.Text = retorno.Fantasia;
                txtCNPJ2.Text = retorno.Cnpj;
                txtUltimaAtt.Text = retorno.Ultima_atualizacao.Date.ToString();
                txtStatus.Text = retorno.Status;
                txtTipo.Text = retorno.Tipo;
                txtComplemento.Text = retorno.Complemento;
                txtEmail.Text = retorno.Email;
                txtEfr.Text = retorno.Efr;
                txtMotivoSituacao.Text = retorno.Motivo_situacao;
                txtSituacaoEspecial.Text = retorno.Situacao_especial;
                txtDataSitEsp.Text = retorno.Data_situacao_especial;
                txtCapitalSocial.Text = retorno.Capital_social;
                txtExtra.Text = "";

                rtxtBilling.Text = "free: " + retorno.billing.free.ToString() + "\n";
                rtxtBilling.Text += "database: " + retorno.billing.database.ToString();


                ////rtxtResultado.Text  += retorno.Data_situacao + "\n"
                //+retorno.Nome + "\n"
                //+ retorno.Uf + "\n"
                //+ retorno.Telefone + "\n"
                //+ retorno.atividades_secundarias + "\n"
                //+ retorno.qsa + "\n"
                //+ retorno.Situacao + "\n
                //+ retorno.Bairro + "\n"
                //+ retorno.Logradouro + "\n"
                //+ retorno.Numero + "\n"
                //+ retorno.Cep + "\n"
                //+ retorno.Municipio + "\n"
                //+ retorno.Porte + "\n"
                //+ retorno.Abertura + "\n"
                //+ retorno.Natureza_juridica + "\n"
                //+ retorno.Fantasia + "\n"
                //+ retorno.Cnpj + "\n"
                //+ retorno.Ultima_atualizacao + "\n"
                //+ retorno.Status + "\n"
                //+ retorno.Tipo + "\n"
                //+ retorno.Complemento + "\n"
                //+ retorno.Email + "\n"
                //+ retorno.Efr + "\n"
                //+ retorno.Motivo_situacao + "\n"
                //+ retorno.Situacao_especial + "\n"
                //+ retorno.Data_situacao_especial + "\n"
                //+ retorno.Capital_social + "\n"
                //+ retorno.extra + "\n"
                //+ retorno.billing;
            }
            catch (Exception a)
            {
                MessageBox.Show("Erro: " + a.Message);
            }
        }
    private void btnAtividadeSecundaria_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show(matriz2);
        }

        private void btnQsa_Click(object sender, EventArgs e)
        {
      
            MessageBox.Show(matriz3);
        }

        private void btnAtividadePrincipal_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show(matriz1);

        }

        private void mtxtCNPJ_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == 13)
            //{
            //    btnApi
            //    //MessageBox.Show("Você apertou a tecla enter");
            //}
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnApi;
        }
    }


    //public struct DadosAtividadePrincipal
    //{
    //    public string text;
    //    public string code;
    //}

    //public struct DadosAtividadesSecundarias
    //{
    //    public string text;
    //    public string code;
    //}
    //public struct DadosQsa
    //{
    //    public string qual;
    //    public string nome;
    //}
    public class Rootobject
    {
        public Atividade_Principal[] atividade_principal { get; set; }
        public string Data_situacao { get; set; }
        public string Nome { get; set; }
        public string Uf { get; set; }
        public string Telefone { get; set; }
        public Atividades_Secundarias[] atividades_secundarias { get; set; }
        public Qsa[] qsa { get; set; }
        public string Situacao { get; set; }
        public string Bairro { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Cep { get; set; }
        public string Municipio { get; set; }
        public string Porte { get; set; }
        public string Abertura { get; set; }
        public string Natureza_juridica { get; set; }
        public string Fantasia { get; set; }
        public string Cnpj { get; set; }
        public DateTime Ultima_atualizacao { get; set; }
        public string Status { get; set; }
        public string Tipo { get; set; }
        public string Complemento { get; set; }
        public string Email { get; set; }
        public string Efr { get; set; }
        public string Motivo_situacao { get; set; }
        public string Situacao_especial { get; set; }
        public string Data_situacao_especial { get; set; }
        public string Capital_social { get; set; }
        public Extra extra { get; set; }
        public Billing billing { get; set; }
    }

    public class Extra
    {
    }

    public class Billing
    {
        public bool free { get; set; }
        public bool database { get; set; }
    }

    public class Atividade_Principal
    {
        public string text { get; set; }
        public string code { get; set; }
    }

    public class Atividades_Secundarias
    {
        public string text { get; set; }
        public string code { get; set; }
    }

    public class Qsa
    {
        public string qual { get; set; }
        public string nome { get; set; }
    }



}
