public class Moto : Veiculo
{
    public Moto(double taxa) : base(taxa) { }

    public override double CalcularValorTotal(int numeroDias)
    {
        return taxaDiaria * numeroDias;
    }
}