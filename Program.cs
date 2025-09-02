namespace POO_PTI;
class Program
{
    static void Main(string[] args)
    {
        Carro carro = new Carro(50);
        Moto moto = new Moto(25); 

        int numeroDias = 10;

        double valorCarro = carro.CalcularValorTotal(numeroDias);
        double valorMoto = moto.CalcularValorTotal(numeroDias);

        Console.WriteLine($"Valor total da locação do carro por {numeroDias} dias: R${valorCarro}");
        Console.WriteLine($"Valor total da locação da moto por {numeroDias} dias: R${valorMoto}");
    }
}
