using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelos;
using Configuracoes;

namespace Visualizacao
{
    public partial class frmPrincipal : Form
    {
        public Empresa empresa { get; set; }
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void menuConfigEmpresa_Click(object sender, EventArgs e)
        {
            frmEmpresa form = new frmEmpresa(empresa) { MdiParent = this };
            form.Show();
            empresa = form.empresa;
        }
    }
}
