using System.Data;

public class Carro : Veiculo
{
    private int NumeroDePortas;
    public void AbirPortaMalas()
    {
        Console.WriteLine("O porta malas está aberto.");
    }
    public void ExibirInformacoes()
    {
            Console.WriteLine($"{Marca}, modelo de Carro {Modelo}, número de portas{NumeroDePortas}");
    }
    public Carro(string Marca, string Modelo, int Ano, int NumeroDePortas): base(Marca, Modelo, Ano)
    {
        this.NumeroDePortas = NumeroDePortas;
    }
}