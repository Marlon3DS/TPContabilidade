namespace Modelos
{
    public class ContaT
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string TipoConta { get; set; }
        public double Saldo { get; set; }

        public ContaT() { }

        public ContaT(int id, string nome, string tipo)
        {
            Id = id;
            Nome = nome;
            TipoConta = tipo;
            Saldo = 0.00;
        }

        public ContaT(int id, string nome, string tipo, double saldo)
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

        public override string ToString()
        {
            return Nome;
        }
    }
}
