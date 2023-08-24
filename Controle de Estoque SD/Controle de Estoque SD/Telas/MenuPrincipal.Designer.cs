namespace Controle_de_Estoque_SD
{
    partial class MenuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            tabControl = new TabControl();
            tabTelas = new TabPage();
            btnRemoverCadastro = new Button();
            btnCadastrar = new Button();
            selectTelas = new ComboBox();
            btnExcecao = new Button();
            btnBaixo = new Button();
            btnMedioBaixo = new Button();
            btnMedio = new Button();
            btnAlto = new Button();
            btnMostrar = new Button();
            btnRemover = new Button();
            btnAdicionar = new Button();
            lstTelas = new ListView();
            btnPesquisar = new Button();
            txtPesquisa = new TextBox();
            tabPeliculas = new TabPage();
            btnRemoverCadastroPelicula = new Button();
            btnCadastrarPelicula = new Button();
            selectPeliculas = new ComboBox();
            btnPeliculasFaltosasExcecao = new Button();
            btnPeliculasFaltosasBaixo = new Button();
            btnPeliculasFaltosasMB = new Button();
            btnPeliculasFaltosasMedio = new Button();
            btnPeliculasFaltosasAlto = new Button();
            estoquePeliculas = new Button();
            btnRemoverPelicula = new Button();
            btnAdicionarPelicula = new Button();
            lstPeliculas = new ListView();
            btnPesquisarPeliculas = new Button();
            txtPesquisaPeliculas = new TextBox();
            tabVidros = new TabPage();
            btnRemoverCadastroVidro = new Button();
            btnCadastrarVidro = new Button();
            selectVidros = new ComboBox();
            btnVidrosFaltososExcecao = new Button();
            btnVidrosFaltososBaixo = new Button();
            btnVidrosFaltososMB = new Button();
            button6btnVidrosFaltososMedio = new Button();
            btnVidrosFaltososAlto = new Button();
            btnMostrarVidros = new Button();
            btnRemoverVidro = new Button();
            btnAdicionarVidro = new Button();
            lstVidros = new ListView();
            btnPesquisarVidros = new Button();
            txtPesquisaVidros = new TextBox();
            tabControl.SuspendLayout();
            tabTelas.SuspendLayout();
            tabPeliculas.SuspendLayout();
            tabVidros.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabTelas);
            tabControl.Controls.Add(tabPeliculas);
            tabControl.Controls.Add(tabVidros);
            tabControl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl.Location = new Point(2, 3);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1148, 655);
            tabControl.SizeMode = TabSizeMode.Fixed;
            tabControl.TabIndex = 0;
            // 
            // tabTelas
            // 
            tabTelas.BackColor = Color.Gold;
            tabTelas.Controls.Add(btnRemoverCadastro);
            tabTelas.Controls.Add(btnCadastrar);
            tabTelas.Controls.Add(selectTelas);
            tabTelas.Controls.Add(btnExcecao);
            tabTelas.Controls.Add(btnBaixo);
            tabTelas.Controls.Add(btnMedioBaixo);
            tabTelas.Controls.Add(btnMedio);
            tabTelas.Controls.Add(btnAlto);
            tabTelas.Controls.Add(btnMostrar);
            tabTelas.Controls.Add(btnRemover);
            tabTelas.Controls.Add(btnAdicionar);
            tabTelas.Controls.Add(lstTelas);
            tabTelas.Controls.Add(btnPesquisar);
            tabTelas.Controls.Add(txtPesquisa);
            tabTelas.Location = new Point(4, 30);
            tabTelas.Name = "tabTelas";
            tabTelas.Padding = new Padding(3);
            tabTelas.Size = new Size(1140, 621);
            tabTelas.TabIndex = 0;
            tabTelas.Text = "Telas";
            // 
            // btnRemoverCadastro
            // 
            btnRemoverCadastro.BackColor = Color.Black;
            btnRemoverCadastro.FlatStyle = FlatStyle.Popup;
            btnRemoverCadastro.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnRemoverCadastro.ForeColor = Color.White;
            btnRemoverCadastro.Location = new Point(901, 440);
            btnRemoverCadastro.Name = "btnRemoverCadastro";
            btnRemoverCadastro.Size = new Size(233, 34);
            btnRemoverCadastro.TabIndex = 13;
            btnRemoverCadastro.Text = "Remover Cadastro";
            btnRemoverCadastro.UseVisualStyleBackColor = false;
            btnRemoverCadastro.Click += btnRemoverCadastro_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.Black;
            btnCadastrar.FlatStyle = FlatStyle.Popup;
            btnCadastrar.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnCadastrar.ForeColor = Color.White;
            btnCadastrar.Location = new Point(901, 400);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(233, 34);
            btnCadastrar.TabIndex = 12;
            btnCadastrar.Text = "Cadastrar Tela";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // selectTelas
            // 
            selectTelas.BackColor = Color.Black;
            selectTelas.FlatStyle = FlatStyle.Popup;
            selectTelas.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            selectTelas.ForeColor = Color.White;
            selectTelas.FormattingEnabled = true;
            selectTelas.Items.AddRange(new object[] { "Lista Grau de Imp.", "Alto", "Médio", "Médio Baixo", "Baixo", "Exceção" });
            selectTelas.Location = new Point(901, 361);
            selectTelas.Name = "selectTelas";
            selectTelas.Size = new Size(233, 33);
            selectTelas.TabIndex = 11;
            selectTelas.Text = "Lista Grau de Imp.";
            selectTelas.SelectedIndexChanged += selectLista_SelectedIndexChanged;
            selectTelas.Leave += selectLista_Leave;
            // 
            // btnExcecao
            // 
            btnExcecao.BackColor = Color.Black;
            btnExcecao.FlatStyle = FlatStyle.Popup;
            btnExcecao.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnExcecao.ForeColor = Color.White;
            btnExcecao.Location = new Point(901, 321);
            btnExcecao.Name = "btnExcecao";
            btnExcecao.Size = new Size(233, 34);
            btnExcecao.TabIndex = 10;
            btnExcecao.Text = "Peças Faltosas Exceção";
            btnExcecao.UseVisualStyleBackColor = false;
            btnExcecao.Click += btnExcecao_Click;
            // 
            // btnBaixo
            // 
            btnBaixo.BackColor = Color.Black;
            btnBaixo.FlatStyle = FlatStyle.Popup;
            btnBaixo.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnBaixo.ForeColor = Color.White;
            btnBaixo.Location = new Point(901, 281);
            btnBaixo.Name = "btnBaixo";
            btnBaixo.Size = new Size(233, 34);
            btnBaixo.TabIndex = 9;
            btnBaixo.Text = "Peças Faltosas Baixo";
            btnBaixo.UseVisualStyleBackColor = false;
            btnBaixo.Click += btnBaixo_Click;
            // 
            // btnMedioBaixo
            // 
            btnMedioBaixo.BackColor = Color.Black;
            btnMedioBaixo.FlatStyle = FlatStyle.Popup;
            btnMedioBaixo.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnMedioBaixo.ForeColor = Color.White;
            btnMedioBaixo.Location = new Point(901, 241);
            btnMedioBaixo.Name = "btnMedioBaixo";
            btnMedioBaixo.Size = new Size(233, 34);
            btnMedioBaixo.TabIndex = 8;
            btnMedioBaixo.Text = "Peças Faltosas MB";
            btnMedioBaixo.UseVisualStyleBackColor = false;
            btnMedioBaixo.Click += btnMedioBaixo_Click;
            // 
            // btnMedio
            // 
            btnMedio.BackColor = Color.Black;
            btnMedio.FlatStyle = FlatStyle.Popup;
            btnMedio.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnMedio.ForeColor = Color.White;
            btnMedio.Location = new Point(901, 201);
            btnMedio.Name = "btnMedio";
            btnMedio.Size = new Size(233, 34);
            btnMedio.TabIndex = 7;
            btnMedio.Text = "Peças Faltosas Médio";
            btnMedio.UseVisualStyleBackColor = false;
            btnMedio.Click += btnMedio_Click;
            // 
            // btnAlto
            // 
            btnAlto.BackColor = Color.Black;
            btnAlto.FlatStyle = FlatStyle.Popup;
            btnAlto.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnAlto.ForeColor = Color.White;
            btnAlto.Location = new Point(901, 161);
            btnAlto.Name = "btnAlto";
            btnAlto.Size = new Size(233, 34);
            btnAlto.TabIndex = 6;
            btnAlto.Text = "Peças Faltosas Alto";
            btnAlto.UseVisualStyleBackColor = false;
            btnAlto.Click += btnPecasFaltosas_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.BackColor = Color.Black;
            btnMostrar.FlatStyle = FlatStyle.Popup;
            btnMostrar.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnMostrar.ForeColor = Color.White;
            btnMostrar.Location = new Point(901, 121);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(233, 34);
            btnMostrar.TabIndex = 5;
            btnMostrar.Text = "Mostrar Estoque";
            btnMostrar.UseVisualStyleBackColor = false;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnRemover
            // 
            btnRemover.BackColor = Color.Black;
            btnRemover.FlatStyle = FlatStyle.Popup;
            btnRemover.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnRemover.ForeColor = Color.White;
            btnRemover.Location = new Point(901, 81);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(233, 34);
            btnRemover.TabIndex = 4;
            btnRemover.Text = "Remover Tela";
            btnRemover.UseVisualStyleBackColor = false;
            btnRemover.Click += btnRemover_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.Black;
            btnAdicionar.FlatStyle = FlatStyle.Popup;
            btnAdicionar.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdicionar.ForeColor = Color.White;
            btnAdicionar.Location = new Point(901, 41);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(233, 34);
            btnAdicionar.TabIndex = 3;
            btnAdicionar.Text = "Adicionar Tela";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // lstTelas
            // 
            lstTelas.Location = new Point(6, 41);
            lstTelas.Name = "lstTelas";
            lstTelas.Size = new Size(889, 574);
            lstTelas.TabIndex = 2;
            lstTelas.UseCompatibleStateImageBehavior = false;
            lstTelas.KeyDown += lstTelas_KeyDown;
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = Color.Black;
            btnPesquisar.FlatStyle = FlatStyle.Popup;
            btnPesquisar.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnPesquisar.ForeColor = Color.White;
            btnPesquisar.Location = new Point(789, 3);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(106, 34);
            btnPesquisar.TabIndex = 1;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(6, 6);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(777, 29);
            txtPesquisa.TabIndex = 0;
            txtPesquisa.Text = "Digite sua pesquisa";
            txtPesquisa.Click += txtPesquisa_Click;
            txtPesquisa.KeyDown += txtPesquisa_KeyDown;
            // 
            // tabPeliculas
            // 
            tabPeliculas.BackColor = Color.Gold;
            tabPeliculas.Controls.Add(btnRemoverCadastroPelicula);
            tabPeliculas.Controls.Add(btnCadastrarPelicula);
            tabPeliculas.Controls.Add(selectPeliculas);
            tabPeliculas.Controls.Add(btnPeliculasFaltosasExcecao);
            tabPeliculas.Controls.Add(btnPeliculasFaltosasBaixo);
            tabPeliculas.Controls.Add(btnPeliculasFaltosasMB);
            tabPeliculas.Controls.Add(btnPeliculasFaltosasMedio);
            tabPeliculas.Controls.Add(btnPeliculasFaltosasAlto);
            tabPeliculas.Controls.Add(estoquePeliculas);
            tabPeliculas.Controls.Add(btnRemoverPelicula);
            tabPeliculas.Controls.Add(btnAdicionarPelicula);
            tabPeliculas.Controls.Add(lstPeliculas);
            tabPeliculas.Controls.Add(btnPesquisarPeliculas);
            tabPeliculas.Controls.Add(txtPesquisaPeliculas);
            tabPeliculas.Location = new Point(4, 30);
            tabPeliculas.Name = "tabPeliculas";
            tabPeliculas.Padding = new Padding(3);
            tabPeliculas.Size = new Size(1140, 621);
            tabPeliculas.TabIndex = 1;
            tabPeliculas.Text = "Películas";
            // 
            // btnRemoverCadastroPelicula
            // 
            btnRemoverCadastroPelicula.BackColor = Color.Black;
            btnRemoverCadastroPelicula.FlatStyle = FlatStyle.Popup;
            btnRemoverCadastroPelicula.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnRemoverCadastroPelicula.ForeColor = Color.White;
            btnRemoverCadastroPelicula.Location = new Point(901, 441);
            btnRemoverCadastroPelicula.Name = "btnRemoverCadastroPelicula";
            btnRemoverCadastroPelicula.Size = new Size(233, 34);
            btnRemoverCadastroPelicula.TabIndex = 27;
            btnRemoverCadastroPelicula.Text = "Remover Cadastro";
            btnRemoverCadastroPelicula.UseVisualStyleBackColor = false;
            btnRemoverCadastroPelicula.Click += RemoverPelicula_Click;
            // 
            // btnCadastrarPelicula
            // 
            btnCadastrarPelicula.BackColor = Color.Black;
            btnCadastrarPelicula.FlatStyle = FlatStyle.Popup;
            btnCadastrarPelicula.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnCadastrarPelicula.ForeColor = Color.White;
            btnCadastrarPelicula.Location = new Point(901, 401);
            btnCadastrarPelicula.Name = "btnCadastrarPelicula";
            btnCadastrarPelicula.Size = new Size(233, 34);
            btnCadastrarPelicula.TabIndex = 26;
            btnCadastrarPelicula.Text = "Cadastrar Película";
            btnCadastrarPelicula.UseVisualStyleBackColor = false;
            btnCadastrarPelicula.Click += btnCadastrarPelicula_Click;
            // 
            // selectPeliculas
            // 
            selectPeliculas.BackColor = Color.Black;
            selectPeliculas.FlatStyle = FlatStyle.Popup;
            selectPeliculas.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            selectPeliculas.ForeColor = Color.White;
            selectPeliculas.FormattingEnabled = true;
            selectPeliculas.Items.AddRange(new object[] { "Lista Grau de Imp.", "Alto", "Médio", "Médio Baixo", "Baixo", "Exceção" });
            selectPeliculas.Location = new Point(901, 362);
            selectPeliculas.Name = "selectPeliculas";
            selectPeliculas.Size = new Size(233, 33);
            selectPeliculas.TabIndex = 25;
            selectPeliculas.Text = "Lista Grau de Imp.";
            selectPeliculas.SelectedIndexChanged += selectPeliculas_SelectedIndexChanged;
            // 
            // btnPeliculasFaltosasExcecao
            // 
            btnPeliculasFaltosasExcecao.BackColor = Color.Black;
            btnPeliculasFaltosasExcecao.FlatStyle = FlatStyle.Popup;
            btnPeliculasFaltosasExcecao.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnPeliculasFaltosasExcecao.ForeColor = Color.White;
            btnPeliculasFaltosasExcecao.Location = new Point(901, 322);
            btnPeliculasFaltosasExcecao.Name = "btnPeliculasFaltosasExcecao";
            btnPeliculasFaltosasExcecao.Size = new Size(233, 34);
            btnPeliculasFaltosasExcecao.TabIndex = 24;
            btnPeliculasFaltosasExcecao.Text = "Películas Faltosas E.";
            btnPeliculasFaltosasExcecao.UseVisualStyleBackColor = false;
            btnPeliculasFaltosasExcecao.Click += btnPeliculasFaltosasExcecao_Click;
            // 
            // btnPeliculasFaltosasBaixo
            // 
            btnPeliculasFaltosasBaixo.BackColor = Color.Black;
            btnPeliculasFaltosasBaixo.FlatStyle = FlatStyle.Popup;
            btnPeliculasFaltosasBaixo.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnPeliculasFaltosasBaixo.ForeColor = Color.White;
            btnPeliculasFaltosasBaixo.Location = new Point(901, 282);
            btnPeliculasFaltosasBaixo.Name = "btnPeliculasFaltosasBaixo";
            btnPeliculasFaltosasBaixo.Size = new Size(233, 34);
            btnPeliculasFaltosasBaixo.TabIndex = 23;
            btnPeliculasFaltosasBaixo.Text = "Películas Faltosas B.";
            btnPeliculasFaltosasBaixo.UseVisualStyleBackColor = false;
            btnPeliculasFaltosasBaixo.Click += btnPeliculasFaltosasBaixo_Click;
            // 
            // btnPeliculasFaltosasMB
            // 
            btnPeliculasFaltosasMB.BackColor = Color.Black;
            btnPeliculasFaltosasMB.FlatStyle = FlatStyle.Popup;
            btnPeliculasFaltosasMB.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnPeliculasFaltosasMB.ForeColor = Color.White;
            btnPeliculasFaltosasMB.Location = new Point(901, 242);
            btnPeliculasFaltosasMB.Name = "btnPeliculasFaltosasMB";
            btnPeliculasFaltosasMB.Size = new Size(233, 34);
            btnPeliculasFaltosasMB.TabIndex = 22;
            btnPeliculasFaltosasMB.Text = "Películas Faltosas MB.";
            btnPeliculasFaltosasMB.UseVisualStyleBackColor = false;
            btnPeliculasFaltosasMB.Click += btnPeliculasFaltosasMB_Click;
            // 
            // btnPeliculasFaltosasMedio
            // 
            btnPeliculasFaltosasMedio.BackColor = Color.Black;
            btnPeliculasFaltosasMedio.FlatStyle = FlatStyle.Popup;
            btnPeliculasFaltosasMedio.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnPeliculasFaltosasMedio.ForeColor = Color.White;
            btnPeliculasFaltosasMedio.Location = new Point(901, 202);
            btnPeliculasFaltosasMedio.Name = "btnPeliculasFaltosasMedio";
            btnPeliculasFaltosasMedio.Size = new Size(233, 34);
            btnPeliculasFaltosasMedio.TabIndex = 21;
            btnPeliculasFaltosasMedio.Text = "Películas Faltosas M.";
            btnPeliculasFaltosasMedio.UseVisualStyleBackColor = false;
            btnPeliculasFaltosasMedio.Click += btnPeliculasFaltosasMedio_Click;
            // 
            // btnPeliculasFaltosasAlto
            // 
            btnPeliculasFaltosasAlto.BackColor = Color.Black;
            btnPeliculasFaltosasAlto.FlatStyle = FlatStyle.Popup;
            btnPeliculasFaltosasAlto.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnPeliculasFaltosasAlto.ForeColor = Color.White;
            btnPeliculasFaltosasAlto.Location = new Point(901, 162);
            btnPeliculasFaltosasAlto.Name = "btnPeliculasFaltosasAlto";
            btnPeliculasFaltosasAlto.Size = new Size(233, 34);
            btnPeliculasFaltosasAlto.TabIndex = 20;
            btnPeliculasFaltosasAlto.Text = "Películas Faltosas A.";
            btnPeliculasFaltosasAlto.UseVisualStyleBackColor = false;
            btnPeliculasFaltosasAlto.Click += btnPeliculasFaltosasAlto_Click;
            // 
            // estoquePeliculas
            // 
            estoquePeliculas.BackColor = Color.Black;
            estoquePeliculas.FlatStyle = FlatStyle.Popup;
            estoquePeliculas.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            estoquePeliculas.ForeColor = Color.White;
            estoquePeliculas.Location = new Point(901, 122);
            estoquePeliculas.Name = "estoquePeliculas";
            estoquePeliculas.Size = new Size(233, 34);
            estoquePeliculas.TabIndex = 19;
            estoquePeliculas.Text = "Mostrar Estoque";
            estoquePeliculas.UseVisualStyleBackColor = false;
            estoquePeliculas.Click += estoquePeliculas_Click;
            // 
            // btnRemoverPelicula
            // 
            btnRemoverPelicula.BackColor = Color.Black;
            btnRemoverPelicula.FlatStyle = FlatStyle.Popup;
            btnRemoverPelicula.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnRemoverPelicula.ForeColor = Color.White;
            btnRemoverPelicula.Location = new Point(901, 82);
            btnRemoverPelicula.Name = "btnRemoverPelicula";
            btnRemoverPelicula.Size = new Size(233, 34);
            btnRemoverPelicula.TabIndex = 18;
            btnRemoverPelicula.Text = "Remover Película";
            btnRemoverPelicula.UseVisualStyleBackColor = false;
            btnRemoverPelicula.Click += btnRemoverPelicula_Click;
            // 
            // btnAdicionarPelicula
            // 
            btnAdicionarPelicula.BackColor = Color.Black;
            btnAdicionarPelicula.FlatStyle = FlatStyle.Popup;
            btnAdicionarPelicula.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdicionarPelicula.ForeColor = Color.White;
            btnAdicionarPelicula.Location = new Point(901, 42);
            btnAdicionarPelicula.Name = "btnAdicionarPelicula";
            btnAdicionarPelicula.Size = new Size(233, 34);
            btnAdicionarPelicula.TabIndex = 17;
            btnAdicionarPelicula.Text = "Adicionar Película";
            btnAdicionarPelicula.UseVisualStyleBackColor = false;
            btnAdicionarPelicula.Click += btnAdicionarPelicula_Click;
            // 
            // lstPeliculas
            // 
            lstPeliculas.Location = new Point(6, 42);
            lstPeliculas.Name = "lstPeliculas";
            lstPeliculas.Size = new Size(889, 574);
            lstPeliculas.TabIndex = 16;
            lstPeliculas.UseCompatibleStateImageBehavior = false;
            // 
            // btnPesquisarPeliculas
            // 
            btnPesquisarPeliculas.BackColor = Color.Black;
            btnPesquisarPeliculas.FlatStyle = FlatStyle.Popup;
            btnPesquisarPeliculas.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnPesquisarPeliculas.ForeColor = Color.White;
            btnPesquisarPeliculas.Location = new Point(789, 4);
            btnPesquisarPeliculas.Name = "btnPesquisarPeliculas";
            btnPesquisarPeliculas.Size = new Size(106, 34);
            btnPesquisarPeliculas.TabIndex = 15;
            btnPesquisarPeliculas.Text = "Pesquisar";
            btnPesquisarPeliculas.UseVisualStyleBackColor = false;
            btnPesquisarPeliculas.Click += btnPesquisarPeliculas_Click;
            // 
            // txtPesquisaPeliculas
            // 
            txtPesquisaPeliculas.Location = new Point(6, 7);
            txtPesquisaPeliculas.Name = "txtPesquisaPeliculas";
            txtPesquisaPeliculas.Size = new Size(777, 29);
            txtPesquisaPeliculas.TabIndex = 14;
            txtPesquisaPeliculas.Text = "Digite sua pesquisa";
            txtPesquisaPeliculas.Click += txtPesquisaPeliculas_Click;
            txtPesquisaPeliculas.KeyDown += txtPesquisaPeliculas_KeyDown;
            // 
            // tabVidros
            // 
            tabVidros.BackColor = Color.Gold;
            tabVidros.Controls.Add(btnRemoverCadastroVidro);
            tabVidros.Controls.Add(btnCadastrarVidro);
            tabVidros.Controls.Add(selectVidros);
            tabVidros.Controls.Add(btnVidrosFaltososExcecao);
            tabVidros.Controls.Add(btnVidrosFaltososBaixo);
            tabVidros.Controls.Add(btnVidrosFaltososMB);
            tabVidros.Controls.Add(button6btnVidrosFaltososMedio);
            tabVidros.Controls.Add(btnVidrosFaltososAlto);
            tabVidros.Controls.Add(btnMostrarVidros);
            tabVidros.Controls.Add(btnRemoverVidro);
            tabVidros.Controls.Add(btnAdicionarVidro);
            tabVidros.Controls.Add(lstVidros);
            tabVidros.Controls.Add(btnPesquisarVidros);
            tabVidros.Controls.Add(txtPesquisaVidros);
            tabVidros.Location = new Point(4, 30);
            tabVidros.Name = "tabVidros";
            tabVidros.Size = new Size(1140, 621);
            tabVidros.TabIndex = 2;
            tabVidros.Text = "Vidros";
            // 
            // btnRemoverCadastroVidro
            // 
            btnRemoverCadastroVidro.BackColor = Color.Black;
            btnRemoverCadastroVidro.FlatStyle = FlatStyle.Popup;
            btnRemoverCadastroVidro.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnRemoverCadastroVidro.ForeColor = Color.White;
            btnRemoverCadastroVidro.Location = new Point(901, 441);
            btnRemoverCadastroVidro.Name = "btnRemoverCadastroVidro";
            btnRemoverCadastroVidro.Size = new Size(233, 34);
            btnRemoverCadastroVidro.TabIndex = 27;
            btnRemoverCadastroVidro.Text = "Remover Cadastro";
            btnRemoverCadastroVidro.UseVisualStyleBackColor = false;
            btnRemoverCadastroVidro.Click += btnRemoverCadastroVidro_Click;
            // 
            // btnCadastrarVidro
            // 
            btnCadastrarVidro.BackColor = Color.Black;
            btnCadastrarVidro.FlatStyle = FlatStyle.Popup;
            btnCadastrarVidro.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnCadastrarVidro.ForeColor = Color.White;
            btnCadastrarVidro.Location = new Point(901, 401);
            btnCadastrarVidro.Name = "btnCadastrarVidro";
            btnCadastrarVidro.Size = new Size(233, 34);
            btnCadastrarVidro.TabIndex = 26;
            btnCadastrarVidro.Text = "Cadastrar Vidro";
            btnCadastrarVidro.UseVisualStyleBackColor = false;
            btnCadastrarVidro.Click += btnCadastrarVidro_Click;
            // 
            // selectVidros
            // 
            selectVidros.BackColor = Color.Black;
            selectVidros.FlatStyle = FlatStyle.Popup;
            selectVidros.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            selectVidros.ForeColor = Color.White;
            selectVidros.FormattingEnabled = true;
            selectVidros.Items.AddRange(new object[] { "Lista Grau de Imp.", "Alto", "Médio", "Médio Baixo", "Baixo", "Exceção" });
            selectVidros.Location = new Point(901, 362);
            selectVidros.Name = "selectVidros";
            selectVidros.Size = new Size(233, 33);
            selectVidros.TabIndex = 25;
            selectVidros.Text = "Lista Grau de Imp.";
            selectVidros.SelectedIndexChanged += selectVidros_SelectedIndexChanged;
            // 
            // btnVidrosFaltososExcecao
            // 
            btnVidrosFaltososExcecao.BackColor = Color.Black;
            btnVidrosFaltososExcecao.FlatStyle = FlatStyle.Popup;
            btnVidrosFaltososExcecao.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnVidrosFaltososExcecao.ForeColor = Color.White;
            btnVidrosFaltososExcecao.Location = new Point(901, 322);
            btnVidrosFaltososExcecao.Name = "btnVidrosFaltososExcecao";
            btnVidrosFaltososExcecao.Size = new Size(233, 34);
            btnVidrosFaltososExcecao.TabIndex = 24;
            btnVidrosFaltososExcecao.Text = "Vidros Faltosos Exceção";
            btnVidrosFaltososExcecao.UseVisualStyleBackColor = false;
            btnVidrosFaltososExcecao.Click += btnVidrosFaltososExcecao_Click;
            // 
            // btnVidrosFaltososBaixo
            // 
            btnVidrosFaltososBaixo.BackColor = Color.Black;
            btnVidrosFaltososBaixo.FlatStyle = FlatStyle.Popup;
            btnVidrosFaltososBaixo.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnVidrosFaltososBaixo.ForeColor = Color.White;
            btnVidrosFaltososBaixo.Location = new Point(901, 282);
            btnVidrosFaltososBaixo.Name = "btnVidrosFaltososBaixo";
            btnVidrosFaltososBaixo.Size = new Size(233, 34);
            btnVidrosFaltososBaixo.TabIndex = 23;
            btnVidrosFaltososBaixo.Text = "Vidros Faltosos Baixo";
            btnVidrosFaltososBaixo.UseVisualStyleBackColor = false;
            btnVidrosFaltososBaixo.Click += btnVidrosFaltososBaixo_Click;
            // 
            // btnVidrosFaltososMB
            // 
            btnVidrosFaltososMB.BackColor = Color.Black;
            btnVidrosFaltososMB.FlatStyle = FlatStyle.Popup;
            btnVidrosFaltososMB.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnVidrosFaltososMB.ForeColor = Color.White;
            btnVidrosFaltososMB.Location = new Point(901, 242);
            btnVidrosFaltososMB.Name = "btnVidrosFaltososMB";
            btnVidrosFaltososMB.Size = new Size(233, 34);
            btnVidrosFaltososMB.TabIndex = 22;
            btnVidrosFaltososMB.Text = "Vidros Faltosos MB";
            btnVidrosFaltososMB.UseVisualStyleBackColor = false;
            btnVidrosFaltososMB.Click += btnVidrosFaltososMB_Click;
            // 
            // button6btnVidrosFaltososMedio
            // 
            button6btnVidrosFaltososMedio.BackColor = Color.Black;
            button6btnVidrosFaltososMedio.FlatStyle = FlatStyle.Popup;
            button6btnVidrosFaltososMedio.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button6btnVidrosFaltososMedio.ForeColor = Color.White;
            button6btnVidrosFaltososMedio.Location = new Point(901, 202);
            button6btnVidrosFaltososMedio.Name = "button6btnVidrosFaltososMedio";
            button6btnVidrosFaltososMedio.Size = new Size(233, 34);
            button6btnVidrosFaltososMedio.TabIndex = 21;
            button6btnVidrosFaltososMedio.Text = "Vidros Faltosos Médio";
            button6btnVidrosFaltososMedio.UseVisualStyleBackColor = false;
            button6btnVidrosFaltososMedio.Click += button6btnVidrosFaltososMedio_Click;
            // 
            // btnVidrosFaltososAlto
            // 
            btnVidrosFaltososAlto.BackColor = Color.Black;
            btnVidrosFaltososAlto.FlatStyle = FlatStyle.Popup;
            btnVidrosFaltososAlto.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnVidrosFaltososAlto.ForeColor = Color.White;
            btnVidrosFaltososAlto.Location = new Point(901, 162);
            btnVidrosFaltososAlto.Name = "btnVidrosFaltososAlto";
            btnVidrosFaltososAlto.Size = new Size(233, 34);
            btnVidrosFaltososAlto.TabIndex = 20;
            btnVidrosFaltososAlto.Text = "Vidros Faltosos Alto";
            btnVidrosFaltososAlto.UseVisualStyleBackColor = false;
            btnVidrosFaltososAlto.Click += btnVidrosFaltososAlto_Click;
            // 
            // btnMostrarVidros
            // 
            btnMostrarVidros.BackColor = Color.Black;
            btnMostrarVidros.FlatStyle = FlatStyle.Popup;
            btnMostrarVidros.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnMostrarVidros.ForeColor = Color.White;
            btnMostrarVidros.Location = new Point(901, 122);
            btnMostrarVidros.Name = "btnMostrarVidros";
            btnMostrarVidros.Size = new Size(233, 34);
            btnMostrarVidros.TabIndex = 19;
            btnMostrarVidros.Text = "Mostrar Estoque";
            btnMostrarVidros.UseVisualStyleBackColor = false;
            btnMostrarVidros.Click += btnMostrarVidros_Click;
            // 
            // btnRemoverVidro
            // 
            btnRemoverVidro.BackColor = Color.Black;
            btnRemoverVidro.FlatStyle = FlatStyle.Popup;
            btnRemoverVidro.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnRemoverVidro.ForeColor = Color.White;
            btnRemoverVidro.Location = new Point(901, 82);
            btnRemoverVidro.Name = "btnRemoverVidro";
            btnRemoverVidro.Size = new Size(233, 34);
            btnRemoverVidro.TabIndex = 18;
            btnRemoverVidro.Text = "Remover Vidro";
            btnRemoverVidro.UseVisualStyleBackColor = false;
            btnRemoverVidro.Click += btnRemoverVidro_Click;
            // 
            // btnAdicionarVidro
            // 
            btnAdicionarVidro.BackColor = Color.Black;
            btnAdicionarVidro.FlatStyle = FlatStyle.Popup;
            btnAdicionarVidro.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdicionarVidro.ForeColor = Color.White;
            btnAdicionarVidro.Location = new Point(901, 42);
            btnAdicionarVidro.Name = "btnAdicionarVidro";
            btnAdicionarVidro.Size = new Size(233, 34);
            btnAdicionarVidro.TabIndex = 17;
            btnAdicionarVidro.Text = "Adicionar Vidro";
            btnAdicionarVidro.UseVisualStyleBackColor = false;
            btnAdicionarVidro.Click += btnAdicionarVidro_Click;
            // 
            // lstVidros
            // 
            lstVidros.Location = new Point(6, 42);
            lstVidros.Name = "lstVidros";
            lstVidros.Size = new Size(889, 574);
            lstVidros.TabIndex = 16;
            lstVidros.UseCompatibleStateImageBehavior = false;
            lstVidros.KeyDown += lstVidros_KeyDown;
            // 
            // btnPesquisarVidros
            // 
            btnPesquisarVidros.BackColor = Color.Black;
            btnPesquisarVidros.FlatStyle = FlatStyle.Popup;
            btnPesquisarVidros.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnPesquisarVidros.ForeColor = Color.White;
            btnPesquisarVidros.Location = new Point(789, 4);
            btnPesquisarVidros.Name = "btnPesquisarVidros";
            btnPesquisarVidros.Size = new Size(106, 34);
            btnPesquisarVidros.TabIndex = 15;
            btnPesquisarVidros.Text = "Pesquisar";
            btnPesquisarVidros.UseVisualStyleBackColor = false;
            btnPesquisarVidros.Click += btnPesquisarVidros_Click;
            // 
            // txtPesquisaVidros
            // 
            txtPesquisaVidros.Location = new Point(6, 7);
            txtPesquisaVidros.Name = "txtPesquisaVidros";
            txtPesquisaVidros.Size = new Size(777, 29);
            txtPesquisaVidros.TabIndex = 14;
            txtPesquisaVidros.Text = "Digite sua pesquisa";
            txtPesquisaVidros.Click += txtPesquisaVidros_Click;
            txtPesquisaVidros.KeyDown += txtPesquisaVidros_KeyDown;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            ClientSize = new Size(1154, 661);
            Controls.Add(tabControl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Principal";
            FormClosing += MenuPrincipal_FormClosing;
            tabControl.ResumeLayout(false);
            tabTelas.ResumeLayout(false);
            tabTelas.PerformLayout();
            tabPeliculas.ResumeLayout(false);
            tabPeliculas.PerformLayout();
            tabVidros.ResumeLayout(false);
            tabVidros.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabTelas;
        private TabPage tabPeliculas;
        private Button btnPesquisar;
        private TextBox txtPesquisa;
        private ListView lstTelas;
        private Button btnAdicionar;
        private Button btnRemover;
        private Button btnMostrar;
        private Button btnAlto;
        private Button btnExcecao;
        private Button btnBaixo;
        private Button btnMedioBaixo;
        private Button btnMedio;
        private ComboBox selectTelas;
        private Button btnRemoverCadastro;
        private Button btnCadastrar;
        private Button btnRemoverCadastroPelicula;
        private Button btnCadastrarPelicula;
        private ComboBox selectPeliculas;
        private Button btnPeliculasFaltosasExcecao;
        private Button btnPeliculasFaltosasBaixo;
        private Button btnPeliculasFaltosasMB;
        private Button btnPeliculasFaltosasMedio;
        private Button btnPeliculasFaltosasAlto;
        private Button estoquePeliculas;
        private Button btnRemoverPelicula;
        private Button btnAdicionarPelicula;
        private ListView lstPeliculas;
        private Button btnPesquisarPeliculas;
        private TextBox txtPesquisaPeliculas;
        private TabPage tabVidros;
        private Button btnRemoverCadastroVidro;
        private Button btnCadastrarVidro;
        private ComboBox selectVidros;
        private Button btnVidrosFaltososExcecao;
        private Button btnVidrosFaltososBaixo;
        private Button btnVidrosFaltososMB;
        private Button button6btnVidrosFaltososMedio;
        private Button btnVidrosFaltososAlto;
        private Button btnMostrarVidros;
        private Button btnRemoverVidro;
        private Button btnAdicionarVidro;
        private ListView lstVidros;
        private Button btnPesquisarVidros;
        private TextBox txtPesquisaVidros;
    }
}