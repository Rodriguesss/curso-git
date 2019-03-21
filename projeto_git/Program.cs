using System;

namespace projeto_git {
    class Program {
        static void Main(string[] args) {
            Console.Write("Seu nome: ");
            string nome = Console.ReadLine();
            Console.Write("Seu email: ");
            string email = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"Informações: nome: {nome}, email: {email}");
            Console.WriteLine();
            Console.WriteLine("Comandos Git:");
            Console.WriteLine($"Reconhecimento de usuário: git config --global user.name '{nome}'");
            Console.WriteLine($"Reconhecimento de email: git config --global user.email '{email}'");
            Console.WriteLine();
            Console.WriteLine("Commitar:");
            Console.WriteLine("Verificar o status: git status");
            Console.WriteLine("Cor vermelha: arquivos que não foram commitados.");
            Console.WriteLine("Cor verde: arquivos analizados pelo git.");
            Console.WriteLine("Escolher o arquivo para a commitação: git add . (seleciona todos)");
            Console.WriteLine("Commitando: git commit -m 'Commit feito com sucesso.'");
            Console.WriteLine();
            Console.WriteLine("Voltar ao ultimo commit:");
            Console.WriteLine("Comando 1: git clean -df");
            Console.WriteLine("Em seguida: git checkout -- .");


        }
    }
}
