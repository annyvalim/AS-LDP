public class FuncionarioMeioPeriodo : Funcionario, IBonus
{
    private double salarioPorHora;
    private int horasTrabalhadas;

    public FuncionarioMeioPeriodo(string nome, int matricula, double salarioPorHora, int horasTrabalhadas) : base(nome, matricula)
    {
        this.salarioPorHora = salarioPorHora;
        this.horasTrabalhadas = horasTrabalhadas;
    }

    public override double CalcularSalario()
    {
        return salarioPorHora * horasTrabalhadas;
    }

    public override void ExibirInformacoes()
    {
        double salarioTotal = CalcularSalario() + CalcularBonus();

        Console.WriteLine($"Funcionário Meio Período: Nome: {nome}, Matrícula: {matricula}, Salário por Hora: R${salarioPorHora}, Horas Trabalhadas: {horasTrabalhadas}, Salário: R${CalcularSalario()}, Salário Total (com bônus): R${salarioTotal}");
        Console.WriteLine("Projetos: " + string.Join(", ", projetos));
    }

    public double CalcularBonus()
    {
        return CalcularSalario() * 0.05;
    }
}
