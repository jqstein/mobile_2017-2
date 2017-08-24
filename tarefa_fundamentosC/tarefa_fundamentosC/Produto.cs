using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarefa_fundamentosC
{
    class Produto
    {
        private int codigo=0, quantidade=0;
        private string nome, tipo;
        private string valor;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public int Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }
        public string Valor
        {
            get { return valor; }
            set { valor = value; }
        }
    }
}
