namespace Controle_de_Estoque_SD.Telas
{
    partial class CadastrarPelicula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarPelicula));
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
            txtModelo = new TextBox();
            txtCor = new TextBox();
            txtQuantidade = new TextBox();
            txtCaixa = new TextBox();
            Cadastrar = new Button();
            SuspendLayout();
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            Titulo.Location = new Point(472, 19);
            Titulo.Margin = new Padding(4, 0, 4, 0);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(278, 46);
            Titulo.TabIndex = 32;
            Titulo.Text = "Cadastro de Peça";
            // 
            // txtMarca
            // 
            txtMarca.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            txtMarca.Location = new Point(420, 94);
            txtMarca.Margin = new Padding(4, 3, 4, 3);
            txtMarca.MaxLength = 17;
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(427, 43);
            txtMarca.TabIndex = 33;
            // 
            // labelMarca
            // 
            labelMarca.AutoSize = true;
            labelMarca.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelMarca.Location = new Point(314, 97);
            labelMarca.Margin = new Padding(4, 0, 4, 0);
            labelMarca.Name = "labelMarca";
            labelMarca.Size = new Size(90, 37);
            labelMarca.TabIndex = 34;
            labelMarca.Text = "Marca";
            // 
            // labelModelo
            // 
            labelModelo.AutoSize = true;
            labelModelo.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelModelo.Location = new Point(314, 169);
            labelModelo.Margin = new Padding(4, 0, 4, 0);
            labelModelo.Name = "labelModelo";
            labelModelo.Size = new Size(110, 37);
            labelModelo.TabIndex = 35;
            labelModelo.Text = "Modelo";
            // 
            // labelCor
            // 
            labelCor.AutoSize = true;
            labelCor.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelCor.Location = new Point(314, 243);
            labelCor.Margin = new Padding(4, 0, 4, 0);
            labelCor.Name = "labelCor";
            labelCor.Size = new Size(59, 37);
            labelCor.TabIndex = 36;
            labelCor.Text = "Cor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(25, 372);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(0, 34);
            label3.TabIndex = 37;
            // 
            // labelQuantidade
            // 
            labelQuantidade.AutoSize = true;
            labelQuantidade.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelQuantidade.Location = new Point(314, 315);
            labelQuantidade.Margin = new Padding(4, 0, 4, 0);
            labelQuantidade.Name = "labelQuantidade";
            labelQuantidade.Size = new Size(157, 37);
            labelQuantidade.TabIndex = 38;
            labelQuantidade.Text = "Quantidade";
            // 
            // selectImp
            // 
            selectImp.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            selectImp.FormattingEnabled = true;
            selectImp.Items.AddRange(new object[] { "Alto", "Médio", "Médio_Baixo", "Baixo", "Exceção" });
            selectImp.Location = new Point(462, 392);
            selectImp.Margin = new Padding(4, 3, 4, 3);
            selectImp.Name = "selectImp";
            selectImp.Size = new Size(385, 45);
            selectImp.TabIndex = 39;
            // 
            // labelImp
            // 
            labelImp.AutoSize = true;
            labelImp.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelImp.Location = new Point(314, 395);
            labelImp.Margin = new Padding(4, 0, 4, 0);
            labelImp.Name = "labelImp";
            labelImp.Size = new Size(133, 37);
            labelImp.TabIndex = 40;
            labelImp.Text = "Grau Imp.";
            // 
            // labelCaixa
            // 
            labelCaixa.AutoSize = true;
            labelCaixa.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelCaixa.Location = new Point(314, 480);
            labelCaixa.Margin = new Padding(4, 0, 4, 0);
            labelCaixa.Name = "labelCaixa";
            labelCaixa.Size = new Size(81, 37);
            labelCaixa.TabIndex = 41;
            labelCaixa.Text = "Caixa";
            // 
            // txtModelo
            // 
            txtModelo.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            txtModelo.Location = new Point(434, 166);
            txtModelo.Margin = new Padding(4, 3, 4, 3);
            txtModelo.MaxLength = 40;
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(413, 43);
            txtModelo.TabIndex = 43;
            // 
            // txtCor
            // 
            txtCor.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            txtCor.Location = new Point(384, 240);
            txtCor.Margin = new Padding(4, 3, 4, 3);
            txtCor.MaxLength = 12;
            txtCor.Name = "txtCor";
            txtCor.Size = new Size(463, 43);
            txtCor.TabIndex = 44;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            txtQuantidade.Location = new Point(488, 312);
            txtQuantidade.Margin = new Padding(4, 3, 4, 3);
            txtQuantidade.MaxLength = 2;
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(359, 43);
            txtQuantidade.TabIndex = 45;
            // 
            // txtCaixa
            // 
            txtCaixa.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            txtCaixa.Location = new Point(409, 477);
            txtCaixa.Margin = new Padding(4, 3, 4, 3);
            txtCaixa.MaxLength = 35;
            txtCaixa.Name = "txtCaixa";
            txtCaixa.Size = new Size(438, 43);
            txtCaixa.TabIndex = 46;
            // 
            // Cadastrar
            // 
            Cadastrar.BackColor = Color.Black;
            Cadastrar.FlatStyle = FlatStyle.Popup;
            Cadastrar.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Cadastrar.ForeColor = SystemColors.ControlLightLight;
            Cadastrar.Location = new Point(519, 563);
            Cadastrar.Margin = new Padding(4, 3, 4, 3);
            Cadastrar.Name = "Cadastrar";
            Cadastrar.Size = new Size(210, 53);
            Cadastrar.TabIndex = 52;
            Cadastrar.Text = "Cadastrar";
            Cadastrar.UseVisualStyleBackColor = false;
            Cadastrar.Click += Cadastrar_Click;
            // 
            // CadastrarPelicula
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            ClientSize = new Size(1154, 661);
            Controls.Add(Cadastrar);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CadastrarPelicula";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CadastrarPelicula";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Titulo;
        private TextBox txtMarca;
        private Label labelMarca;
        private Label labelModelo;
        private Label labelCor;
        private Label label3;
        private Label labelQuantidade;
        private ComboBox selectImp;
        private Label labelImp;
        private Label labelCaixa;
        private TextBox txtModelo;
        private TextBox txtCor;
        private TextBox txtQuantidade;
        private TextBox txtCaixa;
        private Button Cadastrar;
    }
}