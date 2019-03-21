using System;

namespace projeto_git {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Olá mundo!");
            Console.WriteLine();
            Console.Write($"Seu nome: ");
            string nome = Console.ReadLine();
            Console.Write($"Olá {nome}, quantos anos você tem? ");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine($"Informações: {nome}, {idade} anos.");
            
        }
    }
}
