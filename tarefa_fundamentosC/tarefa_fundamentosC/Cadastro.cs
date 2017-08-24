using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarefa_fundamentosC
{
    class Cadastro
    {
        private Hashtable cadastro = new Hashtable();
        public Cadastro()
        {

        }

        public bool Operacao(string option)
        {
            if (option == "1")
            {
                return (Incluir() ? true: false);
            } else if (option == "2")
            {
                Alterar();
                return (Alterar() ? true : false);
            } else if (option == "3")
            {
                Listar();
                return (Listar() ? true : false);
            } else if (option == "4")
            {
                Excluir();
                return (Excluir() ? true : false);
            }
            else
            {
                return false;
            }
        }
        public bool Incluir()
        {
            Produto produto = new Produto();
            Console.Clear();
            Console.WriteLine("══════════════════Cadastro de Produtos════════════════════");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Incluir novo produto:");
            Console.WriteLine(" ");
            Console.Write("Código: ");
            produto.Codigo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Produto: ");
            produto.Nome = Convert.ToString(Console.ReadLine());
            Console.Write("Tipo: ");
            produto.Tipo = Convert.ToString(Console.ReadLine()); 
            Console.Write("Quantidade: ");
            produto.Quantidade = Convert.ToInt32(Console.ReadLine());
            Console.Write("Valor: ");
            produto.Valor = Convert.ToString(Console.ReadLine());
            cadastro.Add(produto.Codigo, produto);
            return true;
        }
        public bool Alterar()
        {
            Produto produto = new Produto();
            Console.Clear();
            Console.WriteLine("══════════════════Cadastro de Produtos════════════════════");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Alterar produto:");
            Console.WriteLine(" ");
            Console.Write("Código: ");
            produto.Codigo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Produto: ");
            produto.Nome = Convert.ToString(Console.ReadLine());
            Console.Write("Tipo: ");
            produto.Tipo = Convert.ToString(Console.ReadLine());
            Console.Write("Quantidade: ");
            produto.Quantidade = Convert.ToInt32(Console.ReadLine());
            Console.Write("Valor: ");
            produto.Valor = Convert.ToString(Console.ReadLine());
            cadastro.Add(produto.Codigo, produto);
            return true;
        }
        public bool Listar()
        {
            foreach (DictionaryEntry de in cadastro)
            {
                Produto produto = de.Value;
                Console.Write("CÓDIGO | NOME | TIPO | QUANTIDADE | VALOR");
                Console.Write(" | " + produto.Codigo + " | " + produto.Nome + " | " + produto.Tipo + " | " + produto.Quantidade + " | " produto.Valor + " |");
            }
            return true;
        }
        public bool Excluir()
        {
            int codigo = 0;
            Console.Clear();
            Console.WriteLine("══════════════════Cadastro de Produtos════════════════════");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Alterar produto:");
            Console.WriteLine(" ");
            Console.Write("Código: ");
            codigo = Convert.ToInt32(Console.ReadLine());
            cadastro.Remove(codigo);
            return true;
        }
    }
}
