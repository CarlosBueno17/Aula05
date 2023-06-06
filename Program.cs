using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula05Condicoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade;

            Console.WriteLine("Bem-vindo ao Conradito Auto ");
            Console.WriteLine("Para começar,digite a sua idade:");
           idade =Int32.Parse (Console.ReadLine());

            Console.WriteLine($"Você tem {idade} anos!");

            if (idade>= 18)
            {
                Console.WriteLine("Parabéns! Você ja pode tirar a CNH");
            }
            else
            {
                Console.WriteLine("Você não tem idade suficiente ainda...");
            }


            Console.ReadKey();
        }


        void Revisao() {
            string nome;
            int idade;
            string prof;

            Console.WriteLine("Bem-vindo ao cadastro de currículos");
            Console.WriteLine("Para começar,digite o seu primeiro nome:");
            nome = Console.ReadLine();

            Console.WriteLine("Digite o ano que você nasceu:");
            idade = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua profisão:");
            prof = Console.ReadLine();
            Console.WriteLine("\n \n");
            Console.WriteLine("Cadastro realizado com sucesso!");
            Console.WriteLine("\n");
            Console.WriteLine($"Você se chama {nome} e tem {2023 - idade}");
            Console.WriteLine($"Vagas para: {prof}");
            Console.ReadKey();


        }


    }
}
