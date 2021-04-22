using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraPOO.ConsoleApp
{
    class Program
    {
        
        static void Main(string[] args)
        {

            Calculadora operacao = new Calculadora();

            while (true)
            {

                operacao.Menu();
                operacao.Opcao = Convert.ToInt32(Console.ReadLine());

                if (operacao.Opcao == 5)
                {
                    operacao.VisualizarOperacoes();
                    continue;

                }

                if (operacao.Opcao == 6)
                {
                    break;
                }
                
                if (operacao.ValidaMenu()) {
                    Console.WriteLine("Opção Inválida!");
                    Console.ReadLine();

                    continue;
                }

                operacao.InserirNumeros();
              
                if (operacao.Opcao == 1)
                {
                    operacao.Somar();
                    Console.ReadLine();
                }

                else if (operacao.Opcao == 2)
                {
                    operacao.Subtrair();
                    Console.ReadLine();
                }

                else if (operacao.Opcao == 3)
                {
                    operacao.Multiplicar();
                    Console.ReadLine();
                }

                else if (operacao.Opcao == 4)
                {
                    operacao.Dividir();
                    Console.ReadLine();
                }



                operacao.RegistrarOperacao();
                Console.WriteLine(operacao.Resultado);
                operacao.ContadorOperacao++;
                Console.ReadLine();
                Console.Clear();
            }
        }
    }

    
}
