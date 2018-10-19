namespace Visualizacao
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.menuConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConfigEmpresa = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConfigImpostos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConfigImpostosInss = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConfigImpostosIrpf = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConfigContas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDiario = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDiarioCompra = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDiarioVenda = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDiarioRegistro = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRelatorios = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRelatoriosBalanco = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRelatoriosEstoque = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRelatoriosPagamentos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRelatoriosIcms = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRelatoriosDre = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastrarClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastrarFornecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastrarProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.BackColor = System.Drawing.SystemColors.Control;
            this.menuPrincipal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuConfig,
            this.menuDiario,
            this.menuRelatorios,
            this.menuCadastrar});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(800, 29);
            this.menuPrincipal.TabIndex = 0;
            // 
            // menuConfig
            // 
            this.menuConfig.BackColor = System.Drawing.SystemColors.Control;
            this.menuConfig.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuConfigEmpresa,
            this.menuConfigImpostos,
            this.menuConfigContas});
            this.menuConfig.ForeColor = System.Drawing.SystemColors.ControlText;
            this.menuConfig.Name = "menuConfig";
            this.menuConfig.Size = new System.Drawing.Size(122, 25);
            this.menuConfig.Text = "Configurações";
            // 
            // menuConfigEmpresa
            // 
            this.menuConfigEmpresa.BackColor = System.Drawing.SystemColors.Control;
            this.menuConfigEmpresa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.menuConfigEmpresa.Name = "menuConfigEmpresa";
            this.menuConfigEmpresa.Size = new System.Drawing.Size(212, 26);
            this.menuConfigEmpresa.Text = "Empresa";
            // 
            // menuConfigImpostos
            // 
            this.menuConfigImpostos.BackColor = System.Drawing.SystemColors.Control;
            this.menuConfigImpostos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuConfigImpostosInss,
            this.menuConfigImpostosIrpf});
            this.menuConfigImpostos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.menuConfigImpostos.Name = "menuConfigImpostos";
            this.menuConfigImpostos.Size = new System.Drawing.Size(212, 26);
            this.menuConfigImpostos.Text = "Tabela de Impostos";
            // 
            // menuConfigImpostosInss
            // 
            this.menuConfigImpostosInss.BackColor = System.Drawing.SystemColors.Control;
            this.menuConfigImpostosInss.Name = "menuConfigImpostosInss";
            this.menuConfigImpostosInss.Size = new System.Drawing.Size(114, 26);
            this.menuConfigImpostosInss.Text = "INSS";
            // 
            // menuConfigImpostosIrpf
            // 
            this.menuConfigImpostosIrpf.Name = "menuConfigImpostosIrpf";
            this.menuConfigImpostosIrpf.Size = new System.Drawing.Size(98, 22);
            this.menuConfigImpostosIrpf.Text = "IRPF";
            // 
            // menuConfigContas
            // 
            this.menuConfigContas.BackColor = System.Drawing.SystemColors.Control;
            this.menuConfigContas.Name = "menuConfigContas";
            this.menuConfigContas.Size = new System.Drawing.Size(212, 26);
            this.menuConfigContas.Text = "Plano de Contas";
            // 
            // menuDiario
            // 
            this.menuDiario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDiarioCompra,
            this.menuDiarioVenda,
            this.menuDiarioRegistro});
            this.menuDiario.Name = "menuDiario";
            this.menuDiario.Size = new System.Drawing.Size(79, 20);
            this.menuDiario.Text = "Livro Diario";
            // 
            // menuDiarioCompra
            // 
            this.menuDiarioCompra.Name = "menuDiarioCompra";
            this.menuDiarioCompra.Size = new System.Drawing.Size(171, 22);
            this.menuDiarioCompra.Text = "Lançar Compra";
            // 
            // menuDiarioVenda
            // 
            this.menuDiarioVenda.Name = "menuDiarioVenda";
            this.menuDiarioVenda.Size = new System.Drawing.Size(171, 22);
            this.menuDiarioVenda.Text = "Lançar Venda";
            // 
            // menuDiarioRegistro
            // 
            this.menuDiarioRegistro.Name = "menuDiarioRegistro";
            this.menuDiarioRegistro.Size = new System.Drawing.Size(171, 22);
            this.menuDiarioRegistro.Text = "Consultar Registro";
            // 
            // menuRelatorios
            // 
            this.menuRelatorios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuRelatoriosBalanco,
            this.menuRelatoriosEstoque,
            this.menuRelatoriosPagamentos,
            this.menuRelatoriosIcms,
            this.menuRelatoriosDre});
            this.menuRelatorios.Name = "menuRelatorios";
            this.menuRelatorios.Size = new System.Drawing.Size(102, 20);
            this.menuRelatorios.Text = "Gerar Relatórios";
            // 
            // menuRelatoriosBalanco
            // 
            this.menuRelatoriosBalanco.Name = "menuRelatoriosBalanco";
            this.menuRelatoriosBalanco.Size = new System.Drawing.Size(188, 22);
            this.menuRelatoriosBalanco.Text = "Balanço Patrimonial";
            // 
            // menuRelatoriosEstoque
            // 
            this.menuRelatoriosEstoque.Name = "menuRelatoriosEstoque";
            this.menuRelatoriosEstoque.Size = new System.Drawing.Size(188, 22);
            this.menuRelatoriosEstoque.Text = "Controle de Estoque";
            // 
            // menuRelatoriosPagamentos
            // 
            this.menuRelatoriosPagamentos.Name = "menuRelatoriosPagamentos";
            this.menuRelatoriosPagamentos.Size = new System.Drawing.Size(188, 22);
            this.menuRelatoriosPagamentos.Text = "Folha de Pagamentos";
            // 
            // menuRelatoriosIcms
            // 
            this.menuRelatoriosIcms.Name = "menuRelatoriosIcms";
            this.menuRelatoriosIcms.Size = new System.Drawing.Size(188, 22);
            this.menuRelatoriosIcms.Text = "ICMS";
            // 
            // menuRelatoriosDre
            // 
            this.menuRelatoriosDre.Name = "menuRelatoriosDre";
            this.menuRelatoriosDre.Size = new System.Drawing.Size(188, 22);
            this.menuRelatoriosDre.Text = "DRE";
            // 
            // menuCadastrar
            // 
            this.menuCadastrar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastrarClientes,
            this.menuCadastrarFornecedores,
            this.menuCadastrarProdutos});
            this.menuCadastrar.Name = "menuCadastrar";
            this.menuCadastrar.Size = new System.Drawing.Size(69, 20);
            this.menuCadastrar.Text = "Cadastrar";
            // 
            // menuCadastrarClientes
            // 
            this.menuCadastrarClientes.Name = "menuCadastrarClientes";
            this.menuCadastrarClientes.Size = new System.Drawing.Size(145, 22);
            this.menuCadastrarClientes.Text = "Clientes";
            // 
            // menuCadastrarFornecedores
            // 
            this.menuCadastrarFornecedores.Name = "menuCadastrarFornecedores";
            this.menuCadastrarFornecedores.Size = new System.Drawing.Size(145, 22);
            this.menuCadastrarFornecedores.Text = "Fornecedores";
            // 
            // menuCadastrarProdutos
            // 
            this.menuCadastrarProdutos.Name = "menuCadastrarProdutos";
            this.menuCadastrarProdutos.Size = new System.Drawing.Size(145, 22);
            this.menuCadastrarProdutos.Text = "Produtos";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuPrincipal;
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem menuConfig;
        private System.Windows.Forms.ToolStripMenuItem menuConfigEmpresa;
        private System.Windows.Forms.ToolStripMenuItem menuConfigImpostos;
        private System.Windows.Forms.ToolStripMenuItem menuConfigImpostosInss;
        private System.Windows.Forms.ToolStripMenuItem menuConfigImpostosIrpf;
        private System.Windows.Forms.ToolStripMenuItem menuConfigContas;
        private System.Windows.Forms.ToolStripMenuItem menuDiario;
        private System.Windows.Forms.ToolStripMenuItem menuDiarioCompra;
        private System.Windows.Forms.ToolStripMenuItem menuDiarioVenda;
        private System.Windows.Forms.ToolStripMenuItem menuDiarioRegistro;
        private System.Windows.Forms.ToolStripMenuItem menuRelatorios;
        private System.Windows.Forms.ToolStripMenuItem menuRelatoriosBalanco;
        private System.Windows.Forms.ToolStripMenuItem menuRelatoriosEstoque;
        private System.Windows.Forms.ToolStripMenuItem menuRelatoriosPagamentos;
        private System.Windows.Forms.ToolStripMenuItem menuRelatoriosIcms;
        private System.Windows.Forms.ToolStripMenuItem menuRelatoriosDre;
        private System.Windows.Forms.ToolStripMenuItem menuCadastrar;
        private System.Windows.Forms.ToolStripMenuItem menuCadastrarClientes;
        private System.Windows.Forms.ToolStripMenuItem menuCadastrarFornecedores;
        private System.Windows.Forms.ToolStripMenuItem menuCadastrarProdutos;
    }
}

