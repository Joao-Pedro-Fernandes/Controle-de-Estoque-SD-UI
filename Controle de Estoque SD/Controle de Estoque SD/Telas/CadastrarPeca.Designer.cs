namespace Controle_de_Estoque_SD
{
    partial class CadastrarPeca
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarPeca));
            voltarbtn = new Button();
            Titulo = new Label();
            txtMarca = new TextBox();
            labelMarca = new Label();
            labelModelo = new Label();
            labelCor = new Label();
            label3 = new Label();
            labelQuantidade = new Label();
            selectImp = new ComboBox();
            labelImp = new Label();
            labelCaixa = new Label();
            labelCompatibilidade = new Label();
            txtModelo = new TextBox();
            txtCor = new TextBox();
            txtQuantidade = new TextBox();
            txtCaixa = new TextBox();
            checkBoxSim = new CheckBox();
            checkBoxNao = new CheckBox();
            txtPesquisa = new TextBox();
            lstCompatibilidade = new ListView();
            PesquisarButton = new Button();
            Cadastrar = new Button();
            labelCadastrar = new Label();
            SuspendLayout();
            // 
            // voltarbtn
            // 
            voltarbtn.BackColor = Color.Red;
            voltarbtn.FlatStyle = FlatStyle.Popup;
            voltarbtn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            voltarbtn.ForeColor = SystemColors.ButtonHighlight;
            voltarbtn.Location = new Point(4, 726);
            voltarbtn.Margin = new Padding(4, 3, 4, 3);
            voltarbtn.Name = "voltarbtn";
            voltarbtn.Size = new Size(103, 32);
            voltarbtn.TabIndex = 7;
            voltarbtn.Text = "Voltar";
            voltarbtn.UseVisualStyleBackColor = false;
            voltarbtn.Click += voltarbtn_Click;
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            Titulo.Location = new Point(452, 19);
            Titulo.Margin = new Padding(4, 0, 4, 0);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(278, 46);
            Titulo.TabIndex = 8;
            Titulo.Text = "Cadastro de Peça";
            // 
            // txtMarca
            // 
            txtMarca.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtMarca.Location = new Point(132, 86);
            txtMarca.Margin = new Padding(4, 3, 4, 3);
            txtMarca.MaxLength = 17;
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(349, 32);
            txtMarca.TabIndex = 9;
            // 
            // labelMarca
            // 
            labelMarca.AutoSize = true;
            labelMarca.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelMarca.Location = new Point(26, 89);
            labelMarca.Margin = new Padding(4, 0, 4, 0);
            labelMarca.Name = "labelMarca";
            labelMarca.Size = new Size(65, 25);
            labelMarca.TabIndex = 10;
            labelMarca.Text = "Marca";
            // 
            // labelModelo
            // 
            labelModelo.AutoSize = true;
            labelModelo.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelModelo.Location = new Point(26, 161);
            labelModelo.Margin = new Padding(4, 0, 4, 0);
            labelModelo.Name = "labelModelo";
            labelModelo.Size = new Size(77, 25);
            labelModelo.TabIndex = 11;
            labelModelo.Text = "Modelo";
            labelModelo.Click += labelModelo_Click;
            // 
            // labelCor
            // 
            labelCor.AutoSize = true;
            labelCor.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelCor.Location = new Point(26, 235);
            labelCor.Margin = new Padding(4, 0, 4, 0);
            labelCor.Name = "labelCor";
            labelCor.Size = new Size(42, 25);
            labelCor.TabIndex = 12;
            labelCor.Text = "Cor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(26, 376);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(0, 34);
            label3.TabIndex = 13;
            // 
            // labelQuantidade
            // 
            labelQuantidade.AutoSize = true;
            labelQuantidade.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelQuantidade.Location = new Point(26, 307);
            labelQuantidade.Margin = new Padding(4, 0, 4, 0);
            labelQuantidade.Name = "labelQuantidade";
            labelQuantidade.Size = new Size(111, 25);
            labelQuantidade.TabIndex = 14;
            labelQuantidade.Text = "Quantidade";
            // 
            // selectImp
            // 
            selectImp.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            selectImp.FormattingEnabled = true;
            selectImp.Items.AddRange(new object[] { "Alto", "Médio", "Médio_Baixo", "Baixo", "Exceção" });
            selectImp.Location = new Point(174, 384);
            selectImp.Margin = new Padding(4, 3, 4, 3);
            selectImp.Name = "selectImp";
            selectImp.Size = new Size(307, 33);
            selectImp.TabIndex = 15;
            // 
            // labelImp
            // 
            labelImp.AutoSize = true;
            labelImp.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelImp.Location = new Point(26, 387);
            labelImp.Margin = new Padding(4, 0, 4, 0);
            labelImp.Name = "labelImp";
            labelImp.Size = new Size(94, 25);
            labelImp.TabIndex = 16;
            labelImp.Text = "Grau Imp.";
            // 
            // labelCaixa
            // 
            labelCaixa.AutoSize = true;
            labelCaixa.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelCaixa.Location = new Point(26, 472);
            labelCaixa.Margin = new Padding(4, 0, 4, 0);
            labelCaixa.Name = "labelCaixa";
            labelCaixa.Size = new Size(58, 25);
            labelCaixa.TabIndex = 17;
            labelCaixa.Text = "Caixa";
            // 
            // labelCompatibilidade
            // 
            labelCompatibilidade.AutoSize = true;
            labelCompatibilidade.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelCompatibilidade.Location = new Point(26, 554);
            labelCompatibilidade.Margin = new Padding(4, 0, 4, 0);
            labelCompatibilidade.Name = "labelCompatibilidade";
            labelCompatibilidade.Size = new Size(151, 25);
            labelCompatibilidade.TabIndex = 18;
            labelCompatibilidade.Text = "Compatibilidade";
            // 
            // txtModelo
            // 
            txtModelo.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtModelo.Location = new Point(146, 158);
            txtModelo.Margin = new Padding(4, 3, 4, 3);
            txtModelo.MaxLength = 40;
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(335, 32);
            txtModelo.TabIndex = 19;
            // 
            // txtCor
            // 
            txtCor.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtCor.Location = new Point(96, 232);
            txtCor.Margin = new Padding(4, 3, 4, 3);
            txtCor.MaxLength = 12;
            txtCor.Name = "txtCor";
            txtCor.Size = new Size(385, 32);
            txtCor.TabIndex = 20;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtQuantidade.Location = new Point(200, 304);
            txtQuantidade.Margin = new Padding(4, 3, 4, 3);
            txtQuantidade.MaxLength = 2;
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(281, 32);
            txtQuantidade.TabIndex = 21;
            txtQuantidade.KeyPress += txtQuantidade_KeyPress_1;
            // 
            // txtCaixa
            // 
            txtCaixa.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtCaixa.Location = new Point(121, 469);
            txtCaixa.Margin = new Padding(4, 3, 4, 3);
            txtCaixa.MaxLength = 35;
            txtCaixa.Name = "txtCaixa";
            txtCaixa.Size = new Size(360, 32);
            txtCaixa.TabIndex = 22;
            // 
            // checkBoxSim
            // 
            checkBoxSim.AutoSize = true;
            checkBoxSim.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxSim.Location = new Point(275, 554);
            checkBoxSim.Margin = new Padding(4, 3, 4, 3);
            checkBoxSim.Name = "checkBoxSim";
            checkBoxSim.Size = new Size(62, 29);
            checkBoxSim.TabIndex = 23;
            checkBoxSim.Text = "Sim";
            checkBoxSim.UseVisualStyleBackColor = true;
            checkBoxSim.CheckedChanged += checkBoxSim_CheckedChanged;
            // 
            // checkBoxNao
            // 
            checkBoxNao.AutoSize = true;
            checkBoxNao.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxNao.Location = new Point(415, 554);
            checkBoxNao.Margin = new Padding(4, 3, 4, 3);
            checkBoxNao.Name = "checkBoxNao";
            checkBoxNao.Size = new Size(66, 29);
            checkBoxNao.TabIndex = 25;
            checkBoxNao.Text = "Não";
            checkBoxNao.UseVisualStyleBackColor = true;
            checkBoxNao.CheckedChanged += checkBoxNao_CheckedChanged;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtPesquisa.Location = new Point(541, 86);
            txtPesquisa.Margin = new Padding(4, 3, 4, 3);
            txtPesquisa.MaxLength = 17;
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(484, 32);
            txtPesquisa.TabIndex = 27;
            txtPesquisa.Text = "Digite o modelo de compatibilidade";
            txtPesquisa.Visible = false;
            // 
            // lstCompatibilidade
            // 
            lstCompatibilidade.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lstCompatibilidade.Location = new Point(541, 128);
            lstCompatibilidade.Margin = new Padding(4, 3, 4, 3);
            lstCompatibilidade.Name = "lstCompatibilidade";
            lstCompatibilidade.Size = new Size(590, 455);
            lstCompatibilidade.TabIndex = 28;
            lstCompatibilidade.UseCompatibleStateImageBehavior = false;
            lstCompatibilidade.Visible = false;
            // 
            // PesquisarButton
            // 
            PesquisarButton.BackColor = Color.Black;
            PesquisarButton.FlatStyle = FlatStyle.Popup;
            PesquisarButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PesquisarButton.ForeColor = SystemColors.ControlLightLight;
            PesquisarButton.Location = new Point(1033, 83);
            PesquisarButton.Margin = new Padding(4, 3, 4, 3);
            PesquisarButton.Name = "PesquisarButton";
            PesquisarButton.Size = new Size(98, 39);
            PesquisarButton.TabIndex = 29;
            PesquisarButton.Text = "Pesquisar";
            PesquisarButton.UseVisualStyleBackColor = false;
            PesquisarButton.Visible = false;
            PesquisarButton.Click += PesquisarButton_Click;
            // 
            // Cadastrar
            // 
            Cadastrar.BackColor = Color.Black;
            Cadastrar.FlatStyle = FlatStyle.Popup;
            Cadastrar.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Cadastrar.ForeColor = SystemColors.ControlLightLight;
            Cadastrar.Location = new Point(496, 589);
            Cadastrar.Margin = new Padding(4, 3, 4, 3);
            Cadastrar.Name = "Cadastrar";
            Cadastrar.Size = new Size(201, 61);
            Cadastrar.TabIndex = 30;
            Cadastrar.Text = "Cadastrar";
            Cadastrar.UseVisualStyleBackColor = false;
            Cadastrar.Click += Cadastrar_Click;
            // 
            // labelCadastrar
            // 
            labelCadastrar.AutoSize = true;
            labelCadastrar.Font = new Font("Impact", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelCadastrar.Location = new Point(705, 599);
            labelCadastrar.Margin = new Padding(4, 0, 4, 0);
            labelCadastrar.Name = "labelCadastrar";
            labelCadastrar.Size = new Size(117, 34);
            labelCadastrar.TabIndex = 31;
            labelCadastrar.Text = "Sucesso!";
            labelCadastrar.Visible = false;
            // 
            // CadastrarPeca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            ClientSize = new Size(1154, 661);
            Controls.Add(labelCadastrar);
            Controls.Add(Cadastrar);
            Controls.Add(PesquisarButton);
            Controls.Add(lstCompatibilidade);
            Controls.Add(txtPesquisa);
            Controls.Add(checkBoxNao);
            Controls.Add(checkBoxSim);
            Controls.Add(txtCaixa);
            Controls.Add(txtQuantidade);
            Controls.Add(txtCor);
            Controls.Add(txtModelo);
            Controls.Add(labelCompatibilidade);
            Controls.Add(labelCaixa);
            Controls.Add(labelImp);
            Controls.Add(selectImp);
            Controls.Add(labelQuantidade);
            Controls.Add(label3);
            Controls.Add(labelCor);
            Controls.Add(labelModelo);
            Controls.Add(labelMarca);
            Controls.Add(txtMarca);
            Controls.Add(Titulo);
            Controls.Add(voltarbtn);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "CadastrarPeca";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Controle de Estoque";
            FormClosing += CadastrarPeca_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button voltarbtn;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.Label labelModelo;
        private System.Windows.Forms.Label labelCor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelQuantidade;
        private System.Windows.Forms.ComboBox selectImp;
        private System.Windows.Forms.Label labelImp;
        private System.Windows.Forms.Label labelCaixa;
        private System.Windows.Forms.Label labelCompatibilidade;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtCor;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtCaixa;
        private System.Windows.Forms.CheckBox checkBoxSim;
        private System.Windows.Forms.CheckBox checkBoxNao;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.ListView lstCompatibilidade;
        private System.Windows.Forms.Button PesquisarButton;
        private System.Windows.Forms.Button Cadastrar;
        private Label labelCadastrar;
    }
}