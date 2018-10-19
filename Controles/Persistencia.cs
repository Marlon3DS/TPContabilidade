using AcessoDados;
using System;
using System.Data;

namespace Controles
{
    abstract class Persistencia
    {
        //Variavel de Instancia de Acesso a Bancos SQL Server
        public AcessoSqlServer Acesso { get; protected set; }

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

        //Metodo Sobrecarregado para Consultar Tudo
        public virtual DataTable Consultar(Modelo modelo)
        {
            try
            {
                Acesso.LimparParametros();
                return Acesso.MetodoConsulta(CommandType.StoredProcedure, "usp" + modelo.ToString() + Metodo.ConsultarTudo.ToString());
            }
            catch (ConexaoException mensagem)
            {
                throw new Exception(mensagem.Message);
            }
        }

        //Metodo Sobrecarregado para Consultar por Id
        public virtual DataTable Consultar(object objeto, Modelo modelo)
        {
            try
            {
                EmpacotarParametros(objeto, Metodo.ConsultarId);
                return Acesso.MetodoConsulta(CommandType.StoredProcedure, "usp" + modelo.ToString() + Metodo.ConsultarId.ToString());
            }
            catch (ConexaoException mensagem)
            {
                throw new Exception(mensagem.Message);
            }
        }

        //Metodo Abstrato para Empacotar os Parametros
        public abstract void EmpacotarParametros(object objeto, Metodo metodo);

        private string ExecutarMetodo(Modelo modelo, Metodo metodo)
        {
            try
            {
                return Convert.ToString(Acesso.MetodoPersistencia(CommandType.StoredProcedure, "usp" + modelo.ToString() + metodo.ToString()));
            }
            catch (ConexaoException mensagem)
            {
                return mensagem.Message;
            }
        }
    }
}
