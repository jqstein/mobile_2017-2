using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarefa_fundamentosC
{
    class Program
    {
        static void Main(string[] args)
        {
            string option;
            Cadastro cadastro = new Cadastro();
            for (int i = 1; i != 0;)
            {

                Console.WriteLine("══════════════════Cadastro de Produtos════════════════════");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("Escolha as opção desejada: ");
                Console.WriteLine(" ");
                Console.WriteLine("1 - INCLUIR");
                Console.WriteLine("2 - ALTERAR");
                Console.WriteLine("3 - LISTAR");
                Console.WriteLine("4 - EXCLUIR");
                Console.WriteLine("5 - SAIR");

                option = Convert.ToString(Console.ReadLine());
                if (option == "5") Environment.Exit(0);
                if (cadastro.Operacao(option))
                {
                    Console.Clear();
                    Console.WriteLine(" ");
                    Console.WriteLine("Operação realizada com sucesso!");
                    Console.WriteLine(" ");
                } else
                {
                    Console.Clear();
                    Console.WriteLine(" ");
                    Console.WriteLine("Ops! Ocorreu algum problema. Por favor, repita a operação.");
                    Console.WriteLine(" ");
                }


            }
        }
    }
}
