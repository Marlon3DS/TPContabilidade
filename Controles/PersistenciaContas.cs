using Modelos;
using System;
using System.Collections.Generic;
using System.Data;

namespace Controles
{
    public class PersistenciaContas : Persistencia
    {
        public override void EmpacotarParametros(object objeto, Metodo metodo)
        {
            ContaT operacao = (ContaT)objeto;
            Acesso.LimparParametros();
            if (metodo == Metodo.Alterar || metodo == Metodo.Excluir)
            {
                Acesso.AdicionarParametros("@Id", operacao.Id);
            }
            if (metodo == Metodo.Alterar || metodo == Metodo.Inserir)
            {
                Acesso.AdicionarParametros("@Nome", operacao.Nome);
                Acesso.AdicionarParametros("@TipoConta", operacao.TipoConta);
                Acesso.AdicionarParametros("@Saldo", operacao.Saldo);
            }
        }

        public List<ContaT> ConsultarConta()
        {
            DataTable dt = Consultar(Modelo.Contas);
            return ConverterToLista(dt);
        }

        public List<ContaT> ConsultarConta(ContaT contaT)
        {
            DataTable dt = Consultar(Modelo.Contas, contaT);
            return ConverterToLista(dt);
        }

        private List<ContaT> ConverterToLista(DataTable dt)
        {
            List<ContaT> contas = new List<ContaT>();
            foreach (DataRow linha in dt.Rows)
            {
                ContaT conta = new ContaT();
                conta.Id = Convert.ToInt32(linha["Id"]);
                conta.Nome = Convert.ToString(linha["Nome"]);
                conta.TipoConta = Convert.ToString(linha["TipoConta"]);
                conta.Saldo = Convert.ToDouble(linha["Saldo"]);
                contas.Add(conta);
            }
            return contas;
        }
    }
}
