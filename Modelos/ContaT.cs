namespace Modelos
{
    public class ContaT
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public Tipo TipoConta { get; private set; }
        public double Saldo { get; private set; }

        public ContaT(int id, string nome, Tipo tipo)
        {
            Id = id;
            Nome = nome;
            TipoConta = tipo;
            Saldo = 0;
        }

        public ContaT(int id, string nome, Tipo tipo, double saldo)
        {
            Id = id;
            Nome = nome;
            TipoConta = tipo;
            Saldo = saldo;
        }

        public void Retirar(double valor)
        {
            Saldo -= valor;
        }

        public void Adcionar(double valor)
        {
            Saldo += valor;
        }
    }
}
