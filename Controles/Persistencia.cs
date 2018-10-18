using AcessoDados;
using System;
using System.Data;

namespace Controles
{
    abstract class Persistencia
    {
        public AcessoSqlServer acesso { get; protected set; }

        public virtual string Inserir(object objeto, Modelo modelo)
        {
            EmpacotarParametros(objeto, Metodo.Inserir);
            return ExecutarMetodo(modelo, Metodo.Inserir);
        }

        public virtual string Alterar(object objeto, Modelo modelo)
        {
            EmpacotarParametros(objeto, Metodo.Alterar);
            return ExecutarMetodo(modelo, Metodo.Alterar);
        }

        public virtual string Excluir(object objeto, Modelo modelo)
        {
            EmpacotarParametros(objeto, Metodo.Excluir);
            return ExecutarMetodo(modelo, Metodo.Excluir);
        }

        public virtual DataTable Consultar(Modelo modelo)
        {
            try
            {
                acesso.LimparParametros();
                return acesso.MetodoConsulta(CommandType.StoredProcedure, "usp" + modelo.ToString() + Metodo.ConsultarTudo.ToString());
            }
            catch (ConexaoException mensagem)
            {
                throw new Exception(mensagem.Message);
            }
        }

        public virtual DataTable Consultar(object objeto, Modelo modelo)
        {
            try
            {
                EmpacotarParametros(objeto, Metodo.ConsultarId);
                return acesso.MetodoConsulta(CommandType.StoredProcedure, "usp" + modelo.ToString() + Metodo.ConsultarId.ToString());
            }
            catch (ConexaoException mensagem)
            {
                throw new Exception(mensagem.Message);
            }
        }

        public abstract void EmpacotarParametros(object objeto, Metodo metodo);

        private string ExecutarMetodo(Modelo modelo, Metodo metodo)
        {
            try
            {
                return Convert.ToString(acesso.MetodoPersistencia(CommandType.StoredProcedure, "usp" + modelo.ToString() + metodo.ToString()));
            }
            catch (ConexaoException mensagem)
            {
                return mensagem.Message;
            }
        }
    }
}
