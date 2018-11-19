using System;

namespace Modelos
{
    public class Operacao
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string Local { get; set; }
        public int Destino { get; set; }
        public int Origem { get; set; }
        public string Historico { get; set; }
        public double Valor { get; set; }

        public Operacao() { }

        public Operacao(int id, DateTime data, string local, int destino, int origem, string historico, double valor)
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
