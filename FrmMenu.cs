using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORMSAPI
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            FrmCadastroCliente cliente = new FrmCadastroCliente();
            cliente.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmCadastroProduto produto = new FrmCadastroProduto();
            produto.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmCadastroFornecedor fornecedor = new FrmCadastroFornecedor();
            fornecedor.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmPDV fornecedor = new FrmPDV();
            fornecedor.ShowDialog();

        }
    }
}
