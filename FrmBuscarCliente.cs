using FORMSAPI.Entidades;

using FORMSAPI.Metodos;
using FORMSAPI.Servicos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORMSAPI
{
    public partial class FrmBuscarCliente : Form
    {
        public FrmBuscarCliente()
        {
            InitializeComponent();
        }
        private string URI = "";
      
     

        private async void button2_Click(object sender, EventArgs e)

        {
            HttpResponseMessage autorizacao = Autenticar.AutenticarBanco();



            if (autorizacao.IsSuccessStatusCode)
            {

                button1.Enabled = true;

            }
            else
            {
                button1.Enabled = false;
                MessageBox.Show("Nao Autorizou");
            }

        }

        private async void  button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                var acessaAPI = new Cliente();
                List<ClienteEntindade> clientes = await acessaAPI.Todos();
                dgvDadosClientes.DataSource = clientes;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }
    }

}
