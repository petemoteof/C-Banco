namespace Banco
{
    partial class Form
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelSaldoValor = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelNomeCliente = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxDeposito = new System.Windows.Forms.GroupBox();
            this.textBoxDeposito = new System.Windows.Forms.TextBox();
            this.buttonDepositar = new System.Windows.Forms.Button();
            this.groupBoxSacar = new System.Windows.Forms.GroupBox();
            this.buttonSacar = new System.Windows.Forms.Button();
            this.textBoxSacar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxDeposito.SuspendLayout();
            this.groupBoxSacar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.salvarToolStripMenuItem,
            this.fecharToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            this.arquivoToolStripMenuItem.Click += new System.EventHandler(this.arquivoToolStripMenuItem_Click);
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.novoToolStripMenuItem.Text = "Novo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salvarToolStripMenuItem.Text = "Salvar";
            // 
            // fecharToolStripMenuItem
            // 
            this.fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            this.fecharToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fecharToolStripMenuItem.Text = "Fechar";
            // 
            // labelSaldoValor
            // 
            this.labelSaldoValor.AutoSize = true;
            this.labelSaldoValor.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSaldoValor.Location = new System.Drawing.Point(55, 20);
            this.labelSaldoValor.Name = "labelSaldoValor";
            this.labelSaldoValor.Size = new System.Drawing.Size(45, 23);
            this.labelSaldoValor.TabIndex = 2;
            this.labelSaldoValor.Text = "0,00\r\n";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.labelSaldoValor);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 54);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Saldo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelNomeCliente);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(176, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(402, 60);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nome Cliente";
            // 
            // labelNomeCliente
            // 
            this.labelNomeCliente.AutoSize = true;
            this.labelNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeCliente.Location = new System.Drawing.Point(86, 22);
            this.labelNomeCliente.Name = "labelNomeCliente";
            this.labelNomeCliente.Size = new System.Drawing.Size(205, 20);
            this.labelNomeCliente.TabIndex = 6;
            this.labelNomeCliente.Text = "Pedro Temoteo Fonseca";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Opções :";
            // 
            // groupBoxDeposito
            // 
            this.groupBoxDeposito.Controls.Add(this.buttonDepositar);
            this.groupBoxDeposito.Controls.Add(this.textBoxDeposito);
            this.groupBoxDeposito.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDeposito.Location = new System.Drawing.Point(16, 152);
            this.groupBoxDeposito.Name = "groupBoxDeposito";
            this.groupBoxDeposito.Size = new System.Drawing.Size(229, 64);
            this.groupBoxDeposito.TabIndex = 7;
            this.groupBoxDeposito.TabStop = false;
            this.groupBoxDeposito.Text = "Deposito :";
            // 
            // textBoxDeposito
            // 
            this.textBoxDeposito.Location = new System.Drawing.Point(18, 23);
            this.textBoxDeposito.Name = "textBoxDeposito";
            this.textBoxDeposito.Size = new System.Drawing.Size(100, 23);
            this.textBoxDeposito.TabIndex = 9;
            // 
            // buttonDepositar
            // 
            this.buttonDepositar.Location = new System.Drawing.Point(137, 22);
            this.buttonDepositar.Name = "buttonDepositar";
            this.buttonDepositar.Size = new System.Drawing.Size(75, 23);
            this.buttonDepositar.TabIndex = 9;
            this.buttonDepositar.Text = "Depostiar";
            this.buttonDepositar.UseVisualStyleBackColor = true;
            this.buttonDepositar.Click += new System.EventHandler(this.buttonDepositar_Click);
            // 
            // groupBoxSacar
            // 
            this.groupBoxSacar.Controls.Add(this.buttonSacar);
            this.groupBoxSacar.Controls.Add(this.textBoxSacar);
            this.groupBoxSacar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSacar.Location = new System.Drawing.Point(277, 152);
            this.groupBoxSacar.Name = "groupBoxSacar";
            this.groupBoxSacar.Size = new System.Drawing.Size(229, 64);
            this.groupBoxSacar.TabIndex = 8;
            this.groupBoxSacar.TabStop = false;
            this.groupBoxSacar.Text = "Saque :";
            // 
            // buttonSacar
            // 
            this.buttonSacar.Location = new System.Drawing.Point(137, 22);
            this.buttonSacar.Name = "buttonSacar";
            this.buttonSacar.Size = new System.Drawing.Size(75, 23);
            this.buttonSacar.TabIndex = 9;
            this.buttonSacar.Text = "Sacar";
            this.buttonSacar.UseVisualStyleBackColor = true;
            this.buttonSacar.Click += new System.EventHandler(this.buttonSacar_Click);
            // 
            // textBoxSacar
            // 
            this.textBoxSacar.Location = new System.Drawing.Point(18, 23);
            this.textBoxSacar.Name = "textBoxSacar";
            this.textBoxSacar.Size = new System.Drawing.Size(100, 23);
            this.textBoxSacar.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "R$";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxSacar);
            this.Controls.Add(this.groupBoxDeposito);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form";
            this.Text = "Pagina Inicial";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxDeposito.ResumeLayout(false);
            this.groupBoxDeposito.PerformLayout();
            this.groupBoxSacar.ResumeLayout(false);
            this.groupBoxSacar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharToolStripMenuItem;
        private System.Windows.Forms.Label labelSaldoValor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelNomeCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxDeposito;
        private System.Windows.Forms.TextBox textBoxDeposito;
        private System.Windows.Forms.Button buttonDepositar;
        private System.Windows.Forms.GroupBox groupBoxSacar;
        private System.Windows.Forms.Button buttonSacar;
        private System.Windows.Forms.TextBox textBoxSacar;
        private System.Windows.Forms.Label label2;
    }
}

