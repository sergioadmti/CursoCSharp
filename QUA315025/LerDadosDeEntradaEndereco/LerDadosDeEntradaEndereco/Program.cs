Console.WriteLine("Digite o nome: ");
string nome = Console.ReadLine();

Console.WriteLine("Digite o endereço: ");
string endereco = Console.ReadLine();

Console.WriteLine("Digite o CPF (Apenas números): ");
ulong cpf = ulong.Parse(Console.ReadLine());

Console.WriteLine($"{nome}, CPF: {cpf}, é morador do(a) {endereco}");


