string opcao;
bool exibirMenu = true;

while(exibirMenu) {

    Console.WriteLine("  ");
    Console.WriteLine("Digite a sua opcao: ");
    Console.WriteLine("1 - Cadastrar cliente");
    Console.WriteLine("2 - Buscar cliente");
    Console.WriteLine("3 - Apagar cliente");
    Console.WriteLine("4 - Encerrar");
    
    opcao = Console.ReadLine();

    Console.WriteLine($"Você escolher a opção: {opcao}");

    switch(opcao) {
        case "1":
            Console.WriteLine("Cadastro cliente");
            break;

        case "2":
            Console.WriteLine("Buscar cliente");
            break;

        case "3":
            Console.WriteLine("Apagar cliente");
            break;

        case "4":
            Console.WriteLine("Encerrando...");
            exibirMenu = false;
            // Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}

Console.WriteLine("O programa se encerrou");