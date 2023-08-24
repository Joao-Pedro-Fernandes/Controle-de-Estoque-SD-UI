using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Controle_de_Estoque_SD
{
    internal class Conexao
    {
        private string servidor = "192.168.1.100";
        private string bancoDados = "estoque";
        private string usuario = "";
        private string senha = "";
        private string porta = "3300";

        public MySqlConnection do_connection()
        {
            var conn = new MySqlConnection($"server=192.168.1.100; User Id=LOJA SD; port=3300; database=estoque; password=Campodomeio1;");
            return conn;
        }
    }
}
