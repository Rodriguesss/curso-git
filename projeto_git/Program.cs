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
            Console.WriteLine();
            Console.WriteLine("Desfazer ultimo commit:");
            Console.WriteLine("Desfazendo mas mantendo alterações nos arquivos: git reset --soft HEAD~1");
            Console.WriteLine("Desfazendo e alterando os arquivos(PERIGOSO): git reset --hard HEAD~1");
            Console.WriteLine();
            Console.WriteLine("Navegar em commits:");
            Console.WriteLine("Entrar em commit: git checkout 'codigo'");
            Console.WriteLine("Voltar para commit atual: git checkout 'branch'");
            Console.WriteLine();
            Console.WriteLine("Vincular repositório remoto ao local:");
            Console.WriteLine("Para associar: git remote add origin 'URI do repositório remoto'");
            Console.WriteLine("Associar a um outro respositório remoto: git remote set-url origin 'URI do repositório remoto'");
            Console.WriteLine();
            Console.WriteLine("Subir seu projeto para o GitHub: ");
            Console.WriteLine("Primeiro push: git push -u origin master");
            Console.WriteLine("Comando após primeiro push: git push");
            Console.WriteLine();
            Console.WriteLine("Como baixar um projeto do GitHub:");
            Console.WriteLine("Clonar: git clone 'link do projeto'");
            Console.WriteLine();
            Console.WriteLine("Atualizar repositório local:");
            Console.WriteLine("Comando para atualizar: git pull origin master");
            Console.WriteLine();

        }
    }
}
