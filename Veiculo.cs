public abstract class Veiculo
{
    protected double taxaDiaria;

    public Veiculo(double taxa)
    {
        taxaDiaria = taxa;
    }
    public abstract double CalcularValorTotal(int numeroDias);
}

