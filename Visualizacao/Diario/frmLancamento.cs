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

namespace Diario
{
    public partial class frmLancamento : Form
    {
        public TipoLancamento tipoLancamento { get; set; }
        public List<ContaT> Contas { get; set; }

        public frmLancamento(TipoLancamento tipo)
        {
            InitializeComponent();
            PersistenciaContas persistenciaContas = new PersistenciaContas();
            tipoLancamento = tipo;
            Contas = persistenciaContas.ConsultarConta();
            cmbDestino.DataSource = Contas.ToArray();
            cmbOrigem.DataSource = Contas.ToArray();
        }

        private void LimparTela()
        {
            dtData.Value = DateTime.Now;
            txtLocal.Text = string.Empty;
            txtHistorico.Text = string.Empty;
            txtValor.Text = string.Empty;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                SalvarDiario();
                if (tipoLancamento == TipoLancamento.Compra)
                {

                }
                else
                {

                }
            }
            catch (LancamentoException mensagem)
            {
                MessageBox.Show("Ocorreu um erro!\n" + mensagem.ToString());
            }
        }

        private void SalvarDiario()
        {
            throw new NotImplementedException();
        }

        private void ValidarCampos()
        {
            if (txtLocal.Text == string.Empty) { throw new LancamentoException("Preencha o Local!"); }
            if (txtHistorico.Text == string.Empty) { throw new LancamentoException("Preencha o Histórico!"); }
            if (txtValor.Text == string.Empty) { throw new LancamentoException("Preencha o Valor!"); }
            if(IsInteiro(txtValor.Text)) { throw new LancamentoException("Valor Inválido!"); }
        }

        private bool IsInteiro(string text)
        {
            double resultado = -1.0;
            string valor = txtValor.Text.Remove(0,2).Replace(',', '.');
            double.TryParse(valor, out resultado);
            if (resultado != -1) { return true; }
            return false;
        }
    }
}
