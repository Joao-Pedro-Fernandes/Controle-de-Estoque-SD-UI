using System.Drawing;
using System.Text;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using Controle_de_Estoque_SD.Telas;

namespace Controle_de_Estoque_SD
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();

            lstTelas.KeyDown += lstTelas_KeyDown;

            lstTelas.View = View.Details;
            lstTelas.LabelEdit = true;
            lstTelas.AllowColumnReorder = true;
            lstTelas.FullRowSelect = true;
            lstTelas.GridLines = true;

            lstTelas.Columns.Add("Id", 50, HorizontalAlignment.Left);
            lstTelas.Columns.Add("Marca", 100, HorizontalAlignment.Left);
            lstTelas.Columns.Add("Modelo", 260, HorizontalAlignment.Left);
            lstTelas.Columns.Add("Cor", 100, HorizontalAlignment.Left);
            lstTelas.Columns.Add("Qtd", 50, HorizontalAlignment.Left);
            lstTelas.Columns.Add("Imp.", 50, HorizontalAlignment.Left);
            lstTelas.Columns.Add("Caixa", 270, HorizontalAlignment.Left);



            lstPeliculas.View = View.Details;
            lstPeliculas.LabelEdit = true;
            lstPeliculas.AllowColumnReorder = true;
            lstPeliculas.FullRowSelect = true;
            lstPeliculas.GridLines = true;

            lstPeliculas.Columns.Add("Id", 50, HorizontalAlignment.Left);
            lstPeliculas.Columns.Add("Marca", 100, HorizontalAlignment.Left);
            lstPeliculas.Columns.Add("Modelo", 260, HorizontalAlignment.Left);
            lstPeliculas.Columns.Add("Cor", 100, HorizontalAlignment.Left);
            lstPeliculas.Columns.Add("Qtd", 50, HorizontalAlignment.Left);
            lstPeliculas.Columns.Add("Imp.", 50, HorizontalAlignment.Left);
            lstPeliculas.Columns.Add("Caixa", 270, HorizontalAlignment.Left);

            lstPeliculas.KeyDown += lstTelas_KeyDown;



            lstVidros.View = View.Details;
            lstVidros.LabelEdit = true;
            lstVidros.AllowColumnReorder = true;
            lstVidros.FullRowSelect = true;
            lstVidros.GridLines = true;

            lstVidros.Columns.Add("Id", 50, HorizontalAlignment.Left);
            lstVidros.Columns.Add("Marca", 100, HorizontalAlignment.Left);
            lstVidros.Columns.Add("Modelo", 260, HorizontalAlignment.Left);
            lstVidros.Columns.Add("Cor", 100, HorizontalAlignment.Left);
            lstVidros.Columns.Add("Qtd", 50, HorizontalAlignment.Left);
            lstVidros.Columns.Add("Imp.", 50, HorizontalAlignment.Left);
            lstVidros.Columns.Add("Caixa", 270, HorizontalAlignment.Left);

            lstVidros.KeyDown += lstVidros_KeyDown;

        }

        private void MenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Pesquisar(ListView lst, string modelo, string item)
        {
            lst.Items.Clear();
            try
            {
                List<Pecas> ListaPecas = new List<Pecas>();
                string comando = $"SELECT * FROM {item} WHERE UPPER(modelo) LIKE UPPER('%{modelo}%') ORDER BY marca, modelo";
                MySqlConnection conn = new MySqlConnection();
                Conexao aux = new Conexao();
                conn = aux.do_connection();
                conn.Open();
                MySqlCommand command = new MySqlCommand(comando, conn);
                MySqlDataReader myReader = command.ExecuteReader();
                while (myReader.Read())
                {
                    Pecas P = new Pecas()
                    {
                        Id = myReader.GetInt32(0),
                        Marca = myReader.GetString(1),
                        Modelo = myReader.GetString(2),
                        Cor = myReader.GetString(3),
                        Quantidade = myReader.GetInt32(4),
                        Grau_importancia = myReader.GetString(5),
                        Caixa = myReader.GetString(6),
                    };

                    string[] row = { P.Id.ToString(), P.Marca, P.Modelo, P.Cor, P.Quantidade.ToString(), P.Grau_importancia, P.Caixa };
                    var listViewItem = new ListViewItem(row);
                    lst.Items.Add(listViewItem);

                }
                conn.Close();
            }
            catch
            { }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string modelo = txtPesquisa.Text;
            Pesquisar(lstTelas, modelo, "pecas");
        }

        private void btnPesquisarPeliculas_Click(object sender, EventArgs e)
        {
            string modelo = txtPesquisaPeliculas.Text;
            Pesquisar(lstPeliculas, modelo, "peliculas");
        }

        private void Adicionar(ListView lst, string objeto)
        {
            string idSelecionado = "";
            foreach (ListViewItem item in lst.SelectedItems)
            {
                idSelecionado += item.SubItems[0].Text + ", ";
                int quantidade = int.Parse(item.SubItems[4].Text) + 1;
                item.SubItems[4].Text = quantidade.ToString();
            }
            idSelecionado = idSelecionado.TrimEnd(',', ' ');

            try
            {
                string comando = $"UPDATE {objeto} SET quantidade = quantidade + 1 WHERE id = {idSelecionado}";
                MySqlConnection conn = new MySqlConnection();
                Conexao aux = new Conexao();
                conn = aux.do_connection();
                conn.Open();
                MySqlCommand command = new MySqlCommand(comando, conn);
                command.ExecuteNonQuery();
                conn.Close();

            }
            catch
            { }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Adicionar(lstTelas, "pecas");
        }

        private void btnAdicionarPelicula_Click(object sender, EventArgs e)
        {
            Adicionar(lstPeliculas, "peliculas");
        }

        private void Remover(ListView lst, string objeto)
        {
            string idSelecionado = "";
            foreach (ListViewItem item in lst.SelectedItems)
            {
                idSelecionado += item.SubItems[0].Text + ", ";
                int quantidade = int.Parse(item.SubItems[4].Text) - 1;
                item.SubItems[4].Text = quantidade.ToString();
            }
            idSelecionado = idSelecionado.TrimEnd(',', ' ');

            try
            {
                string comando = $"UPDATE {objeto} SET quantidade = quantidade - 1 WHERE id = {idSelecionado}";
                MySqlConnection conn = new MySqlConnection();
                Conexao aux = new Conexao();
                conn = aux.do_connection();
                conn.Open();
                MySqlCommand command = new MySqlCommand(comando, conn);
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch
            { }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            Remover(lstTelas, "pecas");
        }

        private void btnRemoverPelicula_Click(object sender, EventArgs e)
        {
            Remover(lstPeliculas, "peliculas");
        }

        private void Mostrar(ListView lst, string modelo, string objeto)
        {
            lst.Items.Clear();
            try
            {
                List<Pecas> ListaPecas = new List<Pecas>();
                string comando = $"SELECT * FROM {objeto} ORDER BY marca, modelo";
                MySqlConnection conn = new MySqlConnection();
                Conexao aux = new Conexao();
                conn = aux.do_connection();
                conn.Open();
                MySqlCommand command = new MySqlCommand(comando, conn);
                MySqlDataReader myReader = command.ExecuteReader();
                while (myReader.Read())
                {
                    Pecas P = new Pecas()
                    {
                        Id = myReader.GetInt32(0),
                        Marca = myReader.GetString(1),
                        Modelo = myReader.GetString(2),
                        Cor = myReader.GetString(3),
                        Quantidade = myReader.GetInt32(4),
                        Grau_importancia = myReader.GetString(5),
                        Caixa = myReader.GetString(6),
                    };

                    string[] row = { P.Id.ToString(), P.Marca, P.Modelo, P.Cor, P.Quantidade.ToString(), P.Grau_importancia, P.Caixa };
                    var listViewItem = new ListViewItem(row);
                    lst.Items.Add(listViewItem);

                }
                conn.Close();
            }
            catch
            { }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Mostrar(lstTelas, txtPesquisa.Text, "pecas");
        }

        private void estoquePeliculas_Click(object sender, EventArgs e)
        {
            Mostrar(lstPeliculas, txtPesquisaPeliculas.Text, "peliculas");
        }

        private List<Pecas> obterLista(string objeto)
        {
            List<Pecas> ListaPecas = new List<Pecas>();
            string comando = $"SELECT * FROM {objeto};";
            MySqlConnection conn = new MySqlConnection();
            Conexao aux = new Conexao();
            conn = aux.do_connection();
            conn.Open();
            MySqlCommand command = new MySqlCommand(comando, conn);
            MySqlDataReader myReader = command.ExecuteReader();
            while (myReader.Read())
            {
                Pecas P = new Pecas()
                {
                    Id = myReader.GetInt32(0),
                    Marca = myReader.GetString(1),
                    Modelo = myReader.GetString(2),
                    Cor = myReader.GetString(3),
                    Quantidade = myReader.GetInt32(4),
                    Grau_importancia = myReader.GetString(5),
                    Caixa = myReader.GetString(6),
                    Compatibilidade = myReader.GetString(7)
                };
                ListaPecas.Add(P);
            }
            conn.Close();
            return ListaPecas;
        }

        private void PecasFaltosas(ListView lst, string objeto, string grau_importancia)
        {
            lst.Items.Clear();
            List<Pecas> ListaPecas = new List<Pecas>();
            ListaPecas = obterLista(objeto);
            int quantidade;
            if (objeto == "vidros" && grau_importancia == "A")
                quantidade = 2;
            else
                quantidade = 0;


            try
            {
                foreach (Pecas P in ListaPecas)
                {
                    if (P.Quantidade <= quantidade && P.Grau_importancia == grau_importancia)
                    {
                        if (P.Compatibilidade == "VAZIO")
                        {
                            string[] row = { P.Id.ToString(), P.Marca, P.Modelo, P.Cor, P.Quantidade.ToString() };
                            var listViewItem = new ListViewItem(row);
                            lst.Items.Add(listViewItem);
                        }
                        else
                        {
                            foreach (Pecas aux in ListaPecas)
                            {
                                if (int.Parse(P.Compatibilidade) == aux.Id && aux.Quantidade == 0)
                                {
                                    string[] row = { P.Id.ToString(), P.Marca, P.Modelo, P.Cor, P.Quantidade.ToString() };
                                    var listViewItem = new ListViewItem(row);
                                    lst.Items.Add(listViewItem);
                                }
                            }
                        }
                    }
                }
            }
            catch
            {
            }

        }

        private void btnPecasFaltosas_Click(object sender, EventArgs e)
        {
            PecasFaltosas(lstTelas, "pecas", "A");
        }

        private void btnMedio_Click(object sender, EventArgs e)
        {
            PecasFaltosas(lstTelas, "pecas", "M");
        }

        private void btnMedioBaixo_Click(object sender, EventArgs e)
        {
            PecasFaltosas(lstTelas, "pecas", "MB");
        }

        private void btnBaixo_Click(object sender, EventArgs e)
        {
            PecasFaltosas(lstTelas, "pecas", "B");
        }

        private void btnExcecao_Click(object sender, EventArgs e)
        {
            PecasFaltosas(lstTelas, "pecas", "E");
        }

        private void lstTelas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C)
            {
                StringBuilder selectedItemsText = new StringBuilder();
                foreach (ListViewItem item in lstTelas.SelectedItems)
                {
                    for (int i = 0; i < item.SubItems.Count; i++)
                    {
                        selectedItemsText.Append(item.SubItems[i].Text);
                        if (i < item.SubItems.Count - 1)
                        {
                            selectedItemsText.Append(" ");
                        }
                    }
                    selectedItemsText.AppendLine();
                }
                Clipboard.SetText(selectedItemsText.ToString());
            }
        }

        private void lstPeliculas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C)
            {
                StringBuilder selectedItemsText = new StringBuilder();
                foreach (ListViewItem item in lstTelas.SelectedItems)
                {
                    for (int i = 0; i < item.SubItems.Count; i++)
                    {
                        selectedItemsText.Append(item.SubItems[i].Text);
                        if (i < item.SubItems.Count - 1)
                        {
                            selectedItemsText.Append(" ");
                        }
                    }
                    selectedItemsText.AppendLine();
                }
                Clipboard.SetText(selectedItemsText.ToString());
            }
        }

        private void SelectLista(ListView lst, string objeto, ComboBox selectLista)
        {
            string grau_imp;
            if (selectLista.Text == "Alto")
                grau_imp = "A";
            else if (selectLista.Text == "Médio")
                grau_imp = "M";
            else if (selectLista.Text == "Médio Baixo")
                grau_imp = "MB";
            else if (selectLista.Text == "Baixo")
                grau_imp = "B";
            else
                grau_imp = "E";

            lst.Items.Clear();
            Conexao aux = new Conexao();
            MySqlConnection conn = aux.do_connection();
            conn.Open();
            MySqlCommand comando = new MySqlCommand($"SELECT * FROM {objeto} WHERE grau_importancia = '{grau_imp}' ORDER BY marca, modelo", conn);
            MySqlDataReader myReader = comando.ExecuteReader();
            while (myReader.Read())
            {
                Pecas P = new Pecas()
                {
                    Id = myReader.GetInt32(0),
                    Marca = myReader.GetString(1),
                    Modelo = myReader.GetString(2),
                    Cor = myReader.GetString(3),
                    Quantidade = myReader.GetInt32(4),
                    Grau_importancia = myReader.GetString(5),
                    Caixa = myReader.GetString(6),
                    Compatibilidade = myReader.GetString(7)
                };
                string[] row = { P.Id.ToString(), P.Marca, P.Modelo, P.Cor, P.Quantidade.ToString(), P.Grau_importancia, P.Caixa };
                var listViewItem = new ListViewItem(row);
                lst.Items.Add(listViewItem);
            }
            conn.Close();
        }

        private void selectLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectLista(lstTelas, "pecas", selectTelas);
        }

        private void selectLista_Leave(object sender, EventArgs e)
        {
            selectTelas.SelectedIndex = 0;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var menuCadastrar = new CadastrarPeca();
            menuCadastrar.Show();
        }

        private void RemoverCadastro(ListView lst, string objeto)
        {
            string idSelecionado = "";
            foreach (ListViewItem item in lst.SelectedItems)
            {
                idSelecionado += item.SubItems[0].Text + ", ";
                item.Remove();
            }
            idSelecionado = idSelecionado.TrimEnd(',', ' ');

            try
            {
                string comando = $"DELETE FROM {objeto} WHERE id = {idSelecionado}";
                Conexao aux = new Conexao();
                MySqlConnection conn = aux.do_connection();
                conn.Open();
                MySqlCommand command = new MySqlCommand(comando, conn);
                command.ExecuteNonQuery();
                conn.Close();

            }
            catch
            { }
        }

        private void btnRemoverCadastro_Click(object sender, EventArgs e)
        {
            RemoverCadastro(lstTelas, "pecas");
        }

        private void RemoverPelicula_Click(object sender, EventArgs e)
        {
            RemoverCadastro(lstPeliculas, "peliculas");
        }

        private void btnCadastrarPelicula_Click(object sender, EventArgs e)
        {
            var menuCadastrar = new CadastrarPelicula();
            menuCadastrar.Show();
        }

        private void txtPesquisa_Click(object sender, EventArgs e)
        {
            txtPesquisa.SelectAll();
        }

        private void txtPesquisaPeliculas_Click(object sender, EventArgs e)
        {
            txtPesquisaPeliculas.SelectAll();
        }

        private void btnPeliculasFaltosasAlto_Click(object sender, EventArgs e)
        {
            PecasFaltosas(lstPeliculas, "peliculas", "A");
        }

        private void btnPeliculasFaltosasMedio_Click(object sender, EventArgs e)
        {
            PecasFaltosas(lstPeliculas, "peliculas", "M");
        }

        private void btnPeliculasFaltosasMB_Click(object sender, EventArgs e)
        {
            PecasFaltosas(lstPeliculas, "peliculas", "MB");
        }

        private void btnPeliculasFaltosasBaixo_Click(object sender, EventArgs e)
        {
            PecasFaltosas(lstPeliculas, "peliculas", "B");
        }

        private void btnPeliculasFaltosasExcecao_Click(object sender, EventArgs e)
        {
            PecasFaltosas(lstPeliculas, "peliculas", "E");
        }

        private void selectPeliculas_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectLista(lstPeliculas, "peliculas", selectPeliculas);
        }

        private void btnPesquisarVidros_Click(object sender, EventArgs e)
        {
            Pesquisar(lstVidros, txtPesquisaVidros.Text, "vidros");
        }

        private void lstVidros_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C)
            {
                StringBuilder selectedItemsText = new StringBuilder();
                foreach (ListViewItem item in lstVidros.SelectedItems)
                {
                    for (int i = 0; i < item.SubItems.Count; i++)
                    {
                        selectedItemsText.Append(item.SubItems[i].Text);
                        if (i < item.SubItems.Count - 1)
                        {
                            selectedItemsText.Append(" ");
                        }
                    }
                    selectedItemsText.AppendLine();
                }
                Clipboard.SetText(selectedItemsText.ToString());
            }
        }

        private void txtPesquisaVidros_Click(object sender, EventArgs e)
        {
            txtPesquisaVidros.SelectAll();
        }

        private void txtPesquisaVidros_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Pesquisar(lstVidros, txtPesquisaVidros.Text, "vidros");
            }
        }

        private void txtPesquisaPeliculas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Pesquisar(lstPeliculas, txtPesquisaPeliculas.Text, "peliculas");
            }
        }

        private void txtPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Pesquisar(lstTelas, txtPesquisa.Text, "pecas");
            }
        }

        private void btnAdicionarVidro_Click(object sender, EventArgs e)
        {
            Adicionar(lstVidros, "vidros");
        }

        private void btnRemoverVidro_Click(object sender, EventArgs e)
        {
            Remover(lstVidros, "vidros");
        }

        private void btnMostrarVidros_Click(object sender, EventArgs e)
        {
            Mostrar(lstVidros, txtPesquisaVidros.Text, "vidros");
        }

        private void btnVidrosFaltososAlto_Click(object sender, EventArgs e)
        {
            PecasFaltosas(lstVidros, "vidros", "A");
        }

        private void button6btnVidrosFaltososMedio_Click(object sender, EventArgs e)
        {
            PecasFaltosas(lstVidros, "vidros", "M");
        }

        private void btnVidrosFaltososMB_Click(object sender, EventArgs e)
        {
            PecasFaltosas(lstVidros, "vidros", "MB");
        }

        private void btnVidrosFaltososBaixo_Click(object sender, EventArgs e)
        {
            PecasFaltosas(lstVidros, "vidros", "B");
        }

        private void btnVidrosFaltososExcecao_Click(object sender, EventArgs e)
        {
            PecasFaltosas(lstVidros, "vidros", "E");
        }

        private void selectVidros_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectLista(lstVidros, "vidros", selectVidros);
        }

        private void btnCadastrarVidro_Click(object sender, EventArgs e)
        {
            var CadastrarVidro = new CadastrarVidro();
            CadastrarVidro.Show();
        }

        private void btnRemoverCadastroVidro_Click(object sender, EventArgs e)
        {
            RemoverCadastro(lstVidros, "vidros");
        }
    }
}