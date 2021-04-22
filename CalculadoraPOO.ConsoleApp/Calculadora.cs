using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraPOO.ConsoleApp
{
    public class Calculadora
    {
        private double numero1;
        private double numero2;
        private int opcao;
        private double resultado;
        private int contadorOperacao;
        string[] operacaoRealizada = new string[100];

        public double Numero1 { get => numero1; set => numero1 = value; }
        public double Numero2 { get => numero2; set => numero2 = value; }
        public int Opcao { get => opcao; set => opcao = value; }
        public double Resultado { get => resultado; set => resultado = value; }
        public int ContadorOperacao { get => contadorOperacao; set => contadorOperacao = value; }
        public string[] OperacaoRealizada { get => operacaoRealizada; set => operacaoRealizada = value; }

        internal void Menu()
        {
            Console.WriteLine("Digite a opção desejada" +
                "\n1 - Somar" +
                "\n2 - Subtrair" +
                "\n3 - Multiplicar" +
                "\n4 - Dividir" +
                "\n5 - Visualizar" +
                "\n6 - Sair do programa");

        }


        internal void VisualizarOperacoes() {

            if (contadorOperacao == 0)
            {
                Console.WriteLine("Não há operações");
            }

            else
            {
                for (int i = 0; i < this.ContadorOperacao; i++)
                {
                    Console.WriteLine(this.OperacaoRealizada[i]);
                }
                Console.ReadLine();
                Console.Clear();
            }
        }

        internal string SimboloOperacao()
        {
            string simbolo = "";
            switch (this.Opcao)
            {
                case 1: simbolo = "+"; break;
                case 2: simbolo = "-"; break;
                case 3: simbolo = "x"; break;
                case 4: simbolo = "÷"; break;

                default:
                    break;
            }
            return simbolo;
        }

        internal void RegistrarOperacao() {
                       
           this.operacaoRealizada[this.contadorOperacao] = $"{Numero1} {SimboloOperacao()} {Numero2} = {this.resultado}";
        }

        internal void InserirNumeros()
        {
            Console.WriteLine("Digite o Primeiro número:");
            this.Numero1 = Convert.ToDouble(Console.ReadLine());

            do
            {
                Console.WriteLine("Digite o Segundo número:");
                this.Numero2 = Convert.ToDouble(Console.ReadLine());

                if (ConfereDivisao())
                    Console.WriteLine("Divisão por zero é indeterminada. Tente novamente!");

            } while (ConfereDivisao());

        }

        private bool ConfereDivisao()
        {
            return Opcao == 4 && Numero2 == 0;
        }

        internal double Subtrair()
        {
            return this.Resultado = numero1 - numero2;
            
        }

        internal double Multiplicar()
        {
            return this.Resultado = numero1 * numero2;
        }

        internal double Dividir()
        {                      
                return this.Resultado = numero1 / numero2;
        }

        internal double Somar()
        {
            return this.Resultado = numero1 + numero2;
        }
    }
}
