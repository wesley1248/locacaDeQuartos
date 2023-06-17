using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoDeQuartos {
    internal class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciado"); // Imprime "Iniciado"

            int NumeroDeQuartos = 10; // Define o número total de quartos disponíveis como 10

            Usuario[] Clientes = new Usuario[NumeroDeQuartos]; // Cria um array de objetos do tipo Usuario com o tamanho igual ao número de quartos disponíveis

            Console.Write("Quantos quartos serão alugados?: "); // Pergunta ao usuário quantos quartos serão alugados
            int quartosAlugados = int.Parse(Console.ReadLine()); // Lê a entrada do usuário e converte para inteiro

            int numeroDoQuarto = 1; // Variável para controlar o número do quarto

            for (int i = 0; i < quartosAlugados; i++)
            {
                Console.WriteLine("Aluguel #" + numeroDoQuarto); // Imprime o número do aluguel

                Console.Write("Nome: "); // Pede o nome do cliente
                string nome = Console.ReadLine(); // Lê a entrada do usuário e armazena em uma variável

                Console.Write("Email: "); // Pede o email do cliente
                string email = Console.ReadLine(); // Lê a entrada do usuário e armazena em uma variável

                Console.Write("Quarto: "); // Pede o número do quarto
                int quarto = int.Parse(Console.ReadLine()); // Lê a entrada do usuário e converte para inteiro

                Clientes[i] = new Usuario { Nome = nome, Email = email, Quarto = quarto }; // Cria um novo objeto Usuario com os dados fornecidos e o armazena no array de Clientes
                numeroDoQuarto++; // Incrementa o número do quarto

                Console.WriteLine(); // Imprime uma linha em branco
            }

            for (int i = 1; i < NumeroDeQuartos; i++)
            {
                if (Clientes[i] != null) // Verifica se o quarto está alugado
                {
                    Console.Write(i + ": " + Clientes[i].Nome + ", " + Clientes[i].Email); // Imprime o número do quarto, nome e email do cliente
                    Console.WriteLine(); // Imprime uma linha em branco
                }
            }

            Console.ReadKey(); // Aguarda o usuário pressionar uma tecla antes de encerrar o programa
        }
    }
}

