using Modelos;

namespace Controles
{
    class PersistenciaContas : Persistencia
    {
        public override void EmpacotarParametros(object objeto, Metodo metodo)
        {
            ContaT operacao = (ContaT)objeto;
            Acesso.LimparParametros();
            if (metodo == Metodo.Alterar || metodo == Metodo.Excluir)
            {
                Acesso.AdicionarParametros("@Id", operacao.Id);
            }
            else
            {
                if (metodo == Metodo.Alterar || metodo == Metodo.Inserir)
                {
                    Acesso.AdicionarParametros("@Nome", operacao.Nome);
                    Acesso.AdicionarParametros("@TipoConta", operacao.TipoConta);
                    Acesso.AdicionarParametros("@Saldo", operacao.Saldo);
                }
            }
        }
    }
}
