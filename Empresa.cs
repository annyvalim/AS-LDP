public class Empresa
{
    private List<Funcionario> funcionarios = new List<Funcionario>();

    public void AdicionarFuncionario(Funcionario funcionario)
    {
        funcionarios.Add(funcionario);
        Console.WriteLine("Funcionário adicionado com sucesso.");
    }

    public void RemoverFuncionario(int matricula)
    {
        funcionarios.RemoveAll(f => f.matricula == matricula);
        Console.WriteLine("Funcionário removido com sucesso.");
    }

    public void ExibirFuncionarios()
    {
        foreach (var funcionario in funcionarios)
        {
            funcionario.ExibirInformacoes();
        }
    }

    public Funcionario BuscarFuncionario(int matricula)
    {
        foreach (var funcionario in funcionarios)
        {
            if (funcionario.matricula == matricula)
            {
                return funcionario;
            }
        }

        return null;
    }
}
