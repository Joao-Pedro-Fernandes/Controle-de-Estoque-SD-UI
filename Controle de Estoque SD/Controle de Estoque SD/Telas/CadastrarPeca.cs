using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_de_Estoque_SD
{
    public partial class CadastrarPeca : Form
    {
        public CadastrarPeca()
        {
            InitializeComponent();

            lstCompatibilidade.View = View.Details;
            lstCompatibilidade.LabelEdit = true;
            lstCompatibilidade.AllowColumnReorder = true;
            lstCompatibilidade.FullRowSelect = true;
            lstCompatibilidade.GridLines = true;

            lstCompatibilidade.Columns.Add("Id", 40, HorizontalAlignment.Left);
            lstCompatibilidade.Columns.Add("Marca", 105, HorizontalAlignment.Left);
            lstCompatibilidade.Columns.Add("Modelo", 260, HorizontalAlignment.Left);
            lstCompatibilidade.Columns.Add("Cor", 125, HorizontalAlignment.Left);
        }

        private void voltarbtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void checkBoxSim_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxNao.Checked = false;
            PesquisarButton.Visible = true;
            txtPesquisa.Visible = true;
            lstCompatibilidade.Visible = true;
        }

        private void checkBoxNao_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxSim.Checked = false;
            PesquisarButton.Visible = false;
            txtPesquisa.Visible = false;
            lstCompatibilidade.Visible = false;
        }

        private void PesquisarButton_Click(object sender, EventArgs e)
        {
            lstCompatibilidade.Items.Clear();
            string modelo = txtPesquisa.Text;
            try
            {
                List<Pecas> ListaPecas = new List<Pecas>();
                string comando = $"SELECT * FROM pecas WHERE UPPER(modelo) LIKE UPPER('%{modelo}%')";
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
                    string[] row = { P.Id.ToString(), P.Marca, P.Modelo, P.Cor };
                    var listViewItem = new ListViewItem(row);
                    lstCompatibilidade.Items.Add(listViewItem);
                }
                conn.Close();
            }
            catch
            {

            }
            finally
            {

            }
        }

        private void labelModelo_Click(object sender, EventArgs e)
        {

        }



        private void Cadastrar_Click(object sender, EventArgs e)
        {
            string marca = "", modelo = "", cor = "", caixa = "", grau_importancia, compatibilidade = "";
            int quantidade = 0;

            
                if (txtMarca.Text != "" && txtModelo.Text != "" && txtCor.Text != "" && txtCaixa.Text != "")
                {
                    marca = txtMarca.Text;
                    modelo = txtModelo.Text;
                    cor = txtCor.Text;
                    caixa = txtCaixa.Text;

                    grau_importancia = selectImp.Text;
                    if (grau_importancia == "Alto")
                        grau_importancia = "A";
                    else if (grau_importancia == "Médio")
                        grau_importancia = "M";
                    else if (grau_importancia == "Médio_Baixo")
                        grau_importancia = "MB";
                    else if (grau_importancia == "Baixo")
                        grau_importancia = "B";
                    else
                        grau_importancia = "E";


                    if (txtQuantidade.Text != "")
                        quantidade = int.Parse(txtQuantidade.Text);


                    if (checkBoxNao.Checked == true)
                        compatibilidade = "VAZIO";
                    else if (checkBoxSim.Checked == true)
                    {
                        string idSelecionado = "";
                        foreach (ListViewItem item in lstCompatibilidade.SelectedItems)
                        {
                            idSelecionado += item.SubItems[0].Text + ", ";
                        }
                        idSelecionado = idSelecionado.TrimEnd(',', ' ');
                        compatibilidade = idSelecionado;
                    }
                    else
                        compatibilidade = "VAZIO";


                try
                {
                    string comando = $"INSERT INTO pecas VALUES (DEFAULT,'{marca}','{modelo}','{cor}',{quantidade},'{grau_importancia}','{caixa}','{compatibilidade}')";
                    Conexao aux = new Conexao();
                    MySqlConnection conn = aux.do_connection();
                    conn.Open();
                    MySqlCommand command = new MySqlCommand(comando, conn);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Sucesso!", "Sucesso!", MessageBoxButtons.OK);
                    var cadastrarpeca = new CadastrarPeca();
                    cadastrarpeca.Show();
                    this.Dispose();
                    conn.Close();
                }

                catch
                {
                    MessageBox.Show("Erro!", "Peça não foi cadastrada!", MessageBoxButtons.OK);
                }
                   
                }
                else
                {
                    MessageBox.Show("Há campos vazios no formulário!", "Erro!", MessageBoxButtons.OK);
                    CadastrarPeca new_screen = new CadastrarPeca();
                    new_screen.Show();
                    this.Dispose();
                }
        }

        private void txtQuantidade_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void CadastrarPeca_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
