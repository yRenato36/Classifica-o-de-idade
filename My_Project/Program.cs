using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade;
            string nome;

            Console.WriteLine("Digite a sua idade: ");
            idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();
            

            if (idade < 0)
            {
                Console.WriteLine($"{nome} por favor, digite uma idade válida");
            }
            else
            {
                if (idade >= 0 && idade <= 11)
                {
                    Console.WriteLine($"O seu nome é: {nome} e a sua idade é: {idade}\n");
                    Console.WriteLine($"{nome} você é uma criança");
                }
                else if (idade >= 12 && idade <= 18)
                {
                    Console.WriteLine($"O seu nome é: {nome} e a sua idade é: {idade}\n");
                    Console.WriteLine($"{nome} você é um adolescente");
                }
                else if (idade >= 19 && idade <= 59)
                {
                    Console.WriteLine($"O seu nome é: {nome} e a sua idade é: {idade}\n");
                    Console.WriteLine($"{nome} você é um adulto");
                }
                else
                {
                    Console.WriteLine($"O seu nome é: {nome} e a sua idade é: {idade}\n");
                    Console.WriteLine($"{nome} você é um idoso");
                }
            }
            Console.ReadKey();
        }
    }
}
