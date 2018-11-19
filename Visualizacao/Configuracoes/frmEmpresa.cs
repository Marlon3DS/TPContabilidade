using Modelos;
using System;
using System.Windows.Forms;

namespace Configuracoes
{
    public partial class frmEmpresa : Form
    {
        public Empresa empresa { get; private set; }
        public frmEmpresa()
        {
            InitializeComponent();
        }

        public frmEmpresa(Empresa empresa)
        {
            InitializeComponent();
            if (empresa != null)
            {
                txtCnpj.Enabled = false;
                txtRazao.Enabled = false;
                txtNome.Enabled = false;
                txtCapital.Enabled = false;
                btnAcao.Text = "OK";
                this.empresa = empresa;
                txtCnpj.Text = this.empresa.Cnpj;
                txtRazao.Text = this.empresa.RazaoSocial;
                txtNome.Text = this.empresa.NomeFantasia;
                txtCapital.Text = this.empresa.Capital.ToString();
            }
            else
            {
                this.empresa = new Empresa();
            }
        }

        private void btnAcao_Click(object sender, EventArgs e)
        {
            if (btnAcao.Text.ToLower() == "salvar")
            {
                empresa.Cnpj = txtCnpj.Text;
                empresa.RazaoSocial = txtRazao.Text;
                empresa.NomeFantasia = txtNome.Text;
                empresa.Capital = Convert.ToDouble(txtCapital.Text);
            }
            Close();
        }
    }
}
