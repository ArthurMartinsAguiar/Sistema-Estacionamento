using DESAFIOFUNDAMENTOS.Models;

Estacionamento es = new Estacionamento(5,2);

bool mostrarMenu = true;
while(mostrarMenu){

    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

     switch (Console.ReadLine())
    {
        case "1":
            es.registrarVeiculo();
            break;

        case "2":
            es.removerVeiculo();
            break;

        case "3":
            es.listarVeiculos();
            break;

        case "4":
            mostrarMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");

// List<Veiculo> veiculos = new List<Veiculo>();
// veiculos.Add(new Veiculo("aaaa", 12));
// veiculos.Add(new Veiculo("bbbb", 15));

// foreach (var item in veiculos)
// {
//     Console.WriteLine(item.placa + item.horarioDeEntrada);
// }
