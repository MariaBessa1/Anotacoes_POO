// See https://aka.ms/new-console-template for more information
using System.Data;
using System.Reflection.Metadata.Ecma335;

Console.WriteLine("Bem vindo(a) ao MiniMetacritic!");

var titulos = new List<Title>();
var novoJogo = new Game();


while (true) //Enquanto n apertar p sair, mantém o programa rodando 
{
    Console.WriteLine(
    """
    Digite a opção desejada:
    1 - Cadastrar Título
    2 - Mostrar Título
    0 - Sair
    """);

    var opcao = Console.ReadLine();

void cadastrarTitulo ()
{
    Console.WriteLine("===NOVO CADASTRO DE TÍTULO===");

    Console.WriteLine("===DIGITE O NOME DO TÍTULO===");
    var nome = Console.ReadLine();
    Console.WriteLine("===DIGITE A DATA DE LANÇAMENTO (YYYY-MM-DD)===");
    var dataDeLancamento = Console.ReadLine();
    Console.WriteLine("===DIGITE A NOTA DOS CRÍTICOS===");
    var metaScore = Console.ReadLine();
    Console.WriteLine("===DIGITE A NOTA DO PÚBLICO===");
    var userScore = Console.ReadLine();

    titulos.Add( new()
        {
        Name = nome,
        ReleaseData = DateTime.Parse(dataDeLancamento),
        MetaScore = int.Parse(metaScore),
        UserScore = int.Parse(userScore)
        });
}

    switch (opcao)
    {
        case "0":
            Environment.Exit(0);
            break;

        case "1":
            cadastrarTitulo();
            break;

        case "2":
            Console.WriteLine($"===TITULOS===");
            titulos.ForEach(titulos => Console.WriteLine(titulos.Name));
            break;

        default:
            Console.WriteLine("Opção inválida. Tente novamente");
            break;
    }
}
