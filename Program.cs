using System;

namespace CalculadoraSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            //perguntar qual sera a operacao
            Console.WriteLine("digite a operacao que deseja fazer? \nadicao,subtracao,multiplicacao ou divisao");
            string operacao = Console.ReadLine().ToLower();

            //pedir o 1° numero
            Console.Write("digite o primeiro numero: ");
            float num1 = float.Parse(Console.ReadLine());

            //pedir o 2° numero
            Console.Write("digite o segundo numero: ");
            float num2 = float.Parse(Console.ReadLine());

            float resultado = 0f;

            switch(operacao){
                case "adicao":
                    resultado = num1 + num2;
                break;

                case "subtracao":
                    resultado = num1 - num2;
                break;

                case "multiplicacao":
                    resultado = num1 * num2;
                break;

                case "divisao":
                    resultado = num1 / num2;
                break;

                default:
                Console.WriteLine("operacao invalida! ");
                break;
            }
            //interpolacao
            Console.WriteLine($"resultado de: {num1} com {num2} = {resultado}");
        }
    }
}
