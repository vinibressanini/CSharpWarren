using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console._99_Exercicios
{
    internal class _000Cadastro
    {

        public void Cadastro()
        {
            System.Console.WriteLine("Seja Bem Vindo ao Sistema de Cadastro");
            System.Console.Write("\nDigite seu nome: ");

            string nome = System.Console.ReadLine();
            System.Console.Write("\nAgora digite seu sobrenome: ");
            string sobrenome = System.Console.ReadLine();
            System.Console.Write("\nPor último digite sua idade: ");
            byte idade = Convert.ToByte(System.Console.ReadLine());

            System.Console.WriteLine($"\n{nome} {sobrenome}");
            System.Console.WriteLine($"Idade: {idade}");
            System.Console.WriteLine($"\nAdeus {nome}, Até uma Próxima");
        }

    }
}
