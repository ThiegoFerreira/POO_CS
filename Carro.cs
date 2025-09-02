public class Carro : Veiculo
{
    public Carro(double taxa) : base(taxa) { }

    public override double CalcularValorTotal(int numeroDias)
    {
        return taxaDiaria * numeroDias;
    }
}