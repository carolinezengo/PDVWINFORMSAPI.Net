
using FORMSAPI;
using FORMSAPI.Entidades;
using FORMSAPI.Metodos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORMSAPI
{
    public partial class FrmCadastroCliente : Form
    {
        public FrmCadastroCliente()
        {
            InitializeComponent();
        }


        private void CadastroCliente_Load(object sender, EventArgs e)
        {


        }

        private async void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {

                ClienteEntindade cliente = new ClienteEntindade
                {

                    Codigo = Convert.ToInt32(txtCodigo.Text),
                    Nome = txtNome.Text,
                };




                var acessaAPI = new Cliente();
                bool resposta = await acessaAPI.Incluir(cliente);
                if (resposta == true)
                {
                    txtCodigo.Text = "";
                    txtNome.Text = "";

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            FrmBuscarCliente frmBuscarCliente = new FrmBuscarCliente();
            frmBuscarCliente.ShowDialog();
        }

        private async void BtnAlterar_Click(object sender, EventArgs e)
        {

            try
            {

                ClienteEntindade cliente = new ClienteEntindade
                {
                    Codigo = Convert.ToInt32(txtCodigo.Text),
                    Nome = txtNome.Text,

                };


                int codigo = Convert.ToInt32(txtCodigo.Text);





                var acessaAPI = new Cliente();
                bool resposta = await acessaAPI.Atualizar(cliente, codigo);
                if (resposta == true)
                {
                    txtCodigo.Text = "";
                    txtNome.Text = "";

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void BtnExcluir_Click(object sender, EventArgs e)
        {

            try
            {


                int codigo = Convert.ToInt32(txtCodigo.Text);

                var acessaAPI = new Cliente();
                bool resposta = await acessaAPI.Apagar(codigo);
                if (resposta == true)
                {
                    txtCodigo.Text = "";
                    txtNome.Text = "";

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
