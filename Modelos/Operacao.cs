using System;

namespace Modelos
{
    public class Operacao
    {
        public int Id { get; private set; }
        public DateTime Data { get; private set; }
        public string Local { get; private set; }
        public ContaT Destino { get; private set; }
        public ContaT Origem { get; private set; }
        public string Historico { get; private set; }
        public double Valor { get; private set; }

        public Operacao(int id, DateTime data, string local, ContaT destino, ContaT origem, string historico, double valor)
        {
            Id = id;
            Data = data;
            Local = local;
            Destino = destino;
            Origem = origem;
            Historico = historico;
            Valor = valor;
        }
    }
}
