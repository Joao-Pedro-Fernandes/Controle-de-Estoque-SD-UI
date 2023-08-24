namespace Controle_de_Estoque_SD
{
    partial class CadastrarVidro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarVidro));
            Cadastrar = new Button();
            PesquisarButton = new Button();
            txtCaixa = new TextBox();
            txtQuantidade = new TextBox();
            txtCor = new TextBox();
            txtModelo = new TextBox();
            labelCaixa = new Label();
            labelImp = new Label();
            selectImp = new ComboBox();
            labelQuantidade = new Label();
            label3 = new Label();
            labelCor = new Label();
            labelModelo = new Label();
            labelMarca = new Label();
            txtMarca = new TextBox();
            Titulo = new Label();
            SuspendLayout();
            // 
            // Cadastrar
            // 
            Cadastrar.BackColor = Color.Black;
            Cadastrar.FlatStyle = FlatStyle.Popup;
            Cadastrar.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Cadastrar.ForeColor = SystemColors.ControlLightLight;
            Cadastrar.Location = new Point(493, 567);
            Cadastrar.Margin = new Padding(4, 3, 4, 3);
            Cadastrar.Name = "Cadastrar";
            Cadastrar.Size = new Size(201, 61);
            Cadastrar.TabIndex = 52;
            Cadastrar.Text = "Cadastrar";
            Cadastrar.UseVisualStyleBackColor = false;
            Cadastrar.Click += Cadastrar_Click;
            // 
            // PesquisarButton
            // 
            PesquisarButton.BackColor = Color.Black;
            PesquisarButton.FlatStyle = FlatStyle.Popup;
            PesquisarButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PesquisarButton.ForeColor = SystemColors.ControlLightLight;
            PesquisarButton.Location = new Point(1032, 79);
            PesquisarButton.Margin = new Padding(4, 3, 4, 3);
            PesquisarButton.Name = "PesquisarButton";
            PesquisarButton.Size = new Size(98, 39);
            PesquisarButton.TabIndex = 51;
            PesquisarButton.Text = "Pesquisar";
            PesquisarButton.UseVisualStyleBackColor = false;
            PesquisarButton.Visible = false;
            // 
            // txtCaixa
            // 
            txtCaixa.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtCaixa.Location = new Point(418, 481);
            txtCaixa.Margin = new Padding(4, 3, 4, 3);
            txtCaixa.MaxLength = 35;
            txtCaixa.Name = "txtCaixa";
            txtCaixa.Size = new Size(382, 32);
            txtCaixa.TabIndex = 46;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtQuantidade.Location = new Point(464, 316);
            txtQuantidade.Margin = new Padding(4, 3, 4, 3);
            txtQuantidade.MaxLength = 2;
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(336, 32);
            txtQuantidade.TabIndex = 45;
            // 
            // txtCor
            // 
            txtCor.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtCor.Location = new Point(395, 244);
            txtCor.Margin = new Padding(4, 3, 4, 3);
            txtCor.MaxLength = 12;
            txtCor.Name = "txtCor";
            txtCor.Size = new Size(405, 32);
            txtCor.TabIndex = 44;
            // 
            // txtModelo
            // 
            txtModelo.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtModelo.Location = new Point(430, 170);
            txtModelo.Margin = new Padding(4, 3, 4, 3);
            txtModelo.MaxLength = 40;
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(370, 32);
            txtModelo.TabIndex = 43;
            // 
            // labelCaixa
            // 
            labelCaixa.AutoSize = true;
            labelCaixa.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelCaixa.Location = new Point(345, 484);
            labelCaixa.Margin = new Padding(4, 0, 4, 0);
            labelCaixa.Name = "labelCaixa";
            labelCaixa.Size = new Size(58, 25);
            labelCaixa.TabIndex = 41;
            labelCaixa.Text = "Caixa";
            // 
            // labelImp
            // 
            labelImp.AutoSize = true;
            labelImp.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelImp.Location = new Point(345, 399);
            labelImp.Margin = new Padding(4, 0, 4, 0);
            labelImp.Name = "labelImp";
            labelImp.Size = new Size(94, 25);
            labelImp.TabIndex = 40;
            labelImp.Text = "Grau Imp.";
            // 
            // selectImp
            // 
            selectImp.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            selectImp.FormattingEnabled = true;
            selectImp.Items.AddRange(new object[] { "Alto", "Médio", "Médio_Baixo", "Baixo", "Exceção" });
            selectImp.Location = new Point(451, 396);
            selectImp.Margin = new Padding(4, 3, 4, 3);
            selectImp.Name = "selectImp";
            selectImp.Size = new Size(349, 33);
            selectImp.TabIndex = 39;
            // 
            // labelQuantidade
            // 
            labelQuantidade.AutoSize = true;
            labelQuantidade.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelQuantidade.Location = new Point(345, 319);
            labelQuantidade.Margin = new Padding(4, 0, 4, 0);
            labelQuantidade.Name = "labelQuantidade";
            labelQuantidade.Size = new Size(111, 25);
            labelQuantidade.TabIndex = 38;
            labelQuantidade.Text = "Quantidade";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(345, 388);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(0, 34);
            label3.TabIndex = 37;
            // 
            // labelCor
            // 
            labelCor.AutoSize = true;
            labelCor.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelCor.Location = new Point(345, 247);
            labelCor.Margin = new Padding(4, 0, 4, 0);
            labelCor.Name = "labelCor";
            labelCor.Size = new Size(42, 25);
            labelCor.TabIndex = 36;
            labelCor.Text = "Cor";
            // 
            // labelModelo
            // 
            labelModelo.AutoSize = true;
            labelModelo.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelModelo.Location = new Point(345, 173);
            labelModelo.Margin = new Padding(4, 0, 4, 0);
            labelModelo.Name = "labelModelo";
            labelModelo.Size = new Size(77, 25);
            labelModelo.TabIndex = 35;
            labelModelo.Text = "Modelo";
            // 
            // labelMarca
            // 
            labelMarca.AutoSize = true;
            labelMarca.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelMarca.Location = new Point(345, 101);
            labelMarca.Margin = new Padding(4, 0, 4, 0);
            labelMarca.Name = "labelMarca";
            labelMarca.Size = new Size(65, 25);
            labelMarca.TabIndex = 34;
            labelMarca.Text = "Marca";
            // 
            // txtMarca
            // 
            txtMarca.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtMarca.Location = new Point(418, 98);
            txtMarca.Margin = new Padding(4, 3, 4, 3);
            txtMarca.MaxLength = 17;
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(382, 32);
            txtMarca.TabIndex = 33;
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            Titulo.Location = new Point(451, 15);
            Titulo.Margin = new Padding(4, 0, 4, 0);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(290, 46);
            Titulo.TabIndex = 32;
            Titulo.Text = "Cadastro de Vidro";
            // 
            // CadastrarVidro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            ClientSize = new Size(1154, 661);
            Controls.Add(Cadastrar);
            Controls.Add(PesquisarButton);
            Controls.Add(txtCaixa);
            Controls.Add(txtQuantidade);
            Controls.Add(txtCor);
            Controls.Add(txtModelo);
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
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CadastrarVidro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Controle de Estoque";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Cadastrar;
        private Button PesquisarButton;
        private TextBox txtCaixa;
        private TextBox txtQuantidade;
        private TextBox txtCor;
        private TextBox txtModelo;
        private Label labelCaixa;
        private Label labelImp;
        private ComboBox selectImp;
        private Label labelQuantidade;
        private Label label3;
        private Label labelCor;
        private Label labelModelo;
        private Label labelMarca;
        private TextBox txtMarca;
        private Label Titulo;
    }
}