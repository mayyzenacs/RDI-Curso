using System.IO;
using System.Runtime.ConstrainedExecution;

string path = "dados";
string file = "cadastro.csv";

if (!File.Exists(path) || !File.Exists(file))
{
    Directory.CreateDirectory(path);
    string filepath = Path.Combine(path, file);
}

string name;
string age;
int choice;

do
{
    Console.WriteLine("Escolha uma opcao \n 1 - Fazer cadastro \n 2 - Listar usuarios \n 3 - Buscar usuarios \n 4 - Sair");
    choice = int.Parse(Console.ReadLine());

    switch (choice)
    
{
    
    case(1):
    Console.WriteLine("Faça seu cadastro");
    Console.WriteLine("Digite seu nome: ");
    name = Console.ReadLine();
    Console.WriteLine("Digite sua idade: ");
    age = Console.ReadLine();
    
    string newline = $"nome: {name}, age: {age}";
    File.AppendAllLines(file, new[] { newline });
    break;

    case(2):
    string[] lines = File.ReadAllLines(file);
    Console.WriteLine("Listando todos os usuarios...");
    foreach(string l in lines)
        {   
            Console.WriteLine(l);
        }
    break;

    case(3):
    Console.WriteLine("Busque um usuario digite o nome: ");
    string nameSearch = Console.ReadLine().ToLower();
    string[] lines2 = File.ReadAllLines(file);
    foreach (string l in lines2)
    {
        if (l.ToLower().Contains(nameSearch.ToLower()))
        {
            Console.WriteLine($"Encontrado: {l}");
        } else
                {
                    Console.WriteLine("nao encontrado");
                    break;
                }
    }
    break;

    
}
    Console.WriteLine("programa encerrado");
}
while (choice != 4);




