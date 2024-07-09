Empresa empresa = new Empresa();
bool sair = false;

while (!sair)
{
    Console.WriteLine("=== Menu ===");
    Console.WriteLine("1. Adicionar funcionário de tempo integral");
    Console.WriteLine("2. Adicionar funcionário de meio período");
    Console.WriteLine("3. Remover funcionário");
    Console.WriteLine("4. Exibir informações de todos os funcionários");
    Console.WriteLine("5. Adicionar projeto(s) a um funcionário");
    Console.WriteLine("6. Sair do programa");
    Console.Write("Escolha uma opção: ");

    int opcao = Convert.ToInt32(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            AdicionarFuncionarioTempoIntegral(empresa);
            break;
        case 2:
            AdicionarFuncionarioMeioPeriodo(empresa);
            break;
        case 3:
            RemoverFuncionario(empresa);
            break;
        case 4:
            ExibirInformacoesFuncionarios(empresa);
            break;
        case 5:
            AdicionarProjeto(empresa);
            break;
        case 6:
            sair = true;
            break;
        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            break;
    }
}

static void AdicionarFuncionarioTempoIntegral(Empresa empresa)
{
    Console.Write("Digite o nome do funcionário: ");
    string nome = Console.ReadLine();
    Console.Write("Digite a matrícula do funcionário: ");
    int matricula = Convert.ToInt32(Console.ReadLine());
    Console.Write("Digite o salário mensal do funcionário: ");
    double salarioMensal = Convert.ToDouble(Console.ReadLine());

    var funcionario = new FuncionarioTempoIntegral(nome, matricula, salarioMensal);
    empresa.AdicionarFuncionario(funcionario);
}

static void AdicionarFuncionarioMeioPeriodo(Empresa empresa)
{

    Console.Write("Digite o nome do funcionário: ");
    string nome = Console.ReadLine();
    Console.Write("Digite a matrícula do funcionário: ");
    int matricula = Convert.ToInt32(Console.ReadLine());
    Console.Write("Digite o valor por hora: ");
    double salarioPorHora = Convert.ToDouble(Console.ReadLine());
    Console.Write("Digite o número de horas trabalhadas: ");
    int horasTrabalhadas = Convert.ToInt32(Console.ReadLine());

    var funcionario = new FuncionarioMeioPeriodo(nome, matricula, salarioPorHora, horasTrabalhadas);
    empresa.AdicionarFuncionario(funcionario);
}

static void RemoverFuncionario(Empresa empresa)
{

    Console.Write("Digite a matrícula do funcionário a ser removido: ");
    int matricula = Convert.ToInt32(Console.ReadLine());

    empresa.RemoverFuncionario(matricula);
}

static void ExibirInformacoesFuncionarios(Empresa empresa)
{
    empresa.ExibirFuncionarios();
}

static void AdicionarProjeto(Empresa empresa)
{

    Console.Write("Digite a matrícula do funcionário: ");
    int matricula = Convert.ToInt32(Console.ReadLine());

    var funcionario = empresa.BuscarFuncionario(matricula);
    if (funcionario != null)
    {
        Console.Write("Quantos projetos deseja adicionar? ");
        int quantidadeProjetos = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < quantidadeProjetos; i++)
        {
            Console.Write($"Digite o nome do projeto {i + 1}: ");
            string projeto = Console.ReadLine();
            funcionario.AdicionarProjeto(projeto);
        }

        Console.WriteLine("Projetos adicionados com sucesso.");
    }
    else
    {
        Console.WriteLine("Funcionário não encontrado.");
    }
}