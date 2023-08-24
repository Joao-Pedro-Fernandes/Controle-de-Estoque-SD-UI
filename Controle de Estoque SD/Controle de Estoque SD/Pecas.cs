using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_de_Estoque_SD
{
    internal class Pecas
    {
        private int id;
        private string marca;
        private string modelo;
        private string cor;
        private int quantidade;
        private string grau_importancia;
        private string caixa;
        private string compatibilidade;

        public int Id
        {
            set { id = value; }
            get { return id; }
        }

        public string Modelo
        {
            set { modelo = value; }
            get { return modelo; }
        }

        public string Marca
        {
            set { marca = value; }
            get { return marca; }
        }

        public string Cor
        {
            set { cor = value; }
            get { return cor; }
        }

        public string Grau_importancia
        {
            set
            {
                if (value == "A")
                    grau_importancia = value;
                else if (value == "M")
                    grau_importancia = value;
                else if (value == "MB")
                    grau_importancia = value;
                else if (value == "B")
                    grau_importancia = value;
                else if (value == "E")
                    grau_importancia = value;
                else
                    grau_importancia = "E";
            }
            get { return grau_importancia; }
        }

        public int Quantidade
        {
            set { quantidade = value; }
            get { return quantidade; }
        }

        public string Caixa
        {
            set { caixa = value; }
            get { return caixa; }
        }

        public string Compatibilidade
        {
            set { compatibilidade = value; }
            get { return compatibilidade; }
        }
    }
}
