using Modelos;
using System;
using System.Collections.Generic;
using System.Data;

namespace Controles
{
    public class PersistenciaOperacoes : Persistencia
    {
        public override void EmpacotarParametros(object objeto, Metodo metodo)
        {
            Operacao operacao = (Operacao)objeto;
            Acesso.LimparParametros();
            if (metodo == Metodo.Alterar || metodo == Metodo.Excluir)
            {
                Acesso.AdicionarParametros("@Id", operacao.Id);
            }
            else
            {
                if (metodo == Metodo.Alterar || metodo == Metodo.Inserir)
                {                    
                    Acesso.AdicionarParametros("@Data", operacao.Data);
                    Acesso.AdicionarParametros("@Local", operacao.Local);
                    Acesso.AdicionarParametros("@Destino", operacao.Destino);
                    Acesso.AdicionarParametros("@Origem", operacao.Origem);
                    Acesso.AdicionarParametros("@Historico", operacao.Historico);
                    Acesso.AdicionarParametros("@Valor", operacao.Valor);
                }
            }
        }

        public List<Operacao> ConsultarOperacao()
        {
            DataTable dt = Consultar(Modelo.Operacoes);
            return ConverterToLista(dt);
        }

        public List<Operacao> ConsultarOperacao(Operacao operacao)
        {
            DataTable dt = Consultar(Modelo.Operacoes, operacao);
            return ConverterToLista(dt);
        }

        private List<Operacao> ConverterToLista(DataTable dt)
        {
            List<Operacao> operacoes = new List<Operacao>();
            foreach (DataRow linha in dt.Rows)
            {
                Operacao operacao = new Operacao();
                operacao.Id = Convert.ToInt32(linha["Id"]);
                operacao.Data = Convert.ToDateTime(linha["Data"]);
                operacao.Destino = Convert.ToInt32(linha["Destino"]);
                operacao.Origem = Convert.ToInt32(linha["Origem"]);
                operacao.Historico = Convert.ToString(linha["Historico"]);
                operacao.Valor = Convert.ToDouble(linha["Valor"]);
                operacoes.Add(operacao);
            }
            return operacoes;
        }
    }
}
