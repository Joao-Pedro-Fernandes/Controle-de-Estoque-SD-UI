﻿using MySql.Data.MySqlClient;
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
    public partial class CadastrarVidro : Form
    {
        public CadastrarVidro()
        {
            InitializeComponent();
        }

        private void voltarbtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
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


                try
                {
                    string comando = $"INSERT INTO vidros VALUES (DEFAULT,'{marca}','{modelo}','{cor}',{quantidade},'{grau_importancia}','{caixa}','{compatibilidade}')";
                    Conexao aux = new Conexao();
                    MySqlConnection conn = aux.do_connection();
                    conn.Open();
                    MySqlCommand command = new MySqlCommand(comando, conn);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Sucesso!", "Sucesso!", MessageBoxButtons.OK);
                    var cadastrarpeca = new CadastrarVidro();
                    cadastrarpeca.Show();
                    this.Dispose();
                    conn.Close();
                }
                catch
                {
                    MessageBox.Show("Erro!", "Vidro não foi cadastrado!", MessageBoxButtons.OK);
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
