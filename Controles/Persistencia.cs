using AcessoDados;
using System;
using System.Collections.Generic;
using System.Data;

namespace Controles
{
    public abstract class Persistencia
    {
        //Variavel de Instancia de Acesso a Bancos SQL Server
        protected AcessoSqlServer Acesso = new AcessoSqlServer();

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

        //Metodo com parametros Opcionais para Consultar por Id ou Tudo
        protected virtual DataTable Consultar(Modelo modelo, object objeto = null)
        {
            try
            {
                if (objeto == null)
                {
                    Acesso.LimparParametros();
                    return Acesso.MetodoConsulta(CommandType.StoredProcedure, "usp" + modelo.ToString() + Metodo.ConsultarTudo.ToString());
                }
                else
                {
                    EmpacotarParametros(objeto, Metodo.ConsultarId);
                    return Acesso.MetodoConsulta(CommandType.StoredProcedure, "usp" + modelo.ToString() + Metodo.ConsultarId.ToString());
                }
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
