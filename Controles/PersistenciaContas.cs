using Modelos;

namespace Controles
{
    class PersistenciaContas : Persistencia
    {
        public override void EmpacotarParametros(object objeto, Metodo metodo)
        {
            ContaT operacao = (ContaT)objeto;
            acesso.LimparParametros();
            if (metodo == Metodo.Alterar || metodo == Metodo.Excluir)
            {
                acesso.AdicionarParametros("@Id", operacao.Id);
            }
            else
            {
                if (metodo == Metodo.Alterar || metodo == Metodo.Inserir)
                {
                    acesso.AdicionarParametros("@Nome", operacao.Nome);
                    acesso.AdicionarParametros("@TipoConta", operacao.TipoConta);
                    acesso.AdicionarParametros("@Saldo", operacao.Saldo);
                }
            }
        }
    }
}
