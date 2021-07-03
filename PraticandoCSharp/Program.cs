using System;
using PraticandoCSharp.Listas;

namespace PraticandoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            DuplamenteEncadeada<object> lista = new DuplamenteEncadeada<object>();

            //  Adicionando
            Console.WriteLine("Está vazia? " + lista.estaVazia());
            lista.adicionarFim('A');
            lista.adicionarFim('B');
            lista.adicionarFim('C');
            //lista.adicionarFim('C');
            lista.adicionarInicio('X');
            lista.adicionarPosicao('Y', 4);
            Console.WriteLine("Está vazia? " + lista.estaVazia());
            Console.WriteLine("Existe dado? " + lista.existeDado('C'));
            Console.WriteLine("Existe dado? " + lista.existeDado('P'));

            lista.listar();
            Console.WriteLine();

            // Buscar
            Console.WriteLine("Buscar Valor: " + lista.buscar(3).Dado);
            Console.WriteLine("Buscar posição de um dado: " + lista.buscarPosicao('B'));

            //  Tamanho da lista
            Console.WriteLine("Tamanho da lista: " + lista.tamanhoLista());

            lista.removerFim();
            lista.removerInicio();
            lista.removerPosicao(1);

            lista.listar();

            // Limpar Lista
            lista.LimparLista();

            

            //  Escrevendo no console
            //consoleWrite();

            //  Definindo variáveis de cada tipo
            //variaveis();

            //  Conversão de tipo
            //convertFunction();

            //  Inputs - Entradas do usuário
            //userInputs();

            //  Programas que Chico pediu
            //question1();
            //question2();
            //question3();
            //question4();
            //question5();
            //question6();
            //question7(11, 03, 2020);
            //question8();
        }
        public static void consoleWrite()
        {
            Console.WriteLine("Hello World!");

            Console.Write("Caio");
            Console.Write("Almeida");
        }

       

        public static void convertFunction()
        {
            //  Implícita (Conversão automática)
            int myInt = 9;
            double myDouble = myInt;

            //  Explícita (Conversão manual)
            double newDouble = 9.33;
            int newInt = (int)newDouble;

            //  Método Convert.TO
            Console.WriteLine("\n\nConvertendo AQUI:");
            Console.WriteLine("Convertendo para Boolean: " + Convert.ToBoolean(0));
            Console.WriteLine("Convertendo para Double: " + Convert.ToDouble(12));
            Console.WriteLine("Convertendo para String: " + Convert.ToString(123));
            Console.WriteLine("Convertendo para Int: " + Convert.ToInt32(3.33));
            Console.WriteLine("Convertendo para Long: " + Convert.ToInt64(12));
        }

        public static void userInputs()
        {
            Console.WriteLine("\nENTRADAS DO USUÁRIO:");

            Console.Write("Informe seu nome: ");
            var name = Console.ReadLine();
            Console.WriteLine("Bem vindo(a) " + name + ", é um prazer!!");

            Console.Write("Informe sua idade: ");
            var age = Int32.Parse(Console.ReadLine());
            Console.WriteLine("O dobro da sua idade é : " + (age * 2));

            Console.WriteLine("Aperte uma tecla qualquer:");
            var button = Console.ReadKey().Key;
            Console.WriteLine("Você apertou a tecla: " + button);
        }

        public static void question1()
        {
            Console.Write("\nInforme seu nome: ");
            string neoName = Console.ReadLine();
            Console.Write("Informe seu sobrenome: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Seu nome completo é: " + neoName + " " + lastName);
        }

        public static void question2()
        {
            Console.Write("\nInforme um número: ");
            int number = Int32.Parse(Console.ReadLine());
            if (number % 2 == 0) Console.WriteLine(number + " é PAR");
            else Console.WriteLine(number + " é IMPAR");
        }

        public static void question3()
        {
            Console.Write("Informe um número: ");
            int num = Int32.Parse(Console.ReadLine());
            int accumulator = 0;

            for (int i = 0; i < num; i++)
            {
                if (i % 2 == 0) accumulator += i;
            }

            Console.WriteLine(accumulator);
        }

        public static void question4()
        {
            Console.Write("Informe um valor: ");
            int value = int.Parse(Console.ReadLine());
            int accumulator = 0;

            for (int i = 0; i < value; i++)
            {
                if (i % 3 == 0) accumulator++;
            }

            Console.WriteLine(accumulator + " números são multiplos de 3!!");
        }

        public static void question5()
        {
            Console.Write("Informe um valor: ");
            int value = int.Parse(Console.ReadLine());
            int safeValue = value;
            int result = 1;

            while (value >= 1)
            {
                result *= value;
                value--;
            }

            Console.WriteLine("O fatorial de " + safeValue + " é : " + result);
        }

        public static void question6()
        {
            Console.WriteLine("### Calculadora de Console ###");

            Console.Write("Informe o primeiro valor: ");
            int firstValue = int.Parse(Console.ReadLine());

            Console.Write("Informe o segundo valor: ");
            int secondValue = int.Parse(Console.ReadLine());

            Console.Write("Informe a operação (soma: +, subtração: -, multiplicação: *, divisão: /): ");
            string operation = Console.ReadLine();

            switch(operation)
            {
                case "+":
                    Console.WriteLine("Resultado da SOMA é: " + (firstValue + secondValue));
                    break;
                case "-":
                    Console.WriteLine("Resuultado da SUBTRAÇÂO: " + (firstValue - secondValue));
                    break;
                case "*":
                    Console.WriteLine("Resultado da MULTIPLICAÇÂO: " + (firstValue * secondValue));
                    break;
                case "/":
                    Console.WriteLine("Resultado da DIVISÃO: " + (firstValue / secondValue));
                    break;
                default:
                    Console.WriteLine("Operação Inválida!");
                    break;
            }
        }

        public static void question7(int day, int month, int year)
        {
            Console.WriteLine(day + "/" + month + "/" + year);
        }

        public static void question8()
        {
            Console.WriteLine("### Menu de exercícios ###");

            Console.WriteLine("1 - Questão do nome");
            Console.WriteLine("2 - Questão do PAR ou IMPAR");
            Console.WriteLine("3 - Somador de númreos PAR");
            Console.WriteLine("4 - Multiplos de 3");
            Console.WriteLine("5 - Fatorial");
            Console.WriteLine("6 - Calculadora");
            Console.WriteLine("7 - Data");

            Console.Write("\nInforme o número da questão: ");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    question1();
                    break;
                case 2:
                    question2();
                    break;
                case 3:
                    question3();
                    break;
                case 4:
                    question4();
                    break;
                case 5:
                    question5();
                    break;
                case 6:
                    question6();
                    break;
                case 7:
                    question7(25, 12, 2021);
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }
    }
}
