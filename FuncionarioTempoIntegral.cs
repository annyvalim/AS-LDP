public class FuncionarioTempoIntegral : Funcionario, IBonus
{
    private double salarioMensal;

    public FuncionarioTempoIntegral(string nome, int matricula, double salarioMensal) : base(nome, matricula)
    {
        this.salarioMensal = salarioMensal;
    }

    public override double CalcularSalario()
    {
        return salarioMensal;
    }

    public override void ExibirInformacoes()
    {
        double salarioTotal = CalcularSalario() + CalcularBonus();

        Console.WriteLine($"Funcionário Integral: Nome: {nome}, Matrícula: {matricula}, Salário Mensal: R${salarioMensal}, Salário Total (com bônus): R${salarioTotal}.");
        Console.WriteLine("Projetos: " + string.Join(", ", projetos));
    }

    public double CalcularBonus()
    {
        return salarioMensal * 0.10;
    }
}
