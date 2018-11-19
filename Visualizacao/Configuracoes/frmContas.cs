using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controles;
using Modelos;

namespace Configuracoes
{
    public partial class frmContas : Form
    {
        public frmContas()
        {
            InitializeComponent();
            PesquisarContas();
        }

        public void PesquisarContas()
        {
            PersistenciaContas persistencia = new PersistenciaContas();
            dtgView.DataSource = null;
            dtgView.DataSource = persistencia.ConsultarConta();
            dtgView.Update();
            dtgView.Refresh();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            frmContaCad conta = new frmContaCad();
            conta.ShowDialog();
            PesquisarContas();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dtgView.SelectedRows.Count > 0)
            {
                ContaT contaT = (dtgView.SelectedRows[0].DataBoundItem as ContaT);
                frmContaCad conta = new frmContaCad(contaT);
                conta.ShowDialog();
                PesquisarContas();
            }
            else
            {
                ExibirErro("Selecione uma Conta!");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dtgView.SelectedRows.Count > 0)
            {
                ContaT contaT = (dtgView.SelectedRows[0].DataBoundItem as ContaT);
                try
                {
                    PersistenciaContas persistencia = new PersistenciaContas();
                    string retorno = persistencia.Excluir(contaT, Modelo.Contas);
                    int resultado = -1;
                    int.TryParse(retorno, out resultado);
                    if (resultado == -1)
                    {
                        ExibirErro(retorno);
                    }
                }
                catch (Exception mensagem)
                {
                    ExibirErro(mensagem.ToString());
                }
            }
            else
            {
                ExibirErro("Selecione uma Conta!");
            }
        }

        private void ExibirErro(string mensagem)
        {
            MessageBox.Show("Não foi possivel realizar a operação.\n" + mensagem, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
