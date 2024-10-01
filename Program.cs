using System;
using System.Globalization;

namespace PrimeiroPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            int operation =1;
            while (operation != 0)
            {

                System.Console.WriteLine(" \n 1 - Soma \n 2 - Subtrair \n 3 - Multiplicar \n 4 - Dividir \n 5 - Sair \n");

                System.Console.Write("Digite a operação desejada:  ");

                while (!int.TryParse(Console.ReadLine(), out operation) || operation < 0 || operation > 5)
                {
                    System.Console.WriteLine("Numero invalido. Digite um numero das opções acima");
                }

                if (operation == 5)
                {
                    break;
                }
                else
                {
                    System.Console.WriteLine(" Digite o primeiro valor: ");
                double firstvalue = 0;
                while (!double.TryParse(Console.ReadLine(), out firstvalue))
                {
                    System.Console.WriteLine("Numero invalido. Por favor digite um numero ");
                }

                System.Console.WriteLine("Digite o segundo valor: ");
                double secondvalue = 0;
                while (!double.TryParse(Console.ReadLine(), out secondvalue))
                {
                    System.Console.WriteLine("Numero invalido. Por favor digite um numero ");
                }

                    double result = 0;

                    switch (operation)
                    {
                        case 1:
                            result = firstvalue + secondvalue;
                            break;
                        case 2:
                            result = firstvalue - secondvalue;
                            break;
                        case 3:
                            result = firstvalue * secondvalue;
                            break;
                        case 4:
                            result = firstvalue / secondvalue;
                            break;
                    }

                    System.Console.WriteLine("\n O resultado é " + result);

                }
            }

            System.Console.WriteLine("\n ----------Saindo----------");
        }
    }
}