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
                return (Alterar() ? true : false);
            } else if (option == "3")
            {
                return (Listar() ? true : false);
            } else if (option == "4")
            {
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
            if (cadastro.Contains(produto.Codigo))
            {
                cadastro[produto.Codigo] = produto;
                return true;
            } else
            {
                return false;
            }
            
        }
        public bool Listar()
        {
            Console.Clear();
            Console.WriteLine("══════════════════Cadastro de Produtos════════════════════");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Listar produtos:");
            Console.WriteLine(" ");
            Console.WriteLine("Pressione ENTER para listar todos os produtos ou pressione ESPACO para pesquisar: ");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                Console.WriteLine("CÓDIGO | NOME | TIPO | QUANTIDADE | VALOR");
                foreach (DictionaryEntry de in cadastro)
                {
                    Produto produto = (Produto)de.Value;
                    Console.WriteLine(" | " + produto.Codigo + " | " + produto.Nome + " | " + produto.Tipo + " | " + produto.Quantidade + " | " + produto.Valor + " |");

                }
                Console.ReadKey();
                return true;
            } else if (key.Key == ConsoleKey.Spacebar)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Digite o código do produto: ");
                int codigo = Convert.ToInt32(Console.ReadLine());
                if (cadastro.Contains(codigo))
                {
                    Console.WriteLine("CÓDIGO | NOME | TIPO | QUANTIDADE | VALOR");
                    Produto produto = (Produto)cadastro[codigo];
                    Console.WriteLine(" | " + produto.Codigo + " | " + produto.Nome + " | " + produto.Tipo + " | " + produto.Quantidade + " | " + produto.Valor + " |");
                    Console.ReadKey();
                    return true;
                } else
                {
                    return false;
                }
            } else
            {
                return false;
            }
        }
        public bool Excluir()
        {
            int codigo = 0;
            Console.Clear();
            Console.WriteLine("══════════════════Cadastro de Produtos════════════════════");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Excluir produto:");
            Console.WriteLine(" ");
            Console.Write("Código: ");
            codigo = Convert.ToInt32(Console.ReadLine());
            cadastro.Remove(codigo);
            return true;
        }
    }
}
