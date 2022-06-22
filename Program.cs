using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            decimal res;

            Console.WriteLine("");
            Console.WriteLine("------ Bem vindo a Calduladora C#! ------");
            Console.WriteLine("Qual operação deseja realizar?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2- Subtração");
            Console.WriteLine("3- Divisão");
            Console.WriteLine("4- Multiplicação");
            Console.WriteLine("5- Nenhuma das alternativas.");

            Console.WriteLine("");
            Console.WriteLine("Digite a opção desejada: ");
            res = Convert.ToDecimal(Console.ReadLine());

            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: Sair(); break;
                //ou podemos chamar de outra forma
                // case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }

        }
        static void Sair()
        {
            Console.Clear();
            Console.WriteLine("Desculpe por não poder te atender, volte sempre. Obrigado!");
            Console.WriteLine("");

        }
        static void Soma()
        {
            decimal v1, v2;
            decimal resultado;

            Console.Clear();
            Console.Write("Digite o primeiro valor: ");
            v1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("O primeiro valor é: " + v1);
            Console.WriteLine("");

            Console.Write("Digite o segundo valor: ");
            v2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("O segundo valor é: " + v2);
            Console.WriteLine("");

            resultado = v1 + v2;
            //Usando o $ para fazer a interpolação e poder usar a variavel junto a string sem concatenar.
            Console.WriteLine($"O resultado da soma é: {resultado}");
            Console.WriteLine("");
            Console.WriteLine("Digite 'ENTER' para continuar");
            Console.ReadKey();
            Console.Clear();
            Menu();

        }
        static void Subtracao()
        {
            decimal v1, v2;
            decimal resultado;

            Console.Clear();
            Console.Write("Digite o primeiro valor: ");
            v1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("O primeiro valor é: " + v1);
            Console.WriteLine("");

            Console.Write("Digite o segundo valor: ");
            v2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("O segundo valor é: " + v2);
            Console.WriteLine("");

            resultado = v1 - v2;
            Console.WriteLine($"O resultado da subtração é: {resultado}");
            Console.WriteLine("");
            Console.WriteLine("Digite 'ENTER' para continuar");
            Console.ReadKey();
            Console.Clear();
            Menu();

        }
        static void Divisao()
        {
            decimal v1, v2;
            decimal resultado;

            Console.Clear();
            Console.Write("Digite o primeiro valor: ");
            v1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("O primeiro valor é: " + v1);
            Console.WriteLine("");

            Console.Write("Digite o segundo valor: ");
            v2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("O segundo valor é: " + v2);
            Console.WriteLine("");

            resultado = v1 / v2;
            Console.WriteLine($"O resultado da divisão é: {resultado}");
            Console.WriteLine("");
            Console.WriteLine("Digite 'ENTER' para continuar");
            Console.ReadKey();
            Console.Clear();
            Menu();

        }
        static void Multiplicacao()
        {
            decimal v1, v2;
            decimal resultado;

            Console.Clear();
            Console.Write("Digite o primeiro valor: ");
            v1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("O primeiro valor é: " + v1);
            Console.WriteLine("");

            Console.Write("Digite o segundo valor: ");
            v2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("O segundo valor é: " + v2);
            Console.WriteLine("");

            resultado = v1 * v2;
            Console.WriteLine($"O resultado da multiplicação é: {resultado}");
            Console.WriteLine("");
            Console.WriteLine("Digite 'ENTER' para continuar");
            Console.ReadKey();
            Console.Clear();
            Menu();

        }
    }
}
