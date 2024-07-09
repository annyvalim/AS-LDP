public abstract class Funcionario
{
    public string nome;
    public int matricula;
    public List<string> projetos;

    public Funcionario(string nome, int matricula)
    {
        this.nome = nome;
        this.matricula = matricula;
        projetos = new List<string>();
    }

    public void AdicionarProjeto(string projeto)
    {
        projetos.Add(projeto);
    }

    public void AdicionarProjeto(List<string> projetos)
    {
        this.projetos.AddRange(projetos);
    }

    public abstract double CalcularSalario();
    public abstract void ExibirInformacoes();
}
