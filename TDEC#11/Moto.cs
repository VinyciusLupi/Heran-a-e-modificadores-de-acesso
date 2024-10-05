public class Moto : Veiculo
{
    private bool TemBagageiro;
    public void DarGrau()
    {
        Console.WriteLine("Ran Dan Dan Dan PÁ PÁ");
    }
    public void ExibirInformacoes()
    {
                Console.WriteLine($"A marca da moto é :{Marca}; o modelo da moto é: {Modelo}, o ano é: {Ano}, tem bagageiro: {TemBagageiro}");
    }
    public Moto(string Marca, string Modelo, int Ano, bool TemBagageiro): base(Marca, Modelo ,Ano)
    {
        this.TemBagageiro = TemBagageiro;
    }
}