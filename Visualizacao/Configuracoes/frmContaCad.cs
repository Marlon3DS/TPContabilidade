using Controles;
using Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Configuracoes
{
    public partial class frmContaCad : Form
    {
        public frmContaCad()
        {
            InitializeComponent();
            this.Text = "Nova Conta T";
            txtSaldo.Text = string.Format("R${0:F2}", 0.00);
            //CarregarTipos();
        }
        public frmContaCad(ContaT conta)
        {
            InitializeComponent();
            this.Text = "Alterar Conta " + conta.Nome;
            txtId.Text = conta.Id.ToString();
            txtNome.Text = conta.Nome;
            cmbTipo.Text = conta.TipoConta;
            txtSaldo.Text = string.Format("R${0:F2}", conta.Saldo.ToString());
            CarregarTipos();
        }

        private void CarregarTipos()
        {
            cmbTipo.DataSource = Enum.GetNames(typeof(TipoConta));
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                ContaT contaT = new ContaT();
                contaT.Nome = txtNome.Text;
                contaT.TipoConta = cmbTipo.Text;
                string saldo = txtSaldo.Text.Remove(0,2);
                contaT.Saldo = double.Parse(saldo);
                PersistenciaContas persistencia = new PersistenciaContas();
                string retorno = "";
                try
                { 
                    if (txtId.Text != "")
                    {
                        contaT.Id = int.Parse(txtId.Text);
                        retorno = persistencia.Alterar(contaT, Modelo.Contas);
                    }
                    else
                    {
                        retorno = persistencia.Inserir(contaT, Modelo.Contas);                    
                    }
                }
                catch (Exception mensagem)
                {
                    ExibirErro(mensagem.ToString());
                }

                int resultado = -1;
                int.TryParse(retorno, out resultado);
                if (resultado == -1)
                {
                    ExibirErro(retorno);
                }
                else
                {
                    MessageBox.Show("Operação concluida com sucesso, para o Id: " + resultado);
                    this.Close();
                }
            }
            else
            {
                ExibirErro("Preencha todos os Campos.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                DialogResult result = MessageBox.Show("Deseja Cancelar a Operação?\nOs valores que não estiverem Salvos serão perdidos.", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
                else
                {
                    txtNome.Focus();
                }
            }
            this.Close();
        }

        private bool ValidarCampos()
        {
            if (txtNome.Text == "" || cmbTipo.Text == "")
            {
                return false;
            }
            return true;
        }

        private void ExibirErro(string mensagem)
        {
            MessageBox.Show("Não foi possivel realizar a operação.\n" + mensagem, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
